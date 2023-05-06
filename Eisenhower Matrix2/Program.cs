// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel.Design;
using System.IO;
using Spectre.Console;
namespace Program
{
    class Program
    {
        static void Main()
        {
            
            // Tasks Textfile = new Tasks();
           
           // Tasks.PrintTasks(TaskList);
            // Tasks.PrintTaskList(TaskList);
            // while (true){
                Menu.PrintMenu();
                Menu.ListChoice();

                //Tasks.PrintMatrix(TaskList);
                // Tasks.WriteToFile(Console.ReadLine());
                // Assembly mscorlib = typeof(string).Assembly;
                // foreach (Type type in mscorlib.GetTypes())
                // {
                //     Console.WriteLine(type.FullName);
                // }

            // }
        }
    }
}