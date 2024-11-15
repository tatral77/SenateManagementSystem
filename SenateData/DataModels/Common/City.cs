namespace SenateData.DataModels.Common
{
    public class City
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public bool IsActive { get; set; }

    }
}
