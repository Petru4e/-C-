using System;

namespace Profile1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Головинская Юлия Викторовна
            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            //б) *Сделать задание, только вывод организовать в центре экрана.
            //в) **Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).

            string name = "Юлия";
            string surname = "Головинская";
            string city = "Ставрополь";
            Console.WriteLine($"{name} {surname} {city}."); //  задание а)
            Console.WriteLine($"\t \t \t \t \t  {name} {surname} {city}."); // задание б)
            Print(name, surname, city); // задание в)

            Console.WriteLine($"           {name} {surname} {city}.");
        }
        static void Print(string a, string b, string c)
        {
            Console.WriteLine($"{a} {b} {c}.");
        }
    }
}
