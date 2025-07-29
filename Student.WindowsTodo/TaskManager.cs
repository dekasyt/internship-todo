using System.Collections.Generic;

namespace Student.WindowsTodo
{
    /// <summary>
    /// Управляет списком задач: добавление, получение и удаление.
    /// </summary>
    internal class TaskManager
    {
        private readonly List<Task> tasks = new List<Task>();

        /// <summary>
        /// Возвращает список всех задач.
        /// </summary>
        /// <returns>Список объектов типа Task</returns>
        public List<Task> GetTasks()
        {
            return tasks;
        }

        /// <summary>
        /// Добавляет задачу в список.
        /// </summary>
        /// <param name="task">Задача для добавления</param>
        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        /// <summary>
        /// Удаляет задачу по индексу, если он корректный.
        /// </summary>
        /// <param name="index">Индекс задачи для удаления</param>
        public void RemoveTask(int index)
        {
            if (index >= 0 && index < tasks.Count)
                tasks.RemoveAt(index);
        }
    }
}