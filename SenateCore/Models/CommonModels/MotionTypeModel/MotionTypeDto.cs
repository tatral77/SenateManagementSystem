using SenateData.DataModels.Motions;

namespace SenateCore.Models.CommonModels.MotionTypeModel
{
    public class MotionTypeDto: BaseMotionTypeDto
    {
        public int Id { get; set; }
        public IList<Motion> Motions { get; set; }
    }
}
