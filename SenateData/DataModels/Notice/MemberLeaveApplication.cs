using SenateData.DataModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateData.DataModels.Notice
{
    public class MemberLeaveApplication
    {
        public int LeaveApplicationId { get; set; }
        public  DateTime    NoticeDiaryDateTime { get; set; }
        public string NoticeComments { get; set; }
        public int IsSessionLeave { get; set; }
        public int MemberId { get; set; }
        public DateTime LeaveAppliedFrom { get; set; }
        public DateTime LeaveAppliedTo { get; set; }
        public ParliamentarySession ParliamentarySession { get; set; }
        public int SessionSittingId { get; set; }
        public DateTime CalledInHouseOn { get; set; }
        public string Purpose { get; set; }
        public string ApplicationUrl { get; set; }



    }
}
