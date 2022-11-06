using System;

namespace AppleAndOrange
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int s = 7, a = 4;
            int t = 10, b = 12;

            int[] apples = { 2, 3, -4 };
            int[] oranges = { 3, -2, -4 };

            int resultMaca = 0;
            int resultLaranja = 0;

            for (int i = 0; i < apples.Length; i++)
            {
                var appleStart = a + apples[i];
                var appleFinish = a + apples[i];
                var HomeStart = s; //7
                var HomeFinish = t;//14

                if (appleStart >= HomeStart && appleFinish <= HomeFinish)
                {
                    resultMaca++;
                }
            }

            for (int i = 0; i < oranges.Length; i++)
            {
                var orangeStart = b + oranges[i];
                var orangeFinish = b + oranges[i];
                var HomeStart = s; //7
                var HomeFinish = t; //14

                if (orangeStart <= HomeFinish && orangeFinish >= HomeStart)
                {
                    resultLaranja++;
                }
            }

            Console.WriteLine(resultMaca + " => maçã");
            Console.WriteLine(resultLaranja + " => Laranja");
        }
    }
}
