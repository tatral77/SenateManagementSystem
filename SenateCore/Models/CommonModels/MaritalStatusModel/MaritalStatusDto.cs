namespace SenateCore.Models.CommonModels.MaritalStatusModel
{
    public class MaritalStatusDto: BaseMaritalStatusDto
    {
        public int Id { get; set; }
        public IList<SenateUserDto> SenateUser { get; set; }
    }
}
