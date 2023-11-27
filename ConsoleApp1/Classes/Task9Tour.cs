using System;



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
        public string name
        {
            get
            {
                return name; // Возвращаем значение свойства
            }
            set
            {
                name = value; // Устанавливаем новое значение свойства
            }
        }

        private string city; // Город
        public string city
        {
            get
            {
                return city; // Возвращаем значение свойства
            }
            set
            {
                city = value; // Устанавливаем новое значение свойства
            }
        }

        private List<string> additionals; // Дополнения
        public List<string> additionals
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
        public int days
        {
            get
            {
                return days; // Возвращаем значение свойства
            }
            set
            {
                days = value; // Устанавливаем новое значение свойства
            }
        }

        private DateTime dateStart; // Дата начала тура
        public DateTime dateStart
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

        private DateTime dateEnd; // Дата завершения тура
        public DateTime dateEnd
        {
            get
            {
                return dateEnd; // Возвращаем значение свойства
            }
            set
            {
                dateEnd = value; // Устанавливаем новое значение свойства
            }
        }

        private double price; // Дополнения
        public double price
        {
            get
            {
                return price; // Возвращаем значение свойства
            }
            set
            {
                price = value; // Устанавливаем новое значение свойства
            }
        }


        public Tour(int id, string name, string city,List<string> additionals, int days, DateTime dateStart, DateTime dateEnd, double price)
        {
            this.id = id;
            this.name = name;
            this.author = author;
            this.pages = pages;
            this.year = year;
        }
    }
}
