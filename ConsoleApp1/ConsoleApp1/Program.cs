using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int povprecje = 0;
            int[] meseci = { 0,-2, 10, 15, 12, 24, 36, 2, -1, -10, -16,-12,-2 };
            for(int i = 1; i<meseci.Length; i++)
            {
                if (meseci[i] > 0)
                {
                    Console.WriteLine("mesec "+ i + " je topel");
                }
                else
                {
                    Console.WriteLine("mesec " + i + " je mrzel");
                }
                povprecje = povprecje + meseci[i];
            }
            povprecje = povprecje / 12;
            Console.WriteLine("povprecna temperatura = " + povprecje);

        }
    }
}