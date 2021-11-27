using EfCoreCrud.Data;
using EfCoreCrud.Models;
using Microsoft.EntityFrameworkCore;

using var context = new MyDataContext();
var todos = context
    .Todos
    .AsNoTracking() // deixa se for só ler no banco. se for dar update depois, tirar
    .Where(x => x.Done)
    .ToList();  
