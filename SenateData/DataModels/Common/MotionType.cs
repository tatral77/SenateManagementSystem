namespace SenateData.DataModels.Common
{
    public class MotionType
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int SortOrder { get; set; }
        public IList<Motion> Motions { get; set; }
    }
}
