using Sophia.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sophia.DAO
{
    public class SophiaContext : DbContext
    {
        public DbSet<Registro> Registros { get; set; }
        
        public SophiaContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false; 
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //comentado abaixo pra evitar a implementacao default do creating model
            //base.OnModelCreating(modelBuilder);

            /*
             * to implement yet
             
             */

        }
    }
}