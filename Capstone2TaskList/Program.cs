using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone2TaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = "y";
            Console.WriteLine("Welcome to the Task Manager!");

            List<Task> tasks = new List<Task>();
            while (response == "y")
            { 
                Console.WriteLine("1: List Task ");
                Console.WriteLine("2: Add Task");
                Console.WriteLine("3: Delete Task");
                Console.WriteLine("4: Mark Task Complete");
                Console.WriteLine("5: Quit ");
                Console.WriteLine("Please Select an option from the menu!");
                string input = Console.ReadLine();
                
                switch (input)
                {
                    case "1":
                        foreach (Task task in tasks)
                        {

                            foreach (string member in task.members)
                            {
                                Console.Write("Team Member:  " + member + "\t");
                            }
                            Console.WriteLine($"Date:  " + task.date + "\t" + "Status: " + task.status + "\t" + "Description:  " + (task.description));
                            //TODO bonus allow the user to only dsiplay tasks for one team member
                            //TODO bonus allow the user to display tasks before a due date they choose
                            //TODO bonus allow the user to edit a task that has already been entered
                        }
                        break;

                    case "2":
                        string newMember = (";");
                        Task newTask = new Task();
                        while (newMember != "")
                        {
                            Console.WriteLine("Please add a member: ");
                            newMember = Console.ReadLine();
                            newTask.members.Add(newMember);
                            Console.WriteLine("Would you like to add another team member? y/n");
                            string selection = Console.ReadLine();
                            if (selection == "y")
                            {
                                Console.WriteLine("Add member or press enter to exit");
                            }
                            else
                            {
                                break;
                            }
                        }
                        Console.WriteLine("Please add a end date");
                        newTask.date = Console.ReadLine();
                        Console.WriteLine("Please add a description");
                        newTask.description = Console.ReadLine();
                        tasks.Add(newTask);
                        Console.WriteLine("Your task has been entered!");
                        break;

                    case "3": 
                        
                        if (tasks.Remove(GetTask(tasks,"What would you like to delete")))
                        { 
                            Console.WriteLine("Task Removed");
                        }
                        else
                        {
                            Console.WriteLine("Task not found");
                        }
                        break;
                    //TODO validate it is a number entered and within range for case 3.  Prompt them until they enter a number within range.
                    //TODO ask if they are sure they want to delete the task number they have entered for case 3
                    case "4":
                        Console.WriteLine("Which task would you like to mark complete?");
                        int indexMark = int.Parse(Console.ReadLine());
                        indexMark--;
                        tasks[indexMark].status = true;
                        break;
                    //TODO validate it is a number entered and within range for list.  Prompt them until they enter a number within range  
                    //TODO Display the task the user selected, ask if they are sure if they want to complete
                    case "5":
                        response = "n";
                        Console.WriteLine("Are you sure you would like to quit y/n");
                        response = Console.ReadLine().ToLower();
                        if(response == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Thank you!  Goodbye!");
                            return;
                        }    
                        
                    default: break;
                }
                if (response.ToLower() != "y")
                {
                    Console.WriteLine("Would you like to continue? y/n");
                    response = Console.ReadLine().ToLower();
                }
            }
        }

        public static Task GetTask(List<Task>list, string message)
        {
            Console.WriteLine(message);
            int indexDelete = int.Parse(Console.ReadLine());
            indexDelete--;
            return list[indexDelete];
        }

        public static List<Task> DummyData()
        {
            List<Task> list = new List<Task>();

            for (int i = 0; i < 5; i++)
            {
                Task task = new Task();
                for (int j = 0; j < 3; j++)
                {
                    task.members.Add($"Jeff{i + 1}{j + 1}");
                }
                task.date = "08/08/2019";
                task.description = $"Project{i + 1}";
                list.Add(task);
            }
            return list;
        }
    }
}


 