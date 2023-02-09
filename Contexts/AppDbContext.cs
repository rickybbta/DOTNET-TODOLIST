using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using TWTodolist.EntityConfigs;
using TWTodolist.Models;

namespace TWTodolist.Contexts;

public class AppDBContext: DbContext{
    public DbSet<ToDo> ToDos => Set<ToDo>();
    protected override void OnConfiguring(DbContextOptionsBuilder builder){
        builder.UseSqlServer("Server=Localhost;Database=TWToDoList;Integrated Security=SSPI;TrustServerCertificate=True");
    }
    protected override void OnModelCreating(ModelBuilder builder){
        builder.ApplyConfiguration(new ToDoEntityConfig());
    }
}