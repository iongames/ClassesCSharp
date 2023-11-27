using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    //9. Разработайте класс для работы с турами в информационной системе «Туристического агентства».
    //Реализуйте проверку правильности вводимых пользователем значений при добавлении нового тура.
    internal class Tour
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
                } else
                {
                    Console.WriteLine("Название тура не может быть пустым!"); // Вывод ошибки в консоль
                }
            }
        }

        private string city; // Город
        public string City
        {
            get
            {
                return city; // Возвращаем значение свойства
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    city = value; // Устанавливаем новое значение свойства
                }
                else
                {
                    Console.WriteLine("Город не может быть пустым!"); // Вывод ошибки в консоль
                }
            }
        }

        private List<string> additionals; // Дополнения
        public List<string> Additionals
        {
            get
            {
                return additionals; // Возвращаем значение свойства
            }
            set
            {
                additionals = value; // Устанавливаем новое значение свойства
            }
        }

        private int days; // Кол-во дней
        public int Days
        {
            get
            {
                return days; // Возвращаем значение свойства
            }
            set
            {
                if (value > 0)
                {
                    days = value; // Устанавливаем новое значение свойства
                }
                else
                {
                    Console.WriteLine("Количество дней должно быть больше 0!"); // Вывод ошибки в консоль
                }
               
            }
        }

        private DateTime dateStart; // Дата начала тура
        public DateTime DateStart
        {
            get
            {
                return dateStart; // Возвращаем значение свойства
            }
            set
            {
                dateStart = value; // Устанавливаем новое значение свойства
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

        public Tour(int id, string name, string city, List<string> additionals, int days, DateTime dateStart, double price)
        {
            Id = id;
            Name = name;
            City = city;
            Additionals = additionals;
            Days = days;
            DateStart = dateStart;
            Price = price;
        }
    }
}
