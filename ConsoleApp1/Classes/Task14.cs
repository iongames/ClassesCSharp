using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Задание #14
namespace ConsoleApp1.Classes
{
    internal class Product
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

        private string manufacturer;
        public string Manufacturer
        {
            get
            {
                return manufacturer; // Возвращаем значение свойства
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    manufacturer = value; // Устанавливаем новое значение свойства
                }
                else
                {
                    Console.WriteLine("Производитель должен быть указан!"); // Вывод ошибки в консоль
                }
            }
        }

        private string model;
        public string Model
        {
            get
            {
                return model; // Возвращаем значение свойства
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    model = value; // Устанавливаем новое значение свойства
                }
                else
                {
                    Console.WriteLine("Модель товара должна быть указана!"); // Вывод ошибки в консоль
                }
            }
        }

        private string category;
        public string Category
        {
            get
            {
                return category; // Возвращаем значение свойства
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    category = value; // Устанавливаем новое значение свойства
                }
                else
                {
                    Console.WriteLine("Категория товара должна быть указана!"); // Вывод ошибки в консоль
                }
            }
        }

        private double price;
        public double Price
        {
            get
            {
                return price; // Возвращаем значение свойства
            }
            set
            {
                if (value > 0.0)
                {
                    price = value; // Устанавливаем новое значение свойства
                }
                else
                {
                    Console.WriteLine("Цена товара должна быть больше 0!"); // Вывод ошибки в консоль
                }
            }
        }

        public Product(int id, string name, string manufacturer, string model, string category, double price)
        {
            Id = id;
            Name = name;
            Manufacturer = manufacturer;
            Model = model;
            Category = category;
            Price = price;
        }
    }
}
