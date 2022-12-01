namespace DesignPatterns.Exercises.Basic.Builder;

public class BlogPostSettings
{
    public string MetadataTitle { get; set; }

    public string MetaDescription { get; set; }

    public IList<string> Tags { get; set; }

    public IList<string> Categories { get; set; }

    public DateTime Date { get; set; }

    public string Author { get; set; }

    public string Content { get; set; }

    public string Title { get; set; }
    
    public BlogPostSettings(string title, string content, string author, DateTime date, IList<string> categories,
        IList<string> tags, string metaDescription, string metadataTitle)
    {
        Title = title;
        Content = content;
        Author = author;
        Date = date;
        Categories = categories;
        Tags = tags;
        MetaDescription = metaDescription;
        MetadataTitle = metadataTitle;
    }
}
