using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Mission08_3_12.Models
{
    public class TaskContext:DbContext
    {
        //Constructor
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {

        }

        //setting connection 
        public DbSet<TaskModel> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder ab)
        { 
            //Seeding database
            ab.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Home" },
                new Category { CategoryId = 2, CategoryName = "School" },
                new Category { CategoryId = 3, CategoryName = "Work" },
                new Category { CategoryId = 4, CategoryName = "Church" }
                );
            //Seeding database
            ab.Entity<TaskModel>().HasData(
                new TaskModel
                {
                    TaskId = 1,
                    TaskName = "Homework for 404",
                    DueDate = DateTime.ParseExact("02/22/2023 11:59 PM", "MM/dd/yyyy h:mm tt", null),
                    Quadrant = 1,
                    CategoryId = 2,
                    Completed = false
                },
                new TaskModel
                {
                    TaskId = 2,
                    TaskName = "Authentication Lab",
                    DueDate = DateTime.ParseExact("02/23/2023 11:59 PM", "MM/dd/yyyy h:mm tt", null),
                    Quadrant = 1,
                    CategoryId = 2,
                    Completed = false
                },
                new TaskModel
                {
                    TaskId = 3,
                    TaskName = "Watch TV",
                    Quadrant = 4,
                    CategoryId = 1,
                    Completed = false
                }
            ) ;
        }
    }
}

