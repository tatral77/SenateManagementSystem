using EstablishmentENT;
using SenateData.DataModels.HRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateData.DataModels.Common
{
    public class EmployeeLeave
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime Enddate { get; set; }
        public Employee Employee { get; set; }
        public LeaveType  LeaveType { get; set; }

    }
}
