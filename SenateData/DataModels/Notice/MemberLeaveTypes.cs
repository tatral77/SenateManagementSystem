using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateData.DataModels.Notice
{
    public class MemberLeaveTypes
    {
        public int LeaveTypeId { get; set; }
        public string LeaveType { get; set; }
        public int DaysAllowed { get; set; }
        public int CanCarryForward { get; set; }
        public bool IsActive { get; set; }


    }
}
