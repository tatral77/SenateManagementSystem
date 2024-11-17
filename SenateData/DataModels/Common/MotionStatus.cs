namespace SenateData.DataModels.Common
{
    public class MotionStatus
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public IList<Motion> Motions { get; set; }
        public bool IsActive { get; set; }
    }
}
