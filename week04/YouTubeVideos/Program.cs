using System;
using System.Collections.Generic;

public class Comment
{
    private string commenter;
    private string text;

    public Comment(string commenter, string text)
    {
        this.commenter = commenter;
        this.text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{commenter}: {text}");
    }
}

public class Video
{
    private string title;
    private string author;
    private int length; // seconds
    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Length: {length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");

        foreach (Comment c in comments)
        {
            c.DisplayComment();
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learning C#", "Joe Dev", 600);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "Can you cover LINQ next?"));

        Video video2 = new Video("HTML Basics", "Web Guru", 450);
        video2.AddComment(new Comment("David", "Clear and concise."));
        video2.AddComment(new Comment("Ella", "Loved the examples."));
        video2.AddComment(new Comment("Frank", "This helped me a lot."));

        Video video3 = new Video("CSS Styling Tips", "DesignPro", 300);
        video3.AddComment(new Comment("Grace", "Awesome tips!"));
        video3.AddComment(new Comment("Henry", "I finally understand margins."));
        video3.AddComment(new Comment("Ivy", "Please do a video on Flexbox."));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video v in videos)
        {
            v.DisplayVideoInfo();
        }
    }
}
