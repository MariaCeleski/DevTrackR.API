namespace DevTrackR.API.Entities
{
    public class PackageUpdate
    {
        public PackageUpdate(String status, int packageId)
        {
            PackageId = packageId;
            Status = status;
            UpdateDate = DateTime.Now;         
        }
        
        public int Id { get; private set; }
        public int PackageId { get; private set; }
        public String Status { get; private set; }
        public DateTime UpdateDate { get; private set; }
    }
}