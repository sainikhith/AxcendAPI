using AxcendPOC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AxcendPOC.Data
{
    public class ApplicationContext : DbContext
    {
        #region DB Context
        public ApplicationContext() :
          base("AxcendConnectionString")
        {
        }
        #endregion

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }

        #region Db Set Registrations
        public DbSet<Student> Students { get; set; }
        public DbSet<State> states { get; set; }

        #endregion
    }
}