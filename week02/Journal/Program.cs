// *** Showing Creativity and Exceeding Requirements ***
// 1. Save other information in the journal entry.
// 1. Error handling in case an error occurs while loading the file

using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        PromptGenerator promptGenerator = new PromptGenerator();

        int option = -1;
        while (option != 5)
        {
            DisplayMenu();
            option = PromptUserOption();
            switch (option)
            {
                case 1:
                    Entry newEntry = new Entry();
                    string promtText = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\n{promtText}");
                    string entryText = Console.ReadLine();
                    string mood = PromptUserMood();
                    newEntry._date = DateTime.Now.ToShortDateString();
                    newEntry._promtText = promtText;
                    newEntry._entryText = entryText;
                    newEntry._mood = mood;

                    journal.AddEntry(newEntry);
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    string recoverFile = PromptUserFileName();

                    try
                    {
                        journal.LoadFromFile(recoverFile);
                        Console.WriteLine("\nJournal loaded successfully!");
                    }
                    catch (FileNotFoundException)
                    {
                        Console.WriteLine("Error: The file was not found.");
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine($"Error: The file cannot be read, an error ocurred. {e.Message}");
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine($"Error: {e}");
                    }
                    break;
                case 4:
                    string fileName = PromptUserFileName();

                    try
                    {
                        journal.SaveToFile(fileName);
                        Console.WriteLine("\nJournal saved successfully!");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Error saving journal: {e.Message}");
                    }
                    break;
                case 5:
                    Console.WriteLine("\nCome back soon!\n");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again with a valid option.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\nPlease select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
    }

    static int PromptUserOption()
    {
        Console.Write("What would you like to do? ");
        string optionUser = Console.ReadLine() ?? "";

        if (int.TryParse(optionUser, out int option))
        {
            return option;
        }
        return -1;
    }

    static string PromptUserFileName()
    {
        Console.WriteLine("\nWhat is the filename? ");
        string fileName = Console.ReadLine();
        return fileName;
    }

    static string PromptUserMood()
    {
        Console.WriteLine("\nHow are you feeling today? (Happy, Calm, Sad, Stressed, Excited, etc) ");
        string mood = Console.ReadLine();
        return mood;
    }
}