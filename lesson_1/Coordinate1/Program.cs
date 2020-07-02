using System;

namespace Coordinate1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Головинская Юлия Викторовна
            // а)Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
            // по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат,
            // используя спецификатор формата .2f(с двумя знаками после запятой);
            

                        Console.WriteLine("Введите координаты: ");
            Console.Write("x1 = ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2 = ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"Расстояние между координатами: {r:F2}");
            Console.ReadKey();
        }
    }
}
