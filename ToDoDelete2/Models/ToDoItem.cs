using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoDelete2.Models
{
    public class ToDoItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTimeOffset DueAt { get; set; }

    }
}
