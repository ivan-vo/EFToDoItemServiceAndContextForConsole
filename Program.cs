using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFTodo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // ToDoItemService.AddItemToBD(new ToDoItem(){title = "Not done task with description was created",description = "Test", doDate = DateTime.Parse("2021-04-10")});
            // ToDoItemService.DeleteItemById(1);
            ToDoItemService.PrintItemsInConsole(ToDoItemService.GetAllItems());
        }
    }
}
