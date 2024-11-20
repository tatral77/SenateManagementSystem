namespace SenateCore.Models.CommonModels.CityModel
{
    public class CityDto:BaseCityDto
    {
        public int Id { get; set; }
        public Country Country { get; set; }
    }
}
