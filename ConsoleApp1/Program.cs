using ConsoleApp1;


// input only for expenses
// input only for income
// Balance = income - expenses
// history of transactions



//
//
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new ToDoList();
                                                  // 2. НАШ СПИСОК (Коробка, в которой лежат задачи)
            List<ToDoList> tasksBox = new();

            int nextId = 1;                                    // Счетчик для ID

            while (true)
            {
                Console.WriteLine("=== Menu ===");
                Console.WriteLine("1 - Show all tasks");
                Console.WriteLine("2 - Add a task");
                Console.WriteLine("3 - Mark as completed");
                Console.WriteLine("4 - Exit");
                Console.Write("Choose an action: ");

                string choice = UserInput.Input();




                switch (choice)
                {
                    case "1":                                                                // ПОКАЗАТЬ ВСЕ
                        Console.WriteLine("Your tasks:");
                        if (tasksBox.Count == 0)
                        {
                            Console.WriteLine("No tasks yet.");
                        }
                        else
                        {
                                                                                                   // Перебираем нашу коробку с задачами
                            foreach (ToDoList task in tasksBox)
                            {
                                                                                                    // Если IsDone == true, пишем [X], иначе [ ]
                                string status = task.IsDone ? "[X]" : "[ ]";
                                Console.WriteLine($"{status} ID:{task.ID} | {task.Name}");
                            }
                        }
                        break;










                    case "2":                                                                            // ДОБАВИТЬ ЗАДАЧУ
                        Console.Write("Enter task text: ");
                        string text = Console.ReadLine();

                                                                                                         // ВОТ КАК МЫ ДОБАВЛЯЕМ В СПИСОК:
                                                                                                     // а) Создаем новую задачу по шаблону
                        ToDoList newTask = new();
                        newTask.ID = nextId;
                        newTask.Name = text;
                        newTask.IsDone = false;                                                                   // По умолчанию она не выполнена

                                                                                                    // б) Кладем её в нашу коробку (список)
                        tasksBox.Add(newTask);

                        nextId++;                                                                                // Увеличиваем ID для следующей задачи
                        Console.WriteLine("Task added!");
                        break;









                    case "3":                                                                                                      // MARK AS COMPLETED
                        Console.Write("Enter the ID of the task you want to mark: ");
                        string idInput = Console.ReadLine();

                                                                                                               // Пытаемся превратить то, что ввел юзер, в число
                        if (int.TryParse(idInput, out int searchId))
                        {
                            bool isFound = false;

                                                                                                                                    // Ищем задачу с таким ID в нашем списке
                            foreach (ToDoList task in tasksBox)
                            {
                                if (task.ID == searchId)
                                {
                                                                                                                                 // ВОТ КАК МЫ МЕНЯЕМ СТАТУС:
                                                                                                                            // Мы нашли нужную задачу, меняем её свойство
                                    task.IsDone = true;
                                    isFound = true;
                                    Console.WriteLine("Great! Task completed.");
                                    break;                                                                                            // Found - exit the search loop
                                }
                            }

                            if (isFound == false)
                            {
                                Console.WriteLine("No task with such ID.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You need to enter a number!");
                        }
                        break;




                    case "4": // ВЫХОД
                        Console.WriteLine("Пока!");
                        return; // Завершает Main
                }
            }
        }
    }
}




















/*using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Program
{
   public static void Main()
    {
       List<string> Tasks = new List<string>();


        int nextID = 1;

        while(true)
        {
            Console.WriteLine("(1) Tasks:");
            Console.WriteLine("(2) Show all tasks");
            Console.WriteLine("(3) Add new task");
            Console.WriteLine("(4) Exit");

            Console.WriteLine("choose an option:");

            string choise = UserInput.Input();
            switch (choise)
            {
                case "1":
                    Console.WriteLine("Write new task:");
                    string text = Console.ReadLine(); // fix later
                    ToDoList p = new ToDoList();
                    break;

                case "2":
                    Console.WriteLine("Show all tasks:");
                    //tasks 

                    if (Tasks .Count == 0)
                    {
                        Console.WriteLine("No tasks yet.");
                    }
                    else 
                        foreach  (string task in Tasks)
                        {
                            Console.WriteLine(task);
                        }

                    break;

                case "3":
                    Console.WriteLine("Close the program");

                    break;

                case "4":
                    Console.WriteLine("Tasks:");
                    break;

            }

        }


        //UserInput.Input();

    }



    ToDoList p = new ToDoList();




}


// input only for expenses
// input only for income
// Balance = income - expenses
// history of transactions
*/