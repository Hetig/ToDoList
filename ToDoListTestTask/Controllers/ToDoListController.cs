using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToDoListTestTask.Data;
using ToDoListTestTask.Models;
using ToDoListTestTask.Repositories;

namespace ToDoListTestTask.Controllers
{
	public class ToDoListController : Controller
	{
		private readonly DataContext _context;
		private readonly ToDoListRepository _toDoList;
		public ToDoListController(DataContext context, ToDoListRepository toDoList)
		{
			_context = context;
			_toDoList = toDoList;
		}
		public IActionResult Index()
		{
			var toDoList = _context.ToDoLists.ToList();
			return View(toDoList);
		}
		
		public IActionResult Add() 
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> AddAsync(ToDo newBusiness)
		{
			await _toDoList.AddAsync(newBusiness);

			return RedirectToAction("Index");
		}

		public async Task<IActionResult> Edit(Guid id)
		{
			var business = await _toDoList.TryGetByIdAsync(id);
			return View(business);
		}

		[HttpPost]
		public async Task<IActionResult> EditAsync(ToDo editBusiness)
		{
			await _toDoList.EditAsync(editBusiness);

			return RedirectToAction("Index");
		}

		public async Task<IActionResult> DeleteAsync(Guid id)
		{
			await _toDoList.DeleteByIdAsync(id);

			return RedirectToAction("Index");
		}
	}
}