using System;
using System.Collections.Generic;
using System.Threading;

namespace TaskManagerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ITaskManager taskManager = new TaskManager();

            // Creación de hilos para simular usuarios interactuando con la lista de tareas
            Thread threadUser1 = new Thread(() =>
            {
                taskManager.AddTask("Complete assignment 1");
                Thread.Sleep(100); // Simulating some delay
                taskManager.DisplayTasks();
            });

            Thread threadUser2 = new Thread(() =>
            {
                taskManager.AddTask("Buy groceries");
                Thread.Sleep(50); // Simulating some delay
                taskManager.DisplayTasks();
            });

            Thread threadUser3 = new Thread(() =>
            {
                taskManager.AddTask("Finish project report");
                Thread.Sleep(150); // Simulating some delay
                taskManager.DisplayTasks();
            });

            threadUser1.Start();
            threadUser2.Start();
            threadUser3.Start();

            threadUser1.Join();
            threadUser2.Join();
            threadUser3.Join();
        }
    }
}
