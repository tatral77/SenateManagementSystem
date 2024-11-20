namespace SenateCore.Models.CommonModels.GenderModel
{
    public class GenderDto
    {
        public int Id { get; set; }
        public IList<SenateUserDto> SenateUsers { get; set; }
    }
}
