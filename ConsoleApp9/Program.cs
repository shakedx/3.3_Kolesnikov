using System;

namespace Kolesnikov_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите n:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите x:");
                double x = double.Parse(Console.ReadLine());
                double S = 0;
                for (int i = 1, h = 1; i < n; i++, h += 2)
                {
                    long F = 1;
                    for (int j = 1; j <= h; j++) F *= j;
                    if (i % 2 == 0) S += 1 - Math.Pow(3*x, 2) / F;
                    else S += Math.Pow(3 * x, h) / F;


                }
                Console.WriteLine("S={0:F2}", S);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}