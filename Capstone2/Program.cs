using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
namespace Capstone2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();
            string response = "y";

            while (response == "y")
            {


                Console.WriteLine("1.  List tasks");
                Console.WriteLine("2.  Add task");
                Console.WriteLine("3.  Delete task");
                Console.WriteLine("4.  Mark task complete");
                Console.WriteLine("5.  Quit");

                Console.WriteLine("Wagan 'Mon!, select something from the menu!: ");

                



                switch(Task.CheckNumber())
                {



                    case "1":
                        foreach (Task task in tasks)
                        {
                            foreach (string member in task.members)
                            {
                                Console.WriteLine(member);
                            }
                            Console.WriteLine(task.date.ToString("MM/dd/yyyy"));
                            Console.WriteLine(task.status);
                            Console.WriteLine(task.description);
                        }
                        break;

                    case "2":
                        string newMember = "andre";
                        Task newTask = new Task();
                        while (newMember != "")
                        {
                            Console.WriteLine("Add a member, press enter to continue.");
                            newMember = Console.ReadLine();
                            newTask.members.Add(newMember);
                        }
                        Console.WriteLine("Please enter date :");
                        newTask.date = Task.GetDate();
                        Console.WriteLine("Please enter discription.");
                        newTask.description = Console.ReadLine();

                        tasks.Add(newTask);
                        break;

                    case "3":


                        if (tasks.Remove(GetTask(tasks, "what would you like to delete")))
                        {
                            Console.WriteLine("Item removed");
                        }
                        else
                        {
                            Console.WriteLine("Item has not been found");
                        }
                        break;

                    case "4":
                        Console.WriteLine("what task do you want to mark complete !");
                        int indexMark = int.Parse(Console.ReadLine());
                        indexMark--;

                        tasks[indexMark].status = true;

                       
                        break;

                    case "5":
                        Console.WriteLine("");
                        response = "n";
                        break;

                    default: break;
                }
                if (response != "y")
                {
                    response = "n";
                }
                else
                {
                    Console.WriteLine("Would you like to continue y/n");
                    response = Console.ReadLine();
                }
            }         


        }

        public static Task GetTask(List<Task> list, string word)
        {
            Console.WriteLine(word);
            int deleteIndex = int.Parse(Console.ReadLine());
            deleteIndex--;

            return list[deleteIndex];

        }
        public static List<Task> DummyData()
        {
            List<Task> list = new List<Task>();

            for (int i = 0; i < 5; i++)
            {
                Task task = new Task();
                for (int j = 0; j < 3; j++)
                {
                    task.members.Add($"Andre {i + 1}{j + 1}");
                }
                task.date = DateTime.Now;
                task.description = $"Project{i + 1}";
                list.Add(task);
            }
            return list;
        }
    }
}
