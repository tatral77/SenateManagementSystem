using SenateData.DataModels.Common;

namespace SenateCore.Models.CommonModels.CityModel
{
    public class CityDto:BaseCityDto
    {
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
