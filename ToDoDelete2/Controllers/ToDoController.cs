using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ToDoDelete2.Controllers
{
    public class ToDoController : Controller
    {
        public IActionResult Index()
        {
            // todo Get to-do items from database
            // todo Put items into a model
            // todo Pass the view to a model and render

            return View();
        }
    }
}