using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AppObject
    {
        private int id;
        public int Id
        {
            get
            {
                return id; // возвращаем значение свойства
            }
            set
            {
                if (condition)
                {
                    id = value; // устанавливаем новое значение свойства
                }
                else
                {
                    Console.WriteLine("Условие не выполнено!"); // Вывод ошибки в консоль
                }
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return name; // возвращаем значение свойства
            }
            set
            {
                if (String.IsNullOrWhiteSpace())
                {
                    name = value; // устанавливаем новое значение свойства
                }
                else
                {
                    Console.WriteLine("Условие не выполнено!"); // Вывод ошибки в консоль
                }
            }
        }

        public AppObject(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            AppObject example = new AppObject(0, "name");

            example.Name = "name";
        }
    }
}
