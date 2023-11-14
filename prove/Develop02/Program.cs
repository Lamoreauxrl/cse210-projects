using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        var selection = "";

        do
        {
            Entry anEntry = new Entry();

            Console.WriteLine($"1. Open Journal");
            Console.WriteLine("2. New Journal Entry");
            Console.WriteLine("3. Display Entries");
            Console.WriteLine("4. Save Journal");
            Console.WriteLine("5. Exit");
            Console.Write("Please Select a number: ");
            selection = Console.ReadLine();

            if (selection == "1")
            {
                Console.Write("\nPlease specify the file you would like to open: ");
                string oldJournal = Console.ReadLine();
                theJournal.LoadFromFile(oldJournal);
            }
            else if (selection == "2")
            {
                Console.WriteLine("");
                Console.WriteLine(anEntry._date);
                Console.WriteLine(anEntry._questionText);
                anEntry._entryText = Console.ReadLine();
                theJournal.AddEntry(anEntry);
                Console.WriteLine("");
            }
            else if (selection == "3")
            {
                theJournal.DisplayAll();
                Console.WriteLine("");
            }
            else if (selection == "4")
            {
                Console.Write("\nPlease specify the file you would like to save to: ");
                string jFile = Console.ReadLine();
                theJournal.SaveToFile(jFile);
            }
        }while (selection != "5");
    }
}



