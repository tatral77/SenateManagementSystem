using SenateData.DataModels.Questions;

namespace SenateCore.Models.CommonModels.MotionStatusModel
{
    public class BaseMotionStatusDto
    {
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
