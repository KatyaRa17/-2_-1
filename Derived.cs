using System;
using System.Linq;

namespace ConsoleApp3
{
    public class Derived: Base
    {
        private int _number;
        private DateTime _date;
        public Derived(string text, int number, DateTime date) : base(text)
        {
            _number = number;
            _date = date;
        }

        // Конструктор копирования
        public Derived(Derived other) : base(other)
        {
            _number = other._number;
            _date = other._date;
        }

        // Метод для отображения информации
        public string DisplayInfo()
        {
            return $"{ToString()}, Number: {_number}, Date: {_date.ToShortDateString()}";
        }

        // Метод для изменения числа
        public void UpdateNumber(int newNumber)
        {
            _number = newNumber;
        }
    }
}

