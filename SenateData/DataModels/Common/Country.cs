namespace SenateData.DataModels.Common
{
    public class Country
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string CountryCode { get; set; }
        public virtual IList<City> Cities { get; set; }

    }
}
