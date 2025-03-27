using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmeticOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int friends = 10;
            //friends = friends + 2;
            //friends += 2;
            //friends++; //apenas +1

            //friends = friends - 1;
            //friends -= 1;
            //friends--;

            //friends = friends * 2;
            //friends *= 2;

            //friends = friends / 2; //divisão inteira, pois a variável é uma int
            //friends /= 2;

            int remainder = friends % 3;  //módulo = resto da divisão

            Console.WriteLine(remainder);
            Console.WriteLine(friends);


            Console.ReadKey();
        }
    }
}
