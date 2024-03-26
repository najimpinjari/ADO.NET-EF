using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Princi_S
{
    class UserHandle //in this method the class have only one work to do its adduser name 
    {
        public void AddUser(string username) // and this is the method to add username to class 
        {
            Console.WriteLine($"{username} added to the database");
        }
    }
    
    //both the class have deffrent work but a single class have single work 

    class Logger // in this method the class have loggger only one work to do its print the message 
    {
        public void Log(string message) //method for print the message for logging 
        {
            Console.WriteLine($"Logging {message}");

            Console.ReadLine();
        }
    }

    class Program
    {
       
        static void Main(string[] args) //this is the main method in main method we have called they method in there classes 
        {
            UserHandle userHandle = new UserHandle(); // create object for userhandle class 
            Logger logger = new Logger();               // create object for logger class 

            userHandle.AddUser("Rupesh Raut");              //collged the object 
            logger.Log("user rupesh raut added successfully."); //collged the object 

            //using object and their method we add values for it and called it explicitly 



            //userHandle.AddUser("najimdp");
            //logger.Log("hello world");

            Console.ReadLine();
        }
    }
}
