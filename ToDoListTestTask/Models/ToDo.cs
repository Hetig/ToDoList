using System.ComponentModel.DataAnnotations;

namespace ToDoListTestTask.Models
{
	public class ToDo
	{
		public Guid Id { get; set; }
		public string Content { get; set; } = string.Empty;
		public DateTime DateTimeCreating { get; set; } = DateTime.Now;
	}
}
