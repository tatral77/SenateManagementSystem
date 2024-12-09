using SenateData.DataModels.Common;

namespace SenateCore.Models.CommonModels.CityModel
{
    public class CityDto:BaseCityDto
    {
        public int CountryId { get; set; }
        public int DivisionId { get; set; }
        public bool IsDistrict { get; set; }//
        public Country? Country { get; set; }
        public District District { get; set; }
        public IList<SenateUser> SenateUsers { get; set; }
    }
}
