public class Reference
{
    private string book;
    private int chapter;
    private int verse;



    public Reference(string b, int c, int v)
    {
        book = b;
        chapter = c;
        verse = v;
    }

    public string Show()
    {
        return book + " " + chapter + ":" + verse;
    }
}