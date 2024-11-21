using SenateData.DataModels.Questions;

namespace SenateCore.Models.CommonModels.MotionStatusModel
{
    public class MotionStatusDto: BaseMotionStatusDto
    {
        public int Id { get; set; }
        public IList<Question> Motions { get; set; }
    }
}
