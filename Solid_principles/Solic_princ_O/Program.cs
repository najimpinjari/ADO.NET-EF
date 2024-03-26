using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Solic_princ_O
{   

    //abstrac class for Shape
    abstract class Shape
    {
        public abstract double Area(); // the feild in shape class its abstac class 
    }

    //class for rectangle 
     class Rectangle : Shape
    {
        public double Widhth {  get; set; }
        public double Height {  get; set; }

        public override double Area()
        {
            return Widhth * Height;
        }


    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius ,2);
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle{ Height = 5 , Widhth = 4};
            Circle circle = new Circle { Radius = 3 };

            Console.WriteLine($" area of rectangle : {rectangle.Area()}");
            Console.WriteLine($" area of Circle : {circle.Area()}");

            Console.ReadLine();

            //Explanation: In this example, the Shape class is open for extension, as we can create new
            //shapes by inheriting from it (e.g., Rectangle, Circle). However, the Shape class itself is
            //closed for modification, ensuring that existing code remains unchanged.

        }
    }
}
