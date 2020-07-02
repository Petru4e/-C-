using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Головинская Юлия Викторовна
            // Написать программу обмена значениями двух переменных:
            // а) с использованием третьей переменной;

            Console.WriteLine("Введите переменные: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x;
            x = y;
            y = z;
            Console.WriteLine($"{x} \n{y}"); 
        }
    }
}
