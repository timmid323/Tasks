﻿using System;
using System.Collections.Generic;
namespace TasksTracker
{
	public class TaskManager
	{
		List<Task> tasks = new List<Task>();
		public int idCount = 1;

		public void Create(string name, string decripton)
		{
			var task = new Task
			{
				Name = name,
				Description = decripton,
				Id = idCount++
			};
			tasks.Add(task);
            Console.WriteLine($"Задача {task.Name} добавлена");
            Console.WriteLine();

        }

        public void Remove(int id) 
		{	

                var taskToRemove = tasks.FirstOrDefault(t => t.Id == id);
                
                if (taskToRemove != null)
				{
					tasks.Remove(taskToRemove);
                    Console.WriteLine($"Задача с id {id} удалена.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Задача с id {id} не найдена.");
                }

		}
		public bool HasTasks()
		{
			return tasks.Count > 0;
		}
		public void Edit(int id, string name, string descriptoin)
		{
			
			var taskToEdit = tasks.FirstOrDefault(t => t.Id == id);
            if (taskToEdit != null)
            {

				taskToEdit.Id = id;
				taskToEdit.Name = name;
				taskToEdit.Description = descriptoin;
                Console.WriteLine("Задача обновлена успешно!");
            }
            else
                Console.WriteLine($"Задача с id {id} не найдена.");
        }

		public bool CheckId(int id)
		{
			return tasks.Any(t => t.Id == id);
		}
		public void Info()
		{
			foreach (var i in tasks)
				Console.WriteLine($"{i.Id}. {i.Name} ({i.Description})\tСоздана:{i.CreateDate}");
			Console.WriteLine();
		}

    }
}

