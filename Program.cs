// Что то пытаюсь
using System;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var todoList = new ToDoList();
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("To-Do List Application");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Remove Task");
                Console.WriteLine("3. View Tasks");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Enter task name: ");
                        string taskName = Console.ReadLine();
                        todoList.AddTask(taskName);
                        break;
                    case "2":
                        Console.Write("Enter task ID to remove: ");
                        if (int.TryParse(Console.ReadLine(), out int taskId))
                        {
                            todoList.RemoveTask(taskId);
                        }
                        else
                        {
                            Console.WriteLine("Invalid task ID");
                        }
                        break;
                    case "3":
                        todoList.DisplayTasks();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}