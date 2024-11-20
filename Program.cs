using System;
using System.Collections.Generic;
using TasksTracker;

class Program
{
    static void Main()
    {
        TaskManager tasks = new TaskManager();
        Choise choise = new Choise();

        while (true)
        {
            Console.WriteLine("Выберете операцию:");
            Console.WriteLine("1.Добавить задачу");
            Console.WriteLine("2.Удалить задачу");
            Console.WriteLine("3.Показать список задач");
            Console.WriteLine("4.Изменить задачу");
            Console.WriteLine("5.Выход");
            Console.WriteLine();

            string? input = Console.ReadLine();
            if (Choise.command.ContainsKey(input))
            {
                Choise.command[input].Invoke();
            }
            else
                Console.WriteLine("Неверный выбор");

            
        }
    }
    
}