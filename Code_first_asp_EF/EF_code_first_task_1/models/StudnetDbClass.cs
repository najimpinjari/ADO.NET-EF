using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EF_code_first_task_1.models
{
    public class StudnetDbClass : DBContext
    {
        public StudnetDbClass() : base("name=EFnewtask") 
        {

        }
        public DbSet<Trainers> Trainers { get; set; }
    }
}