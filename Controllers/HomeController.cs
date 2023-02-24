using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission08_3_12.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;



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
            var tasks = _taskContext.Tasks
                .Include(x => x.Category)
                .OrderBy(x => x.TaskName).ToList();
            return View(tasks);
        }

        [HttpGet]
        public IActionResult AddEditTask()
        {
            ViewBag.Categories = _taskContext.Categories.ToList();

            return View(new TaskModel());
        }

        

        [HttpPost]
        public IActionResult AddEditTask(TaskModel model)
        {
            if (ModelState.IsValid)
            {
                _taskContext.Add(model);

                _taskContext.SaveChanges();

                return View("Confirmation", model);
            }
            else
            {
                ViewBag.Categories = _taskContext.Categories.ToList();

                return View(model);
            }
        }

        

        [HttpGet]
        public IActionResult Edit(int id)

        {
            ViewBag.Categories = _taskContext.Categories.ToList();

            var task = _taskContext.Tasks.Single(x => x.TaskId == id);

            return View("AddEditTask", task);
        }

        [HttpPost]
        public IActionResult Edit(TaskModel editTask)
        {
            if (ModelState.IsValid)
            {
                _taskContext.Update(editTask);
                _taskContext.SaveChanges();

                return RedirectToAction("Quadrants");
            }
            else
            {
                ViewBag.Categories = _taskContext.Categories.ToList();
                return View("AddEditTask");
            }
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

            return RedirectToAction("Quadrants");
        }
        
    }
}