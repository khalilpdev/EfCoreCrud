using EfCoreCrud.Data;
using EfCoreCrud.Models;
using Microsoft.EntityFrameworkCore;

using var context = new MyDataContext();

var todo = new Todo
{
    Id = 1,
    Title = "Ir ao supermercado",
    Done = false,
};

context.Todos.Add(todo);
context.SaveChanges();

var todos = context
    .Todos
    //.AsNoTracking() // deixa se for só ler no banco. se for dar update depois, tirar
    //.Where(x => x.Done)
    .ToList();

PrintData();

var todoToUpdate = context
    .Todos
    .FirstOrDefault(x => x.Id == 1);

if (todoToUpdate != null)
{
    todoToUpdate.Title = "Ir a academia HOJE";
    context.Todos.Update(todoToUpdate);
    context.SaveChanges();
}

PrintData();

void PrintData()
{
    foreach (var item in todos)
        Console.WriteLine(item.ToString());
}

//parei em 01:23:24 do video


/*
 * Comandos
 * dotnet add package Microsoft.EntityFrameworkCore.InMemory
 * dotnet add package Microsoft.EntityFrameworkCore.Sqlite
 * dotnet add package Microsoft.EntityFrameworkCore.Design
 * dotnet add package Microsoft.EntityFrameworkCore.SqlServer
 * 
 * ** Migrations **
 * dotnet ef migrations add InitialCreation
 * dotnet ef database update
 * dotnet ef migrations script -o .script.sql
 */ 