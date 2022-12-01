namespace DesignPatterns.Exercises.Basic.Observer;

public class PostOffice
{
    private readonly IList<Package> _packagesInPostOffice = new List<Package>();

    private IList<ITrackTrace>? _trackAndTraceApps;

    public void ReceivePostalPackage(Package package)
    {
        _packagesInPostOffice.Add(package);
        UpdateTrackTraceApps(package);
    }

    public void SortPostalPackage(Guid packageId, Postman postman)
    {
        var toBeSortedPackage = FindPackage(packageId);
        toBeSortedPackage.AssignedPostMan = postman;

        UpdateTrackTraceApps(toBeSortedPackage);
    }

    public void SendPackage(Guid packageId)
    {
        var sentPackage = FindPackage(packageId);

        if (sentPackage.AssignedPostMan == null)
        {
            throw new InvalidOperationException($"Package with id {sentPackage.PackageId} is not sorted yet!");
        }

        sentPackage.SentDate = DateTime.Now;
        _packagesInPostOffice.Remove(sentPackage);

        UpdateTrackTraceApps(sentPackage);
    }

    private Package FindPackage(Guid packageId)
    {
        var toBeSortedPackage = _packagesInPostOffice.SingleOrDefault(x => x.PackageId == packageId);
        if (toBeSortedPackage == null)
        {
            throw new InvalidOperationException($"Package with id {packageId} is not in the PostOffice!");
        }

        return toBeSortedPackage;
    }

    public void SetTrackAndTraceApps(IList<ITrackTrace> trackAndTraceApps)
    {
        _trackAndTraceApps = trackAndTraceApps;
    }

    private void UpdateTrackTraceApps(Package package)
    {
        if (_trackAndTraceApps == null) return;
        
        foreach (var trackTrace in _trackAndTraceApps)
        {
            trackTrace.InformPackageStatusChange(package);
        }
    }
}