using SenateData.DataModels.Questions;

namespace SenateCore.Models.CommonModels.MotionStatusModel
{
<<<<<<< HEAD
    public class MotionStatusDto: BaseMotionStatusDto
=======
    public class MotionStatusDto
>>>>>>> 7066553944da5b9dcedd5b6e90b2f32be78e8468
    {
        public int Id { get; set; }
        public IList<Question> Motions { get; set; }
    }
}
