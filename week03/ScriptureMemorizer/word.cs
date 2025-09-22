public class Words
{
    private string word;
    private bool hidden;



    public Word(string w)
    {
        word = w;
        hidden = false;
    }

    public void Hide()
    {
        hidden = true;
    }

    public string Show()
    {
        if (hidden)
        {
            return new string('_', word.Length);
        }
        else
        {
            return word;
        }
    }

    public bool IsHidden()
    {
        return hidden;
    }
}