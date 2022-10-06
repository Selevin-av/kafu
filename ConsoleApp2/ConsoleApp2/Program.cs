using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Введите значение M1");
         string M1 = Console.ReadLine();
         double M = Convert.ToDouble(M1);

            double Z1 = 3;
            double L = 4;
            
            double Z2 = L + Math.Pow(M,3);
           
            double S = (M * Z1 + (Math.Pow(L, 2) * Z2));
            // переменная С использована для хитрости
            double P = Math.Pow(S, 2); 
            Console.WriteLine(P);

        }
          
    }
}
