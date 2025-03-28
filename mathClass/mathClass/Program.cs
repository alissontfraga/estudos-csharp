using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 3.99;
            double y = 5;

            //double a = Math.Pow(x, 3);  //potência        
            //double b = Math.Sqrt(x);    //raiz quadrada
            //double c = Math.Abs(x);     //valor absoluto, quão longe está do 0
            //double d = Math.Round(x);   //arredondar 
            //double e = Math.Ceiling(x); //arredondar pra cima
            //double f = Math.Floor(x);    //arredondar pra baixo
            double g = Math.Max(x, y);     // acha o maior número entre os dois
            double h = Math.Min(x, y);    //acha o menor número entre os dois

            Console.WriteLine(h);

            Console.ReadKey();
        }
    }
}
