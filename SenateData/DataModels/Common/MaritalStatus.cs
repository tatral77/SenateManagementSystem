namespace SenateData.DataModels.Common
{
    public class MaritalStatus
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public IList<SenateUser> SenateUser { get; set; }

    }

}
