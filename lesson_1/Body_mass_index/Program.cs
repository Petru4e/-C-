using System;

namespace Body_mass_index
{
    class Program
    {
        static void Main(string[] args)
        {
            // Головинская Юлия Викторовна
            // Ввести вес и рост человека. Рассчитать и вывести индекс массы тела
            // (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.

            Console.Write("Введите вес в килограммах: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите рост в метрах: ");
            double height = Convert.ToDouble(Console.ReadLine());
            double bmi = weight / (height * height);

            Console.WriteLine($"Индекс массы тела равен: {bmi}");
        }
    }
}
