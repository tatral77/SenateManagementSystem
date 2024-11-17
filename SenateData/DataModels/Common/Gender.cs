namespace SenateData.DataModels.Common
{
    public class Gender
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public IList<SenateUser> SenateUsers { get; set; }
    }
}
