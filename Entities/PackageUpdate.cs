namespace DevTrackR.API.Entities
{
    public class PackageUpdate
    {
        public PackageUpdate(String Status)
        {

        }
        public PackageUpdate(int id, String status, DateTime updateDate)
        {
            this.Id = id;
            this.Status = status;
            this.UpdateDate = updateDate;

        }
        public int Id { get; private set; }
        public String Status { get; private set; }
        public DateTime UpdateDate { get; private set; }
    }
}