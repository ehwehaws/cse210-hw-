public class YouVid
{
    public string Title;
    public string Author;
    public int Length;
    public List<Comment> Comments = new List<Comment>();

    public YouVid(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public void AddComment(Comment c)
    {
        Comments.Add(c);
    }

    public int GetNumComments()
    {
        return Comments.Count;
    }
}