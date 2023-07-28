using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class UserTask
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a task name")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Task name must be between 3 and 20 characters")]
        [Display(Name = "Task Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a task description")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Task description must be between 3 and 100 characters")]
        [Display(Name = "Task Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter a due date")]
        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }
        public bool IsComplete { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

    }
}
