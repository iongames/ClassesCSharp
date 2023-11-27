using System;

namespace ConsoleApp1.Classes

//9. Разработайте класс для работы с турами в информационной системе «Туристического агентства».
//Реализуйте проверку правильности вводимых пользователем значений при добавлении нового тура.
internal class Task9Tour
{
    private int id;
    private String tourName;
    private String tourCity;
    private String tourCity;
    private int days;
    private double price;
    private List<String> price;

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

    public Task9Tour(int id, string name)
    {
        this.id = id;
        this.name = name;
    }
}