namespace DesignPatterns.Exercises.Basic.Observer;

/*
 * Exercise: implement the observer pattern so that the TrackAndTraceApp doesn't have to visit the postoffice, but that
 * it gets notified whenever a package has changed status (sorted / send / ...)
 */

public class ObserverExerciseClient
{
    private readonly PostOffice _office = new PostOffice();
    
    public void Run()
    {
        var trackAndTraceApps = new List<ITrackTrace>
        {
            new TrackAndTrace(),
            new TrackAndTraceEmail(),
            new TrackAndTraceLetter()
        };

        _office.SetTrackAndTraceApps(trackAndTraceApps);
        
        // send 2 packages
        var postman1 = new Postman
        {
            Name = "Awkward Postman" 
        };
        
        var postman2 = new Postman
        {
            Name = "Scary guy" 
        };
        
        var package1 = new Package
        {
            PackageId = Guid.NewGuid(),
            NameReceiver = "Derk Sneijders",
            NameSender = "bol.com"
        };
        
        var package2 = new Package
        {
            PackageId = Guid.NewGuid(),
            NameReceiver = "Frank Waanders",
            NameSender = "coolblue"
        };
        
        _office.ReceivePostalPackage(package1);
        _office.SortPostalPackage(package1.PackageId, postman1);
        _office.SendPackage(package1.PackageId);

        _office.ReceivePostalPackage(package2);
        _office.SortPostalPackage(package2.PackageId, postman2);
        _office.SendPackage(package2.PackageId);
    }
}