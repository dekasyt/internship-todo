namespace Student.ConsoleTodo
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    public class Program
    {
        static List<Task> tasksList = new List<Task>();
        /// <summary>
        /// Меню.
        /// </summary>
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
                        Read();
                        break;

                    case "2":
                        Write();
                        break;

                    default:
                        Console.WriteLine("Некорректный ввод\nДля повтора программы нажмите любую кнопку!");
                        Console.ReadKey();
                        break;
                }
            }
        }
        /// <summary>
        /// Посмотреть список всех задач и их описаний.
        /// </summary>
        public static void Read()
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
        /// Добаить новую задачу и ее список.
        /// </summary>
        public static void Write()
        {
            Console.Clear();
            Task.AddToList(tasksList);
            Console.WriteLine("Задача добавлена. Нажмите любую клавишу для возврата в меню.");
            Console.ReadKey(true);
        }
    }
}