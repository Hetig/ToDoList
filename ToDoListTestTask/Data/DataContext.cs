using Microsoft.EntityFrameworkCore;
using ToDoListTestTask.Models;

namespace ToDoListTestTask.Data
{
	public class DataContext : DbContext
	{
		public DbSet<ToDo> ToDoLists => Set<ToDo>();
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}
	}
}
