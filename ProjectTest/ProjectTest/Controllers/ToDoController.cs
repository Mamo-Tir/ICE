using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectTest.Models;
using ProjectTest.Service;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectTest.Controllers
{
    public class ToDoController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult List()
        {
            TodoService todoService = new TodoService();

            TodoViewModel output = new TodoViewModel();


            output.isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);


            return View();
        }

        [HttpPost]
        public IActionResult Add(TodoViewModel inputMl)
        {

            return View();
        }
    }
}

