using System;

class Program
{
    static void Main(string[] args)
    {
        YouVid v1 = new YouVid("Funny Compilation", "Jim", 122);
        YouVid v2 = new YouVid("Coding overexplained", "Jimmy", 103429695);
        YouVid v3 = new YouVid("Coding underexplained", "Bobby", 2);

        v1.AddComment(new Comment("ProGamer1", "Haha lol"));
        v1.AddComment(new Comment("SmartGuy101", "Too funny!"));
        v1.AddComment(new Comment("NoFunnyBusinessMan", "Not funny, didnt laugh"));

        v2.AddComment(new Comment("SmartCodingDude", "Too easy"));
        v2.AddComment(new Comment("John", "Can you go a little more in depth next time?"));
        v2.AddComment(new Comment("Jonathieghn", "My head hurts"));

        v3.AddComment(new Comment("DumbDude", "Ok"));
        v3.AddComment(new Comment("IDontGotTimeForThisMan2295", "Thank you for keeping it short"));
        v3.AddComment(new Comment("OkImLazy6534", "Great now i know how to code"));

        List<YouVid> vids = new List<YouVid>() { v1, v2, v3 };

        foreach (YouVid v in vids)
        {
            Console.WriteLine(v.Title + "by " + v.Author + " (" + v.Length + "s) " + v.GetNumComments() + " comments");
            foreach (Comment c in v.Comments)
            {
                Console.WriteLine(c.Name + ": " + c.Text);
            }
            Console.WriteLine();
            
        }
    }
}