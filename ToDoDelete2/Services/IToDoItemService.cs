using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoDelete2.Models;

namespace ToDoDelete2.Services
{
    interface IToDoItemService
    {
        Task<IEnumerable<ToDoItem>> GetIncompleteItemsAsync();
    }
}
