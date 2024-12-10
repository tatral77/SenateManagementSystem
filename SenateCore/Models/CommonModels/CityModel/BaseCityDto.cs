using SenateData.DataModels.Common;

namespace SenateCore.Models.CommonModels.CityModel
{
    public class BaseCityDto
    {
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int CountryId { get; set; }
        public int DivisionId { get; set; }
        public bool IsDistrict { get; set; }
        public Country Country { get; set; }
        public District District { get; set; }
        
    }
}
