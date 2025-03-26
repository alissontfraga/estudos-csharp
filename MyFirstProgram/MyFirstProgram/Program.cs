using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.Write("Hello,alisso");
            Console.WriteLine(" alissodois");
            Console.Beep();
            //this is a comment
            /*
             * this
             * is
             * a
             * multiline
             * comment
             */
            /* Console.WriteLine("sou eu denovo");

            Console.ReadKey();
            */

            /* int x; //declaration
             x = 123; //initialization
             int y = 321; //declaration + initialization
             int z = x + y;
             Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            */

            /* int age = 21; //whole integer
            double height = 300.5; //decimal number
            bool alive = true; //true or false
            char symbol = '@'; //um caractere, aspas simples
            string name = "alisso"; //serie of caracteres



            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " + height + "cm");
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Your symbol is " + symbol);
            Console.WriteLine("Hello " + name);

            string userName = symbol + name;
            Console.WriteLine("Your username is " + userName);
            Console.ReadKey(); */

            //constants = immutable values which are known at compile time and do not change for the life of program
            /* const double pi = 3.14159;
             Console.WriteLine(pi);
             Console.ReadKey();
             */

            //type casting = converting a value to a different data type.
            //                useful when we accept user input ( which comes in string type).
            //                Different data types can do different things.     

            double a = 3.14;
            int b = Convert.ToInt32(a);
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine(b.GetType()); // to see data type.

            Console.ReadKey();
        }
    }
}
