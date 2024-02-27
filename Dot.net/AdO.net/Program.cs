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
            Console.WriteLine(" All trainers from database ");

            TrainerDb db = new TrainerDb();
            List<Trainer> trainers = db.AllTrainers();

            foreach (var t in trainers)
            {
                Console.WriteLine($"{t.Id} {t.Name} {t.City} {t.Experience} ");
            }

            Console.ReadLine();
        }
    }
}
