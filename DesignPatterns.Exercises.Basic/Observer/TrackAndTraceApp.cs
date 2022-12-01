namespace DesignPatterns.Exercises.Basic.Observer;

public interface ITrackTrace
{
    public void InformPackageStatusChange(Package package);
}

public class TrackAndTrace : ITrackTrace
{
    public void InformPackageStatusChange(Package package)
    {
        Console.WriteLine($"Package {package.PackageId} has changed. Pushing change to mobile app.");
    }
}

public class TrackAndTraceEmail : ITrackTrace
{
    public void InformPackageStatusChange(Package package)
    {
        Console.WriteLine($"Package {package.PackageId} has changed. Sending mail to receiver {package.NameReceiver}.");
    }
}

public class TrackAndTraceLetter : ITrackTrace
{
    // problem: we're only interested when a package has been sent out
    public void InformPackageStatusChange(Package package)
    {
        Console.WriteLine($"Package {package.PackageId} has changed. Sending letter to receiver {package.NameReceiver}.");
    }
}