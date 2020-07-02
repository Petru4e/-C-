using System;

namespace Variables1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Головинская Юлия Викторовна
            // Написать программу обмена значениями двух переменных:
            // б) *без использования третьей переменной.

            Console.WriteLine("Введите переменные: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            x = y + x;
            y = x - y;
            x = x - y;
            Console.WriteLine($"{x} \n{y}");
        }
    }
}
