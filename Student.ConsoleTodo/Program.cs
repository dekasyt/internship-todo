using System;
using System.Collections;
using System.Collections.Generic;

public class Todo
{
    public string number = "";
    public string zada4a = "";
    public static void task(List<Todo> Lists)
    {
        Todo myTask = new Todo();
        Console.WriteLine("Введите заголовок. По завершению ввода нажмите Enter:");
        myTask.number = Console.ReadLine();
        Console.WriteLine("Введите описание. По завершению ввода нажмите Enter:");
        myTask.zada4a = Console.ReadLine();
        Lists.Add(myTask);
    }
}
public class MainClass
{
    static List<Todo> Lists = new List<Todo>();
    public static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Для вызова выполняемой подпрограммы укажите ее номер и нажните Enter:\r\n1 - Посмотреть список задач\r\n2 - Добавить задачу");
            string a = Console.ReadLine();
            switch (a)
            {
                case "1": Read(); break;
                case "2": Write(); break;
                default: Console.WriteLine("Некорректный ввод\nДля повтора программы нажмите любую кнопку!"); break;

            }
            
            //Console.Clear();
            continue;
        }
    }
    public static void Read()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Список задач:");
            foreach (Todo item in Lists) 
            { 
                Console.WriteLine($"Заголовок: {item.number}");
                Console.WriteLine($"Описание: {item.zada4a}");
                Console.WriteLine("");
            }
            Console.WriteLine("Для выхода в меню нажмите ESC, или же для обновления списка любую кнопку");
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Escape)
            {
                break;
            }
            else
            {
                continue;
            }
        }
    }

    public static void Write()
    {
        while (true)
        {
            Console.Clear();
            Todo.task(Lists);
            Console.WriteLine("нажмите любую кнопку для выхода в меню");
            var key = Console.ReadKey(true).Key;
            break;
        }
    }
}
