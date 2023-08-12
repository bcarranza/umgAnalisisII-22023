// Implementación del gestor de tareas
    public class TaskManager : ITaskManager
    {
        private List<string> tasks;
        private object lockObject = new object();

        public TaskManager()
        {
            tasks = new List<string>();
        }

        public void AddTask(string task)
        {
            lock (lockObject)
            {
                tasks.Add(task);
            }
        }

        public void UpdateTask(int taskId, string updatedTask)
        {
            lock (lockObject)
            {
                if (taskId >= 0 && taskId < tasks.Count)
                {
                    tasks[taskId] = updatedTask;
                }
            }
        }

        public void DeleteTask(int taskId)
        {
            lock (lockObject)
            {
                if (taskId >= 0 && taskId < tasks.Count)
                {
                    tasks.RemoveAt(taskId);
                }
            }
        }

        public void DisplayTasks()
        {
            lock (lockObject)
            {
                Console.WriteLine("Tasks:");
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }
            }
        }
    }