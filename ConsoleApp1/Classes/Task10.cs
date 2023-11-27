using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Задание #10
namespace ConsoleApp1.Classes
{
    internal class BookObject
    {
        private int id;
        public int Id
        {
            get
            {
                return id; // Возвращаем значение свойства
            }
            set
            {
                id = value; // Устанавливаем новое значение свойства
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return name; // Возвращаем значение свойства
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value; // Устанавливаем новое значение свойства
                }
                else
                {
                    Console.WriteLine("Название книги не может быть пустым!"); // Вывод ошибки в консоль
                }
            }
        }

        private string author;
        public string Author
        {
            get
            {
                return author; // Возвращаем значение свойства
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    author = value; // Устанавливаем новое значение свойства
                }
                else
                {
                    Console.WriteLine("Автор должен быть указан!"); // Вывод ошибки в консоль
                }
            }
        }

        private string publisher;
        public string Publisher
        {
            get
            {
                return publisher; // Возвращаем значение свойства
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    publisher = value; // Устанавливаем новое значение свойства
                }
                else
                {
                    Console.WriteLine("Издатель должен быть указан!"); // Вывод ошибки в консоль
                }
            }
        }

        private int pages;
        public int Pages
        {
            get
            {
                return pages; // Возвращаем значение свойства
            }
            set
            {
                if (value > 0)
                {
                    pages = value; // Устанавливаем новое значение свойства
                }
                else
                {
                    Console.WriteLine("Количество страниц должно быть больше 0!"); // Вывод ошибки в консоль
                }
            }
        }

        private int year;
        public int Year
        {
            get
            {
                return year; // Возвращаем значение свойства
            }
            set
            {
                year = value; // Устанавливаем новое значение свойства
            }
        }

        public BookObject(int id, string name, string author, string publisher, int pages, int year)
        {
            Id = id;
            Name = name;
            Author = author;
            Publisher = publisher;
            Pages = pages;
            Year = year;
        }
    }
}
