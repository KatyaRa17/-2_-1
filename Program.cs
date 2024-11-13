using System;
using System.Linq;

namespace ConsoleApp3
{ 
    class Program
    {
        static void Main()
        {
            // Тестирование базового класса
            Console.WriteLine("Введите любой текст:");
            Base baseObj1 = new Base(Console.ReadLine());
            baseObj1.AddExclamations();
            Console.WriteLine(baseObj1.ToString());

            // Тестирование конструктора копирования базового класса
            Base baseObj2 = new Base(baseObj1);
            Console.WriteLine(baseObj2.ToString());

            // Тестирование дочернего класса
            Derived derivedObj1 = new Derived("Дочерний класс", 17, DateTime.Now);
            Console.WriteLine(derivedObj1.DisplayInfo());

            // Тестирование конструктора копирования дочернего класса
            Derived derivedObj2 = new Derived(derivedObj1);
            Console.WriteLine(derivedObj2.DisplayInfo());

            // Изменение числа в дочернем классе
            derivedObj2.UpdateNumber(100);
            Console.WriteLine(derivedObj2.DisplayInfo());
        }
    }
}

    




