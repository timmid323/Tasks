using System;
using System.Collections.Generic;
using TasksTracker;

class Program
{
    static void Main()
    {
        TaskManager taskManager = new TaskManager();
        Choise choise = new Choise(taskManager);

        while (true)
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Удалить задачу");
            Console.WriteLine("3. Показать список задач");
            Console.WriteLine("4. Изменить задачу");
            Console.WriteLine("5. Выход");

            string? input = Console.ReadLine();
            if (choise.GetCommands().ContainsKey(input))
            {
                choise.GetCommands()[input].Invoke();
            }
            else
            {
                Console.WriteLine("Неверный выбор");
            }
        }
    }
}

