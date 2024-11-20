using System;
namespace TasksTracker
{
	public delegate void Command();
	public class Choise
	{
		public static Dictionary<string, Command> command = new Dictionary<string, Command>();

		TaskManager manager = new TaskManager();

		public Choise()
		{
			command.Add("1", () =>
			{
				Console.WriteLine("Введите название");
				string? name = Console.ReadLine();
				Console.WriteLine("Введите описание");
				string? description = Console.ReadLine();
				manager.Create(name, description);
			});

			command.Add("2", () =>
			{
				Console.WriteLine("Введите название задачи, которую хотите удалить");
                int.TryParse(Console.ReadLine(), out int x);
                manager.Remove(x);
			});

			command.Add("3", manager.Info);

			command.Add("4", () =>
			{
				Console.WriteLine("Введите номер задачи, для изменения");
				int id = int.Parse(Console.ReadLine());
				Console.WriteLine("Введите новое название");
				string? name = Console.ReadLine();
				Console.WriteLine("Введите новое описание");
				string? description = Console.ReadLine();
				manager.Edit(id, name, description);

			});

			command.Add("5", () => Environment.Exit(0));
		}

		//public void ExecuteOp(string a)
		//{
		//	if (command.ContainsKey(a))
		//	{
		//		command[a].Invoke();
		//	}
		//	else
		//		Console.WriteLine("Неверный выбор");
		//}

	}
}

