using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace PeoplesManagment.Models
{
    public class ModelContext: DbContext
    {
        public ModelContext()
            : base("name=ModelContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        public virtual DbSet<Peoples> Peoples { get; set; }
    }
}