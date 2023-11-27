using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    //15.	Разработайте класс для работы с украшениями в информационной системе «Ювелирный салон».
    //Реализуйте проверку правильности вводимых пользователем значений при добавлении нового товара.
    internal class Task15
    {
        private int id; // Идентификатор
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

        private string name; // Название
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
                    Console.WriteLine("Название не может быть пустым!"); // Вывод ошибки в консоль
                }
            }
        }

        private string description; // Описание
        public string Description
        {
            get
            {
                return description; // Возвращаем значение свойства
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value; // Устанавливаем новое значение свойства
                }
                else
                {
                    Console.WriteLine("Описание не может быть пустым!"); // Вывод ошибки в консоль
                }
            }
        }

        private string category; // Категория
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
                    Console.WriteLine("Название категории не может быть пустым!"); // Вывод ошибки в консоль
                }
            }
        }

        private string brand; // Бренд
        public string Brand
        {
            get
            {
                return brand; // Возвращаем значение свойства
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    brand = value; // Устанавливаем новое значение свойства
                }
                else
                {
                    Console.WriteLine("Название бренда не может быть пустым!"); // Вывод ошибки в консоль
                }
            }
        }

        private double weight; // Вес
        public double Weight
        {
            get
            {
                return weight; // Возвращаем значение свойства
            }
            set
            {
                if (value > 0)
                {
                    weight = value; // Устанавливаем новое значение свойства
                }
                else
                {
                    Console.WriteLine("Значение веса не может быть отрицательным!"); // Вывод ошибки в консоль
                }
            }
        }

        private double rating; // Оценка
        public double Rating
        {
            get
            {
                return rating; // Возвращаем значение свойства
            }
            set
            {
                if (value >= 0 && value <= 5)
                {
                    rating = value; // Устанавливаем новое значение свойства
                }
                else
                {
                    Console.WriteLine("Оценка должна находиться в диапазоне от 0 до 5!"); // Вывод ошибки в консоль
                }
            }
        }

        private string imageLink; // Ссылка на изображение
        public string ImageLink
        {
            get
            {
                return imageLink; // Возвращаем значение свойства
            }
            set
            {
                imageLink = value; // Устанавливаем новое значение свойства
            }
        }

        private double price; // Цена
        public double Price
        {
            get
            {
                return price; // Возвращаем значение свойства
            }
            set
            {
                if (value > 0)
                {
                    price = value; // Устанавливаем новое значение свойства
                }
                else
                {
                    Console.WriteLine("Цена должна быть больше 0!"); // Вывод ошибки в консоль
                }
            }
        }

        public Task15(int id, string name, string description, string category, string brand, double weight, double rating, string imageLink, double price)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.category = category;
            this.brand = brand;
            this.weight = weight;
            this.rating = rating;
            this.imageLink = imageLink;
            this.price = price;
        }
    }
}
