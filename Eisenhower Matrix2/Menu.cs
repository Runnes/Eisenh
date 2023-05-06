namespace Program;

public class Menu
{
    public static void PrintMenu()
    {
        Console.WriteLine(" 1 - print current task list, 2 - add new task");
    }
    
    public static void ListChoice()
    {
        string[] TaskList = Tasks.ReadFile();
        string menuChoice = Console.ReadLine();
        switch (menuChoice)
        {
            case "1":
                Tasks.PrintMatrix(TaskList);
                break;

            case "2":
                Console.WriteLine("Please input task name, importance, urgency");
                Tasks.WriteToFile(Console.ReadLine());
                break;
        }
        
    }
}