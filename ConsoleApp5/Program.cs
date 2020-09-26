using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USRS_1_Gurski
{
    class Program
    {
        static void Main(string[] args)
        {
            const double G = 6.67408E-11;
            const double R = 6370000;
            const double M = 5.972E24;
            double h, V;

            Console.WriteLine("введите высоту над поверхностью Земли в м");

            h = double.Parse(Console.ReadLine());
            V = Math.Sqrt(G * M / (R + h));
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("скорость спутника на высоте " + h + " м над поверхностью Земли равна " + V + " м/с ");
        }
    }
}
