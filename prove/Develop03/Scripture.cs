public class Scripture
{
    private string _verse;

    public Scripture(string verse)
    {
        _verse = verse;
    }

    public void VerseList()
    {
        List<string> thisVerseList = new List<string>(_verse.Split(" "));
    }
}