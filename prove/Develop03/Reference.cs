public class Reference
{
    private string _book;
    private int _chapter;
    private string _verse;

    public Reference(string book, int chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse + "-" + endVerse;
    }
}