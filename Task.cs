using System;
namespace TasksTracker
{
	public class Task
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime CreateDate { get; } = DateTime.Now;
	}
}

