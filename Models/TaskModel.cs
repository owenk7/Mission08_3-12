using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Mission08_3_12.Models
{
    public class TaskModel
    {
        [Key]
        [Required]
        public int TaskId { get; set; }
        [Required]
        public string TaskName { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? DueDate { get; set; }
        [Required]
        public int Quadrant { get; set; }
        public bool Completed { get; set; }
        //Build foregin key relationship
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
