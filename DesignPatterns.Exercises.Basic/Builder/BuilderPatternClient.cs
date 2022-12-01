namespace DesignPatterns.Exercises.Basic.Builder;

public class BuilderPatternClient
{
    public void Run()
    {
        var blogPostSettings = new BlogPostSettings(
            "Design Patterns for Dummies",
            "IT",
            "GoF",
            DateTime.Now,
            new List<string> { "IT", "Tech", "Programming" },
            new List<string> { "C#", "Java", ".NET", "OOP" },
            "xxx",
            "xxx");
    }
}