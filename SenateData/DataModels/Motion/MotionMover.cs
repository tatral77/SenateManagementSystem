namespace SenateData.DataModels.Motion
{
    public class MotionMover
    {
        public int MotionMoversId { get; set; }
        public int MotionId { get; set; }
        public int SystemUsersId { get; set; }
        public string MoverName { get; set; }
    }
}
