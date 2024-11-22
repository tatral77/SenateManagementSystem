namespace SenateCore.Models.CommonModels.MotionStatusModel
{
    public class MotionStatusDto: BaseMotionStatusDto
    {
        public int Id { get; set; }
        public IList<QuestionDto> Motions { get; set; }
    }
}
