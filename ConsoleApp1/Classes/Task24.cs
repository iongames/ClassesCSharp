using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1.Classes
{
    //24.	Разработайте класс для хранения данных автомобилей в информационной системе «Автостоянка».
    //Реализуйте проверку правильности вводимых пользователем значений при добавлении нового автомобиля.
    internal class Car
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

        private string brand; // Марка авто
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
                    Console.WriteLine("Марка не может быть пустой!"); // Вывод ошибки в консоль
                }
            }
        }

        private string model; // Модель авто
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
                    Console.WriteLine("Модель не может быть пустой!"); // Вывод ошибки в консоль
                }
            }
        }

        private int yearCreated; // Год выпуска авто
        public int YearCreated
        {
            get
            {
                return yearCreated; // Возвращаем значение свойства
            }
            set
            {
                if (yearCreated <= DateTime.Now.Year)
                {
                    yearCreated = value; // Устанавливаем новое значение свойства
                }
                else
                {
                    Console.WriteLine("Дата выпуска не может быть позже текущей!"); // Вывод ошибки в консоль
                }
            }
        }

        private DateTime paidTo; // Дата до которой оплачено место
        public DateTime PaidTo
        {
            get
            {
                return paidTo; // Возвращаем значение свойства
            }
            set
            {
                paidTo = value; // Устанавливаем новое значение свойства

            }
        }

        public Car(int id, string brand, string model, int yearCreated, DateTime paidTo)
        {
            Id = id;
            Brand = brand;
            Model = model;
            YearCreated = yearCreated;
            PaidTo = paidTo;
        }
    }
}
