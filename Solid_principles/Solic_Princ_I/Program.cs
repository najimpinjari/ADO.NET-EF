using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solic_Princ_I
{

    //interface for prenter
    interface Iprenter
    {
        void Print();
        void Scan();
    }

    //class implimenting printing   

    class Printer : Iprenter
    {
        public void Print()
        {
            Console.WriteLine("printing");
          //  Console.ReadLine();
        }
        public void Scan()
        {
            Console.WriteLine("Scanning");

            Console.ReadLine();
        }
    }

    class BesicPrinter : Iprenter
    {
        public void Print()
        {
            Console.WriteLine("printing");
        }
        public void Scan()
        {
          //  Console.WriteLine("");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Iprenter iprenter = new Printer();
            iprenter.Print();
            iprenter.Scan();

            Iprenter besicPrinter = new BesicPrinter();
            besicPrinter.Print();
            besicPrinter.Scan();

        }
    }
}
