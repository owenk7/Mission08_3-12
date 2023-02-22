using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission08_3_12.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;



namespace Mission08_3_12.Controllers
{
    //controller
    public class HomeController : Controller
    {
        private TaskContext _taskContext { get; set; }

        public HomeController(TaskContext task)
        {
            _taskContext = task;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Quadrants()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddEditTask()
        {
            ViewBag.Categories = _taskContext.Categories.ToList();

            return View();
        }

        

        [HttpPost]
        public IActionResult AddEditTask(Models.Task model)
        {
            if (ModelState.IsValid)
            {
                _taskContext.Add(model);

                _taskContext.SaveChanges();

                return View("TaskView", model);
            }
            else
            {
                ViewBag.Tasks = _taskContext.Tasks.ToList();

                return View(model);
            }
        }

        /*

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Tasks = _taskContext.Tasks.ToList();

            var task = _taskContext.Tasks.Single(x => x.TaskId == id);

            return View("TaskView", task);
        }

        [HttpPost]
        public IActionResult Edit(TaskModel editTask)
        {
            _taskContext.Update(editTask);
            _taskContext.SaveChanges();

            return RedirectToAction("TaskView");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var task = _taskContext.Tasks.Single(x => x.TaskId == id);
            return View(task);
        }

        [HttpPost]
        public IActionResult Delete(TaskModel task)
        {
            _taskContext.Tasks.Remove(task);
            _taskContext.SaveChanges();

            return RedirectToAction("TaskList");
        }
        */
    }
}