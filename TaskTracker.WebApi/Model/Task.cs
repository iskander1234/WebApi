using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskTracker.WebApi.Model
{
    public enum Status
    {
        NotStarted ,
        Active,
        Completed 
    }
    public enum Priority
    {
        
        ToDo,
        InProgress, 
        Done
    }
    public class Task
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        // Enum_NotStarted By statute
        public Status Status { get; set; } = Status.NotStarted;
        
        // Enum_ToDo By statute
        public Priority Priority { get; set; } = Priority.ToDo;

        public DateTime СreatedDate { get; set; } = DateTime.Now;

        public DateTime? ActiveDate { get; set; }
        
        public DateTime? CompletedDate { get; set; }

        

    }
}