using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AxcendPOC.Models
{
    [Table("Students", Schema = "CSVUpload")]
    public class Student : Common
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? Age { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }

}