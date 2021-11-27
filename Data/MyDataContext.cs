﻿using EfCoreCrud.Models;
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
            options.UseInMemoryDatabase(databaseName: "todos");
        }

        public DbSet<Todo> Todos { get; set; }
    }
}
