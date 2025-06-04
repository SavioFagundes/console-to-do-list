namespace Program
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to the to do list prrogram!");
            List<string> taskList = new List<string>();
            string option = "";

            while (option != "e")
            {
                System.Console.WriteLine("What would you like to do?");
                System.Console.WriteLine("Enter 1 to add a task to the list.");
                System.Console.WriteLine("Enter 2 to remove a task from the list.");
                System.Console.WriteLine("Enter 3 to view the tasks in the list.");
                System.Console.WriteLine("Enter e to exit the program.");

                option = System.Console.ReadLine();

                if (option == "1")
                {
                    System.Console.WriteLine("Enter the task you want to add:");
                    string task = System.Console.ReadLine();
                    taskList.Add(task);
                    System.Console.WriteLine($"Task '{task}' added to the list.");
                }
                else if (option == "2")
                {
                    System.Console.WriteLine("Enter the task you want to remove:");
                    string task = System.Console.ReadLine();
                    if (taskList.Remove(task))
                    {
                        System.Console.WriteLine($"Task '{task}' removed from the list.");
                    }
                    else
                    {
                        System.Console.WriteLine($"Task '{task}' not found in the list.");
                    }
                }
                else if (option == "3")
                {
                    System.Console.WriteLine("Current tasks in the list:");
                    foreach (var t in taskList)
                    {
                        System.Console.WriteLine($"- {t}");
                    }
                }
                else if (option != "e")
                {
                    System.Console.WriteLine("Invalid option, please try again.");
                }
            }
            System.Console.WriteLine("Thank you for using the to do list program. Goodbye!");
        }
    }
}