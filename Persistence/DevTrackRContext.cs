namespace DevTrackR.API.Persistence
{
    public class DevTrackRContext : DbContext
    {
    public DevTrackRContext();
    {
        Packages = new List<Package>()
    }
      public List<Package> Packages { get; set; }
             
    }

}
