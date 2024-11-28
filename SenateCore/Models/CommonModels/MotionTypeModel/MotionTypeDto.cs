namespace SenateCore.Models.CommonModels.MotionTypeModel
{
    public class MotionTypeDto: BaseMotionTypeDto
    {
        public int SortOrder { get; set; }
        public IList<Motion> Motions { get; set; }
    }
}
