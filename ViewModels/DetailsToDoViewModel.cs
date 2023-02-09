using TWTodolist.Models;

namespace TWTodolist.ViewModels;

public class DetailsToDoViewModel{
    public ToDo Todo {get; set;} =null!;
    public string PageTitle {get; set;}= string.Empty;
}