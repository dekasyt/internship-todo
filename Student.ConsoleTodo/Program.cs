public class Task
{
    public string Title;
    public string Description;

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
                case "1": Read(); break;
                case "2": Write(); break;
                default:
                    Console.WriteLine("Некорректный ввод\nДля повтора программы нажмите любую кнопку!");
                    Console.ReadKey();
                    break;
            }
        }
    }

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
                break;
        }
    }

    public static void Write()
    {
        Console.Clear();
        Task.AddToList(tasksList);
        Console.WriteLine("Задача добавлена. Нажмите любую клавишу для возврата в меню.");
        Console.ReadKey(true);
    }
}