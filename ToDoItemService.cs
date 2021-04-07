using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFTodo
{
    public class ToDoItemService
    {
        public static void AddItemToBD(ToDoItem item)
        {
            using (var db = new ToDoItemContext())
            {
                db.items.Add(item);
                db.SaveChanges();
            }
        }
        public static ToDoItem GetItemWithID(int id)
        {
            using (ToDoItemContext db = new ToDoItemContext())
            {
                ToDoItem item = db.items.FirstOrDefault(item => item.Id == id);
                return item;
            }
        }
        public static void DeleteItemById(int id)
        {
            using (var db = new ToDoItemContext())
            {
                db.items
                    .Remove(GetItemWithID(id));
                db.SaveChanges();
            }
        }
        public static List<ToDoItem> GetAllItems()
        {
            using (var db = new ToDoItemContext())
            {
                return db.items.ToList();
            }
        }
        public static void PrintItemsInConsole(List<ToDoItem> items)
        {
            foreach (var item in items)
            {
                char taskFlag = item.done ? 'x' : ' ';
                Console.WriteLine($"{item.Id} - [{taskFlag}] {item.title} {item.doDate} {item.description}");
            }
        }
    }
}