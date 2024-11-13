using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ConsoleApp3
{
    public partial class Base
    {
        private string _text;

        // Конструктор
        public Base(string text)
        {
            _text = text ?? string.Empty; // Если text равен null, присваиваем пустую строку
        }

        // Конструктор копирования
        public Base(Base other)
        {
            if (other == null)
            {
                _text = string.Empty; // Если переданный объект other равен null, присваиваем пустую строку
            }
            else
            {
                _text = other._text;
            }
        }

        // Метод, который приписывает три знака восклицания в начало
        public void AddExclamations()
        {
            if (_text == null) // Проверка на null
            {
                _text = string.Empty; // Если _text равен null, присваиваем пустую строку
            }

            _text = "!!!" + _text;
        }

        // Перегруженный метод ToString()
        public override string ToString()
        {
            return _text;
        }
    }
}
