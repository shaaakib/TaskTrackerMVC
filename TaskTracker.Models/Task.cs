using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker.Models
{
    public enum TaskPriority
    {
        High,
        Medium,
        Low
    }

    public enum TaskStatus
    {
        Pending,
        InProgress,
        Completed
    }
    public class Task
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [Required]
        public TaskPriority Priority { get; set; }
        [Required]
        public TaskStatus Status { get; set; }
    }
}
