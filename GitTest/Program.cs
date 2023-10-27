using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2;
            double d, c, s;
            Random rand = new Random();

            x1 = rand.NextDouble() * 100;
            y1 = rand.NextDouble() * 100;
            x2 = rand.NextDouble() * 100;
            y2 = rand.NextDouble() * 100;

            Console.WriteLine($"Точки: (x1, y1) = ({x1}, {y1}), (x2, y2) = ({x2}, {y2})");

            d = Math.Sqrt(Math.Pow((x1 - y1), 2) + Math.Pow((x2 - y2), 2));

            Console.WriteLine($"Длина отрезка (d) = {d}");

            c = 2 * Math.PI * d;

            Console.WriteLine($"Длина окружности (c) = {c}");

            s = Math.PI * Math.Pow(d, 2);

            Console.WriteLine($"Площадь окружности (s) = {s}");

            Console.ReadKey();
        }
    }
}
