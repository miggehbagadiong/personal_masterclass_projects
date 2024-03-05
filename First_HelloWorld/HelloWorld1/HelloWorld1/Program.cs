using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Name
    {
        static void Main(string[] args)
        {
            // display the first part
            string displayFirstQuestion = "What is your name? ";
            Console.WriteLine(displayFirstQuestion);
            // give the input for the thing
            string inputName = Console.ReadLine();
            //clears the thing
            Console.Clear();
            // display the name
            Console.WriteLine("Hello " +  inputName + " !");


        }
    }
    
}






// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
