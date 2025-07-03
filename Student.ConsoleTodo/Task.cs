namespace Student.ConsoleTodo
{
    /// <summary>
    /// Задача.
    /// </summary>
    public class Task
    {
        /// <summary>
        /// Заголовок задачи.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Описание задачи.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Создает новую задачу и добавляет ее в список
        /// </summary>
        /// <param name="tasksList">Список задач</param>
        public static void AddToList(List<Task> tasksList)
        {
            Task task = new Task();
            Console.WriteLine("Введите заголовок. По завершению ввода нажмите Enter:");
            task.Title = Console.ReadLine();
            Console.WriteLine("Введите описание. По завершению ввода нажмите Enter:");
            task.Description = Console.ReadLine();
            tasksList.Add(task);
        }
    }
}