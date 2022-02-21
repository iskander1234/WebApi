using System;
using System.Collections.Generic;
using System.Linq;
using TaskTracker.WebApi.Model;
using Microsoft.AspNetCore.Mvc;
using TaskTracker.WebApi.Context;

namespace TaskTracker.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskTrackerController : Controller
    {
        private readonly CRUDContext _db;
        public TaskTrackerController(CRUDContext db)
        {
            _db = db;
        }

        // Tasks List 
        
        [HttpGet("List")]
        public IEnumerable<Task> Get()
        {
            return _db.Tasks;
        }        
        
        // Task 
        [HttpGet("{id}", Name = "Get")]
        public Task Get(int id)
        {
            return _db.Tasks.SingleOrDefault(x=>x.Id == id);
        }

        // Create Task 
        [HttpPost("Create")]
        public void Post([FromBody] Task task)
        {
            _db.Tasks.Add(task);
            _db.SaveChanges();
        }

        // Edit Task
        [HttpPut("Edit/{id}")]
        public void Put(int id, [FromBody] Task task)
        {
            task.Id = id;
            _db.Tasks.Update(task);
            _db.SaveChanges();
        }

        // Delete Task
        
        [HttpDelete("Delete/{id}")]
        public void Delete(int id)
        {
            var item = _db.Tasks.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                _db.Tasks.Remove(item);
                _db.SaveChanges();
            }
        }
        
        // Enum Active Task priority (int) 
        [HttpPost("Active/{id}")]
        public Task Active(int id)
        {
            var task = _db.Tasks.FirstOrDefault(t => t.Id == id);
            if (task is null)
                return null;
            else
            {
                task.Status = Status.Active;
                task.ActiveDate = DateTime.Now;
                _db.Tasks.Update(task);
                _db.SaveChanges();
            }
            return task;
        }
        
        // Enum Completed Task priority (int) 
        [HttpPost("Completed/{id}")]
        public Task Completed(int id)
        {
            var task = _db.Tasks.FirstOrDefault(t => t.Id == id);
            if (task is null)
                return null;
            else
            {
                task.Status = Status.Completed;
                task.CompletedDate = DateTime.Now;
                _db.Tasks.Update(task);
                _db.SaveChanges();
            }
            return task;
        }
        
        // Enum InProgress Task priority (int) 
        [HttpPost("InProgress/{id}")]
        public Task InProgress(int id)
        {
            var task = _db.Tasks.FirstOrDefault(t => t.Id == id);
            if (task is null)
                return null;
            else
            {
                task.Priority = Priority.InProgress;
                _db.Tasks.Update(task);
                _db.SaveChanges();
            }

            return task;
        }
        
        // Enum Done Task priority (int) 
        [HttpPost("Done/{id}")]
        public Task Done(int id)
        {
            var task = _db.Tasks.FirstOrDefault(t => t.Id == id);
            if (task is null)
                return null;
            else
            {
                task.Priority = Priority.Done;
                _db.Tasks.Update(task);
                _db.SaveChanges();
            }
            return task;
        }
    }
}