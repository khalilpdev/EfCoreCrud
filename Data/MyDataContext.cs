using EfCoreCrud.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreCrud.Data
{
    public class MyDataContext : DbContext
    {
        //public MyDataContext(DbContextOptions<MyDataContext> options)
        //    :base(options)
        //{
        //    //options.UseInMemoryDatabase
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options.UseInMemoryDatabase(databaseName: "todos");
            //options.UseSqlite(connectionString: "DataSource=todos.db;Cache=Shared"); // Sqlite
            options.UseSqlServer("Server=LEANDROKHALIL;Database=Todos;User Id=sa;Password=sap@123");
            options.LogTo(Console.WriteLine);
        }

        public DbSet<Todo> Todos { get; set; }
    }
}
