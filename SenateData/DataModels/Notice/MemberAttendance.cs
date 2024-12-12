using SenateData.DataModels.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenateData.DataModels.Notice
{
    public class MemberAttendance
    {
        public int Id { get; set; }
        public int SessionSittingId { get; set; }

        public int MemberId { get; set; }

        [ForeignKey(nameof(AttendanceStatusId))]
        public int AttendanceStatusId { get; set; }
        public AttendanceStatus AttendanceStatus { get; set; }
        public Member Member { get; set; }
    }
}
