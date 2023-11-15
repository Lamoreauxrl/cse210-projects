public class Entry
{
    public string _date;
    public string _questionText;
    public string _entryText;

    public Entry()
    {
      DateTime curTime = DateTime.Now;
      _date = curTime.ToShortDateString();

      var aQuestion = new Questions();
      _questionText = aQuestion.GetRandomQuestion();
    }

    public void CurrentEntry()
    {
        Console.WriteLine($"\n{_date}\n{_questionText}");
        _entryText = Console.ReadLine();
        Console.WriteLine("");
    }

     

    public void Display()
    {
        Console.WriteLine($"\n{_date}\n{_questionText}\n{_entryText}");
    }
}