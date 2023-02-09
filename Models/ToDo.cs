namespace TWTodolist.Models;

public class ToDo {
    public int id { get; set; }
    public string title {get; set;} = string.Empty;
    public DateTime date {get; set;}
    public bool iscompleted {get; set;}

    public ToDo (string title, DateTime date, bool iscompleted = false){
        this.title = title;
        this.date = date;
        this.iscompleted = iscompleted;
    }

    public ToDo (int id, string title, DateTime date, bool iscompleted = false){
        this.id = id;
        this.title = title;
        this.date = date;
        this.iscompleted = iscompleted;
    }
} 