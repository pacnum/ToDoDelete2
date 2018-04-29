using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoDelete2.Models;

namespace ToDoDelete2.Services
{
    public class FakeToDoItemService : IToDoItemService
    {
      
        public Task<IEnumerable<ToDoItem>> GetIncompleteItemsAsync()
        {
            // Return an array of TodoItems
            IEnumerable<ToDoItem> items = new[] {
                new ToDoItem
                {            // First Item
                    Title = "Learn ASP.NET Core",
                    DueAt = DateTimeOffset.Now.AddDays(1)
                },
                new ToDoItem
                {           // Second Item
                    Title = "Build awesome apps",
                    DueAt = DateTimeOffset.Now.AddDays(2)
                }             };
            return Task.FromResult(items);

        }
    }
}
