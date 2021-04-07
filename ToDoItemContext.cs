using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFTodo
{
    public class ToDoItemContext : DbContext
    {
        public DbSet<ToDoItem> items { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Host=127.0.0.1;Username=to_do_item_app;Password=ivanvoronov;Database=todoitemdb");
        }
    }

    public class ToDoItem
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public bool done { get; set; }
        public DateTime doDate { get; set; }        
    }
}
