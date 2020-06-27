using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ELearning.Models;


namespace ELearning.DAL
{
    public class UserContext : DbContext
    {
        public UserContext()

            : base("DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<ELearning.Models.CourseCategory> CourseCategory { get; set; }

    }
}