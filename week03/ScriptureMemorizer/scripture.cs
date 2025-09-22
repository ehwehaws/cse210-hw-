public class Scripture
{
    //r and text
    private Reference reference;
    private List<Word> words;


    public Scripture(Reference r, string text)
    {
        reference = r;
        words = new List<Word>();
        string[] parts = text.Split(" ");
        foreach (string p in parts)
        {
            words.Add(new Word(p));
        }
    }
    //wwr
    public void HideWords(int count)
    {
        Random rand = new Random();
        for (int i = 0; i < count; i++)
        {
            int index = rand.Next(words.Count);
            words[index].Hide();
        }
    }



    public string GetText()
    {
        string line = reference.Show() + " ";
        foreach (Word w in words)
        {
            line += w.Show() + " ";
        }
        return line;
    }




    public bool AllHidden()
    {
        foreach (Word w in words)
        {
            if (!w.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}