using SenateData.DataModels.Common;

namespace SenateCore.Models.CommonModels.CityModel
{
    public class CityDto:BaseCityDto
    {
        public int Id { get; set; }
        public IList<SenateUser> SenateUsers { get; set; }
    }
}
