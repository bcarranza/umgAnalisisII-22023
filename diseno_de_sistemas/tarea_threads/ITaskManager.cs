// Definición de la interfaz del gestor de tareas
    public interface ITaskManager
    {
        void AddTask(string task);
        void UpdateTask(int taskId, string updatedTask);
        void DeleteTask(int taskId);
        void DisplayTasks();
    }