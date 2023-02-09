using Microsoft.AspNetCore.Mvc;
using TWTodolist.Contexts;
using TWTodolist.ViewModels;

namespace TWTodolist.Controllers;

public class ToDoController: Controller{
    private readonly AppDBContext _context;
    public ToDoController(AppDBContext context){
        _context=context;
    }
    public IActionResult Index(){
        var todos = _context.ToDos.ToList();
        var viewmodel = new ListToDoViewModel { ToDos = todos};
        ViewData["Title"] = "Lista de tarefas";
        return View(viewmodel);
    }
 }