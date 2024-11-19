using SenateData.DataModels.Common;

namespace SenateData.DataModels.Motions
{
    public class MotionMinistry
    {
        public int Id { get; set; }
        public int MotionId { get; set; }
        public int MinistryId { get; set; }
        public Ministry Ministry { get; set; }
        public Motion Motion { get; set; }

    }
}
