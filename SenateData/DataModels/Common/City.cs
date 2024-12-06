namespace SenateData.DataModels.Common
{
    public class City
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int CountryId { get; set; }
        public int DivisionId { get; set; }
        public bool IsDistrict { get; set; }//
        public Country Country { get; set; }
        public District District { get; set; }
        public IList<SenateUser> SenateUsers { get; set; }


    }
}
