
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
      _entries.Add(newEntry);
      
    } 

    public void DisplayAll()
    {
      foreach (Entry jEntry in _entries)
      {
         jEntry.Display();
      }
    }

    public void SaveToFile(string file)
    {
      //Console.Write("What is the name of the file you would lik to save to: ");
      string fileName = file;

      using (StreamWriter writeFile = new StreamWriter(fileName))
      {
         foreach (Entry jEntry in _entries)
         {
            writeFile.WriteLine($"{jEntry._date}~~{jEntry._questionText}~~{jEntry._entryText}");
         }
      }
    }
    
    public void LoadFromFile(string file)
    {
      _entries.Clear();
      string filename = file;

      string[] jEntries = System.IO.File.ReadAllLines(filename);

      foreach (string jEntry in jEntries)
      {
         string[] parts = jEntry.Split("~~");

         Entry reEntry = new Entry();
         reEntry._date = parts[0];
         reEntry._questionText = parts[1];
         reEntry._entryText = parts[2];

         _entries.Add(reEntry);
      }
    }
}