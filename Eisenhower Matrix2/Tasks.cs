// See https://aka.ms/new-console-template for more information

using System;
using System.IO;
using Spectre.Console;
namespace Program
{
    class Tasks
    {
        static string textFile = "tasks.txt";


        public static void WriteToFile(string newTask)
        {

            File.AppendAllText(textFile, newTask + Environment.NewLine);

        }

        public static void PrintTaskList(string[] tasks)
        {
            var table = new Table();
            table.AddColumn("Task name").Centered();
            table.AddColumn("Task importance").Centered();
            table.AddColumn("Task urgency").Centered();
            foreach (string line in tasks)
            {
                string[] splitted = line.Split(','); ;
                string taskName = splitted[0];
                string taskImportance = splitted[1];
                string taskUrgency = splitted[2];
                table.AddRow(taskName, taskImportance, taskUrgency);

                // foreach (var split in splitted)
                // {
                //     // Console.WriteLine(split);
                //    
                // }
            }

            AnsiConsole.Write(table);
            
        }

        public static void PrintMatrix(string[] tasks)
        {

            var table = new Table();
            table.AddColumn("     ");
            table.AddColumn("Urgent").Centered();
            table.AddColumn("Not Urgent").Centered();
            table.AddRow("");
            // table.AddRow("Important");
            // table.AddRow("Not Important");
            bool FirstOfCategoryImp = true;
            bool FirstOfCategoryNotImp = true;
            foreach (string line in tasks)
            {
                
                string[] splitted = line.Split(',');
                ;
                string taskName = splitted[0];
                string taskImportance = splitted[1];
                string taskUrgency = splitted[2];
                
                if (taskImportance == "important" & taskUrgency == "urgent")
                {
                    if (FirstOfCategoryImp)
                    {
                        table.AddRow("Important", taskName, "");
                        FirstOfCategoryImp = false;
                    }
                    else
                    {
                        table.AddRow("", taskName, "");
                    }
                }
                
                if (taskImportance == "important" & taskUrgency == "not urgent")
                {
                    if (FirstOfCategoryImp)
                    {
                        table.AddRow("Important", "",taskName);
                        FirstOfCategoryImp = false;
                    }
                    else
                    {
                        table.AddRow("", "",taskName);
                    }
                }

            }
            
            table.AddRow("----------------------------------------------------------");

            foreach (string line in tasks)
            {

                string[] splitted = line.Split(',');
                ;
                string taskName = splitted[0];
                string taskImportance = splitted[1];
                string taskUrgency = splitted[2];

                if (taskImportance == "not important" & taskUrgency == "urgent")
                {
                    if (FirstOfCategoryNotImp)
                    {
                        table.AddRow("Not Important", taskName, "");
                        FirstOfCategoryNotImp = false;
                    }
                    else
                    {
                        table.AddRow("", taskName, "");
                    }
                }

                if (taskImportance == "not important" & taskUrgency == "not urgent")
                {
                    if (FirstOfCategoryNotImp)
                    {
                        table.AddRow("Not Important", "", taskName);
                        FirstOfCategoryNotImp = false;
                    }
                    else
                    {
                        table.AddRow("", "", taskName);
                    }
                }
            }

            AnsiConsole.Write(table);
        }

        public static string[] ReadFile()
        {
            string[] lines = File.ReadAllLines(textFile);
            return lines;
        }

        public static void PrintTasks(string[] lines)
        {
            foreach (string line in lines)
            {
                string[] splitted = line.Split(',');
                string taskName = splitted[0];
                string taskImportance = splitted[1];
                string taskUrgency = splitted[2];
                
                
                foreach (var split in splitted)
                {
                    Console.WriteLine(split);
                }
            }
            
        }
    }
}