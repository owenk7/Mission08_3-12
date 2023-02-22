using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Mission08_3_12.Models
{
    public class TaskContext:DbContext
    {
        //Constructor
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {

        }

        //setting connection 
        public DbSet<Task> Tasks { get; set; }
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
            ab.Entity<Task>().HasData(
                new Task
                {

                    TaskId = 1,
                    TaskName = "Homework for 404",
                    //DueDate = DateTime.Parse("2023-02-22", "yyyy-MM-dd"),
                    Quandrant = 1,
                    CategoryId = 2,
                    Completed = false

                }
            ) ;
        }
    }
}

