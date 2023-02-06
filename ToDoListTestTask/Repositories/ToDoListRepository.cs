using Microsoft.EntityFrameworkCore;
using ToDoListTestTask.Data;
using ToDoListTestTask.Models;

namespace ToDoListTestTask.Repositories
{
	public class ToDoListRepository
	{
		private readonly DataContext _context;
		public ToDoListRepository(DataContext context)
		{
			_context = context;
		}

		public async Task EditAsync(ToDo editBusiness)
		{
			var currentBusiness = await TryGetByIdAsync(editBusiness.Id);			
			currentBusiness.Content = editBusiness.Content;

			await _context.SaveChangesAsync();
		}

		public async Task AddAsync(ToDo newBusiness)
		{
			_context.ToDoLists.Add(newBusiness);

			await _context.SaveChangesAsync();
		}

		public async Task DeleteByIdAsync(Guid id)
		{
			var business = await TryGetByIdAsync(id);
			_context.ToDoLists.Remove(business);

			await _context.SaveChangesAsync();
		}

		public async Task<ToDo> TryGetByIdAsync(Guid id)
		{
			var foundBusiness = await _context.ToDoLists.FirstOrDefaultAsync(b => b.Id == id);
			return foundBusiness;
		}
	}
}
