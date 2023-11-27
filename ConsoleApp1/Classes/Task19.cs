using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// Задание #19
namespace ConsoleApp1.Classes
{
    internal class Client
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

        private string lastName;
        public string LastName
        {
            get
            {
                return lastName; // Возвращаем значение свойства
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    lastName = value; // Устанавливаем новое значение свойства
                }
                else
                {
                    Console.WriteLine("Фамилия должна быть указана!"); // Вывод ошибки в консоль
                }
            }
        }

        private string firstName;
        public string FirstName
        {
            get
            {
                return firstName; // Возвращаем значение свойства
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    firstName = value; // Устанавливаем новое значение свойства
                }
                else
                {
                    Console.WriteLine("Имя должно быть указано!"); // Вывод ошибки в консоль
                }
            }
        }

        private string patronymic;
        public string Patronymic
        {
            get
            {
                return patronymic; // Возвращаем значение свойства
            }
            set
            {
                patronymic = value;
            }
        }

        private int passportSeries;
        public int PassportSeries
        {
            get
            {
                return passportSeries; // Возвращаем значение свойства
            }
            set
            {
                if (value >= 1000 && value < 10000)
                {
                    passportSeries = value; // Устанавливаем новое значение свойства
                }
                else
                {
                    Console.WriteLine("Серия паспорта должна содержать 4 цифры!"); // Вывод ошибки в консоль
                }
            }
        }

        private int passportNumber;
        public int PassportNumber
        {
            get
            {
                return passportNumber; // Возвращаем значение свойства
            }
            set
            {
                if (value >= 100000 && value < 1000000)
                {
                    passportNumber = value; // Устанавливаем новое значение свойства
                }
                else
                {
                    Console.WriteLine("Номер паспорта должен содержать 6 цифр!"); // Вывод ошибки в консоль
                }
            }
        }

        private string phone;
        public string Phone
        {
            get
            {
                return phone; // Возвращаем значение свойства
            }
            set
            {
                if (Regex.IsMatch(value, @"[0-9]{11}")) // Регулярное выражение. Проверка правильности ввода номера телефона. Пример, 79001234567
                {
                    phone = value; // Устанавливаем новое значение свойства
                }
                else
                {
                    Console.WriteLine("Номер телефона должен содержать 11 цифр!"); // Вывод ошибки в консоль
                }
            }
        }

        private string email;
        public string Email
        {
            get
            {
                return email; // Возвращаем значение свойства
            }
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z0-9]*@[a-zA-Z0-9]*[.][a-zA-Z]*$")) // Регулярное выражение. Проверка правильности ввода электронной почты. Пример, email@example.com
                {
                    email = value; // Устанавливаем новое значение свойства
                }
                else
                {
                    Console.WriteLine("Неверный формат почты!"); // Вывод ошибки в консоль
                }
            }
        }

        public Client(int id, string lastName, string firstName, string patronymic, int passportSeries, int passportNumber, string phone, string email)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            Patronymic = patronymic;
            PassportSeries = passportSeries;
            PassportNumber = passportNumber;
            Phone = phone;
            Email = email;
        }
    }
}
