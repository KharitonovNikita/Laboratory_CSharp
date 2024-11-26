using System;
using System.Collections.Generic;

namespace ToDoApp
{
    public class ToDoList
    {
        private List<Task> tasks = new List<Task>();

        public void AddTask(string taskName)
        {
            int taskId = tasks.Count + 1;
            tasks.Add(new Task(taskId, taskName));
            Console.WriteLine($"Task '{taskName}' added.");
        }

        public void RemoveTask(int taskId)
        {
            var task = tasks.Find(t => t.Id == taskId);
            if (task != null)
            {
                tasks.Remove(task);
                Console.WriteLine($"Task '{task.Name}' removed.");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }

        public void DisplayTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
            }
            else
            {
                foreach (var task in tasks)
                {
                    Console.WriteLine($"ID: {task.Id} - {task.Name}");
                }
            }
        }
    }

    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Task(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}