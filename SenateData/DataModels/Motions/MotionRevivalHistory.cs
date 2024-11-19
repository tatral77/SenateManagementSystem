using System;

namespace SenateData.DataModels.Motions
{
    public class MotionRevivalHistory
    {
        public int RevivalHistoryId { get; set; }
        public int MotionsId { get; set; }
        public DateTime RevivalDate { get; set; }
        public int FromAssemblySessionId { get; set; }
        public string FromAssemblySession { get; set; }
        public int ToAssemblySessionId { get; set; }
        public string ToAssemblySession { get; set; }
        public int NoticeOfficediaryNumber { get; set; }
    }
}
