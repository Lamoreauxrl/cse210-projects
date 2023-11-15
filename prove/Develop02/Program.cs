using System;

class Program
{
    static void Main(string[] args)
    {   
        
        Journal journal = new Journal();
        string answer;
        

        do
        {
            
            Console.WriteLine("1) Load Journal");
            Console.WriteLine("2) New Entry");
            Console.WriteLine("3) Display All Entries");
            Console.WriteLine("4) Save Journal");
            Console.WriteLine("5) Exit");
            Console.Write("\nPlease make your selection: ");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                Console.Write("What is the name of the file you would like to load? ");
                string nameFile = Console.ReadLine();
                journal.LoadFromFile(nameFile);
            }
            else if (answer == "2")
            {
                Entry thisEntry = new Entry();
                thisEntry.CurrentEntry();
                journal.AddEntry(thisEntry);
            }
            else if (answer == "3")
            {
                journal.DisplayAll();
                Console.WriteLine("");
            }
            else if (answer == "4")
            {
                Console.Write("What is the name of your file you would like to save to? ");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
            }
        }while (answer != "5");
    }  
}



