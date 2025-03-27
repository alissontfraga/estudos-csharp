using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getuserinput
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What`s your name ?"); 
            String name = Console.ReadLine(); //comando getuserinput
            Console.WriteLine("hello " + name); 

            Console.WriteLine("What`s your age?");
            String age = Console.ReadLine();
            Console.WriteLine("You are " + age + " years old");


            Console.ReadKey();
        }
    }
}
