namespace SenateCore.Models.CommonModels.CountryModel
{
    public class CountryDto: BaseCountryDto
    {
        public string CountryCode { get; set; }
        public virtual IList<CityDto> Cities { get; set; }
    }
}
