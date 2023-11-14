using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    } 

    public void DisplayAll()
    {
       foreach (Entry entry in _entries)
       {
        entry.Display();
       }
    }

    public void SaveToFile(string journalfile)
    {
       
       string fileName = journalfile;

       using (StreamWriter outputFile = new StreamWriter(fileName))
       {
        foreach (Entry entry in _entries)
        {
          outputFile.WriteLine(string.Join("~~", );
        }
        
       }
    }

    public void LoadFromFile(string oldJournal)
    {
       string filename = oldJournal;
       string[] lines = System.IO.File.ReadAllLines(filename);

       foreach (string line in lines)
       {
        string[] parts = line.Split(",");
       }
    }
}