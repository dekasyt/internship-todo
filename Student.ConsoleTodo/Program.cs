namespace Student.ConsoleTodo
{
    public class Program
    {
        static List<Task> tasksList = new List<Task>();
        public static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Для вызова выполняемой подпрограммы укажите ее номер и нажните Enter:");
                Console.WriteLine("1 - Посмотреть список задач");
                Console.WriteLine("2 - Добавить задачу");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        GetTasks();
                        break;

                    case "2":
                        AddTask();
                        break;

                    default:
                        Console.WriteLine("Некорректный ввод\nДля повтора программы нажмите любую кнопку!");
                        Console.ReadKey();
                        break;
                }

            }

        }

        /// <summary>
        /// Получить задачи.
        /// </summary>
        public static void GetTasks()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Список задач:");

                foreach (Task task in tasksList)
                {
                    Console.WriteLine($"Заголовок: {task.Title}");
                    Console.WriteLine($"Описание: {task.Description}\n");
                }

                Console.WriteLine("Для возврата к списку подпрограмм нажмите Esc");
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Escape)
                { 
                    break;
                }

            }

        }

        /// <summary>
        /// Добавить задачу.
        /// </summary>
        public static void AddTask()
        {
            Console.Clear();
            Task.AddToList(tasksList);
            Console.WriteLine("Задача добавлена. Нажмите любую клавишу для возврата в меню.");
            Console.ReadKey(true);
        }
    }
}