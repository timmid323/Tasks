using System;
namespace TasksTracker
{
    public delegate void Command();
    public class Choise
	{
        private Dictionary<string, Command> command = new Dictionary<string, Command>();
        private TaskManager manager;

		public Choise(TaskManager manager)
		{
			this.manager = manager;
            command.Add("1", () =>
			{
                bool chek = true;
                while (chek)
				{
					Console.WriteLine("Введите название");
					string? name = Console.ReadLine();
					if (!string.IsNullOrWhiteSpace(name))
					{
						Console.WriteLine("Введите описание");
						string? description = Console.ReadLine();
						manager.Create(name, description);
						chek = false;
					}
					else
					{
						Console.WriteLine("Название не может быть пустым");
					}
				}
			});

			command.Add("2", () =>
			{
				if (manager.HasTasks())
				{
					bool chek = true;
				while (chek)
				{
					
					Console.WriteLine("Введите id задачи, которую хотите удалить");
					if (int.TryParse(Console.ReadLine(), out int x))
					{
						manager.Remove(x);
						chek = false;
					}
					else
					{
						Console.WriteLine("Неверный ввод. Попробуйте снова");
					}
                  
				}
				}
				else
					Console.WriteLine("Список пуст");

			});

			command.Add("3", manager.Info);

			command.Add("4", () =>
			{
            if (manager.HasTasks())
            {
					bool validId = true;
					int id = 0;

					while(validId)
					{
                        Console.WriteLine("Введите номер задачи, для изменения");
                        if (int.TryParse(Console.ReadLine(), out id))
                        {
							if(manager.CheckId(id))
							{
								validId = false;
							}
							else
								Console.WriteLine($"Задача с {id} не найдена");
                        }
                        else
                            Console.WriteLine("Неверный ввод. Попробуйте снова");
                    }
                   
					bool chek = true;
					while (chek)
					{
                        Console.WriteLine("Введите новое название");
                        string? name = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(name))
                        {
							chek = false;
                            Console.WriteLine("Введите новое описание");
                            string? description = Console.ReadLine();
                            manager.Edit(id, name, description);
                        }
                        else
                        {
                            Console.WriteLine("Название не может быть пустым");
                        }
                    }
                }
                
            else
					Console.WriteLine("Список пуст");
            });

			command.Add("5", () => Environment.Exit(0));
		}
        public Dictionary<string, Command> GetCommands() => command;


    }
}

