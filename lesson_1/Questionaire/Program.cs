using System;

namespace Questionaire
{
    class Program
    {
        static void Main(string[] args)
        {
            // Головинская Юлия Викторовна
            // Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
            // а) используя склеивание;
            // б) используя форматированный вывод;
            // в) используя вывод со знаком $.

            Console.WriteLine("Имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Фамилия: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Возраст: ");
            string age = Console.ReadLine();
            Console.WriteLine("Рост: ");
            string height = Console.ReadLine();
            Console.WriteLine("Вес: ");
            string weight = Console.ReadLine();

            Console.WriteLine("Имя: " + name + ", " + "Фамилия: " + surname + ", " + "Возраст: " + age + ", " + "Рост: " + height + ", " + "Вес: " + weight + ".");
            Console.WriteLine("Имя: {0}, Фамилия: {1}, Возраст: {2}, Рост: {3}, Вес: {4}.", name, surname, age, height, weight);
            Console.WriteLine($"Имя: {name}, Фамилия: {surname}, Возраст: {age}, Рост: {height}, Вес: {weight}.");

            Console.ReadKey();

        }
    }
}
