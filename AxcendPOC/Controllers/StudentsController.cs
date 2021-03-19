using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using AxcendPOC.Data;
using AxcendPOC.Models;

namespace AxcendPOC.Controllers
{
    public class StudentsController : ApiController
    {
        private ApplicationContext db = new ApplicationContext();

        // GET: api/Students
        public IQueryable<Student> GetStudents()
        {
            return db.Students.OrderByDescending(x => x.Id);
        }

        // GET: api/Students/5
        [ResponseType(typeof(Student))]
        public async Task<IHttpActionResult> GetStudent(int id)
        {
            Student student = await db.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        

        // POST: api/Students
        //[ResponseType(typeof(Student))]
        //public async Task<IHttpActionResult> PostStudent(Student student)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Students.Add(student);
        //    await db.SaveChangesAsync();

        //    return CreatedAtRoute("DefaultApi", new { id = student.Id }, student);
        //}

        // POST: api/Students
        [ResponseType(typeof(Student))]

        public async Task<IHttpActionResult> AddCSVStudent([FromBody]List<Student> student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                List<Student> addDataCSV = new List<Student>();
                foreach (var item in student)
                {
                    addDataCSV.Add(item);
                }

                db.Students.AddRange(addDataCSV);
                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            var DataStudent = await db.Students.ToListAsync();
            return Ok(DataStudent);
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StudentExists(int id)
        {
            return db.Students.Count(e => e.Id == id) > 0;
        }
    }
}