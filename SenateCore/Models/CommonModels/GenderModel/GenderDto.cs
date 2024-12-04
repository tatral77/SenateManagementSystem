using SenateCore.Models.CommonModels.SenateUserModel;

namespace SenateCore.Models.CommonModels.GenderModel
{
    public class GenderDto: BaseGenderDto
    {
        public int Id { get; set; }
        public IList<SenateUserDto> SenateUsers { get; set; }
    }
}
