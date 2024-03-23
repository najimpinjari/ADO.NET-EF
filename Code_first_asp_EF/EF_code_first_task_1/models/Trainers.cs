using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF_code_first_task_1.models
{
    public class Trainers
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string city { get; set; }

        public int Experience { get; set; }
    }
}