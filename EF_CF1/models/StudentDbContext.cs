using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EF_CF1.models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext() : base("name=EFtaskdb")
        {

        }

        public DbSet<Trainer> trainers { get; set; }
        public DbSet<Studnet> students { get; set; }
    }
}