using TWTodolist.Models;

namespace TWTodolist.ViewModels;

public class ListToDoViewModel{
    public ICollection<ToDo> ToDos { get; set; } = new List<ToDo>();
 }