namespace DesignPatterns.Exercises.Basic.Observer;

public class Package
{
    public Guid PackageId { get; set; } = Guid.NewGuid();
    public string NameSender { get; set; } = string.Empty;
    public string NameReceiver { get; set; }= string.Empty;
    public DateTime? SentDate { get; set; }
    public Postman? AssignedPostMan { get; set; }
}