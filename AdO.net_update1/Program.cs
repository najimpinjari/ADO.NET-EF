using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdO.net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ado . dot net ");
            TrainerDb db = new TrainerDb();
            //  List<Trainer> trainers = db.AllTrainers();
            List<Trainer> trainers;
            List<Student> students;


            db.AllTrainers(out trainers,out students);

            Console.WriteLine(" All trainers from database ");

            foreach (var t in trainers)
            {
                Console.WriteLine($" id {t.Id}  name {t.Name}  city {t.City} experience {t.Experience} ");
            }
            Console.WriteLine(" All trainers from database ");

            foreach (var s in students)
            {
                Console.WriteLine($"rollnumber {s.RollNumber}  trainerid{s.TrainerId} gender{s.Gender} name{s.Name} ");
            }

            Console.ReadLine();
        }
    }
}
