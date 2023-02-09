using Microsoft.AspNetCore.Mvc;
using TWTodolist.Contexts;
using TWTodolist.Models;
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

    public IActionResult Delete(int id){
        var todo = _context.ToDos.Find(id);
        if(todo is null) { return NotFound(); }
        _context.Remove(todo);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Create(){
        ViewData["Title"] = "Nova tarefa";
        return View();
    }

    [HttpPost]
    public IActionResult Create(CreateToDoViewModel dados){
        var todo = new ToDo(dados.title, dados.date);
        _context.Add(todo);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int id){
        var todo = _context.ToDos.Find(id);
        if(todo is null) { return NotFound(); }
        var viewmodel = new EditToDoViewModel {title= todo.title, date= todo.date};
        ViewData["Title"] = "Editar Tarefa";
        return View(viewmodel);
    }

    [HttpPost]
    public IActionResult Edit(int id, EditToDoViewModel dados){
        var todo = _context.ToDos.Find(id);
        if(todo is null) { return NotFound(); }
        todo.title = dados.title;
        todo.date = dados.date;
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
 }