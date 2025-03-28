using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            //int num = random.Next(1, 7);  //de 1 a 6          //0 over 2billion  
            //double num = random.NextDouble();//gera num > 0 e < 1, gera um número decimal
            
            int num1 = random.Next(1, 7);
            int num2 = random.Next(1, 7);
            int num3 = random.Next(1, 7);

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);

            Console.ReadKey();
        }
    }
}
