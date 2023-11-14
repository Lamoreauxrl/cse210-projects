public class Entry
{
    public string _date;
    public string _questionText;
    public string _entryText;

    public Entry()
    {
        var curTime = DateTime.Now;
        _date = curTime.ToShortDateString();

        var aQuestion = new Questions();
        _questionText = aQuestion.GetRandomQuestion();
    }

    
    

    public void Display()
    {
        Console.WriteLine("");
        Console.WriteLine($"{_date}\n{_questionText}\n{_entryText}");
    }
}