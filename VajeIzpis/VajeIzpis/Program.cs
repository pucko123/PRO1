using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace VajeIzpis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1234;
            int b = 5678;
            Console.WriteLine("a="+a+" b="+b);
            //formatiranje izpisa
            Console.WriteLine("a={0} b={1}",a,b);
            Console.WriteLine("a={0,6} b={1,6}", a, b);
            Console.WriteLine("a={0,6:d} b={1,6:d}", a, b);
            Console.WriteLine("a={0,6:x} b={1,6:x}", a, b);
            double r = 12345.6789;
            Console.WriteLine("r={0,10:f2}",r);
            Console.WriteLine("r={0,10:e2}", r);
            Console.WriteLine("r={0,10:g2}", r);
            Console.WriteLine("r={0,10:n2}", r);
            Console.WriteLine("r={0,10:f6}", r);
            double p = 0.25;
            Console.WriteLine("p={0,10:p2}", p);

            double a1 = 20.000;
            double b1 = -13.6667;
            double c1 = 17.00;
            double d1 = 12.88;
            double e1 = 2222.879;
            Console.WriteLine("a1={0,20:f2}", a1);
            Console.WriteLine("b1={0,20:f2}", b1);
            Console.WriteLine("c1={0,20:f2}", c1);
            Console.WriteLine("d1={0,20:f2}", d1);
            Console.WriteLine("e1={0,20:f2}", e1); 


            Console.ReadLine();
        }
    }
}
