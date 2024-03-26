using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_princ_L
{
    class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("the Bird  is flayig.... ");

            Console.ReadLine();
        }
    }
    class Eagle : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Eagle is flying high......");

        }
    }

    class PEnguin : Bird
    {
        // penguin cannot fly so overrind fly method is not suitable 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bird eagle = new Eagle();
            Bird penguin = new PEnguin();

            eagle.Fly();
            penguin.Fly();
        }
    }
}
