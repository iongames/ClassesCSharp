using ConsoleApp1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание #10
            BookObject bookObject = new BookObject(0, "Книга", "Иванов И. И.", "Издатель", 100, 2023);

            // Задание #14
            Product product = new Product(0, "Товар", "Производитель", "Модель", "Категория", 9990.00);

            // Задание #19
            Client client = new Client(0, "Иванов", "Иван", "Иванович", 1000, 100000, "79001234567", "email@example.com");

            // Задание #27
            CarClient carClient = new CarClient(0, "Иванов", "Иван", "Иванович", 1000, 100000, "79001234567", "email@example.com", new List<string> {"A", "B", "C"});

            Console.ReadKey();
        }
    }
}
