using System;
//exceeding requirements: The menu was adapted to ever use again and again with a pause ever when you
//finish an action on the menu chooses. 
public class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    string randomPrompt = journal.GetRandomPrompt();
                    Console.WriteLine("Today's prompt: ");
                    Console.WriteLine(randomPrompt);
                    Console.WriteLine("\nNow, write your response: ");
                    string response = Console.ReadLine();
                    journal.AddNewEntry(randomPrompt, response);
                    Console.WriteLine("Entry added successfully!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;                   

                case "2":
                    journal.DisplayAll();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;

                case "3":
                    Console.Write("Enter the filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;

                case "4":
                    bool fileLoaded = false;
                    while (!fileLoaded)
                    {
                        Console.Write("Enter the filename to load: ");
                        string loadFile = Console.ReadLine();

                        try
                        {
                            journal.LoadFromFile(loadFile);
                            fileLoaded = true;
                            Console.WriteLine("Journal loaded successfully.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                            Console.WriteLine("The file does not exist or could not be loaded. Please try again.");
                            Console.WriteLine("Press '0' and 'Enter' to exit");
                            if(loadFile == "0")
                            {
                                break;
                            }
                        }
                    }
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
