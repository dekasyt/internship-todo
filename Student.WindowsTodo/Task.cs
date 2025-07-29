namespace Student.WindowsTodo
{
    /// <summary>
    /// Представляет задачу с заголовком и описанием.
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
        /// Инициализирует новую задачу с заголовком и описанием.
        /// </summary>
        /// <param name="title">Заголовок задачи</param>
        /// <param name="description">Описание задачи</param>
        public Task(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}