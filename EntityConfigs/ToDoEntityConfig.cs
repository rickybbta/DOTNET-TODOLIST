using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using TWTodolist.Models;

namespace TWTodolist.EntityConfigs;

public class ToDoEntityConfig: IEntityTypeConfiguration<ToDo>{
    public void Configure(EntityTypeBuilder<ToDo> builder){
        builder.ToTable("todo");
        builder.HasKey(x=> x.id);
        builder.Property(x=>x.id).HasColumnName("id");
        builder.Property(x=>x.title).HasColumnName("title").HasColumnType("nvarchar(100)").IsRequired();
        builder.Property(x=>x.date).HasColumnName("date").HasColumnType("date").IsRequired();
        builder.Property(x=>x.iscompleted).HasColumnName("is_completed").HasColumnType("bit").IsRequired();
    }
}