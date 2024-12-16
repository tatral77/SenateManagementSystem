using SenateData.DataModels.Notice;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateCore.Models.CommonModels.AttendanceStatusModel
{
    public class BaseAttendanceStatusDto
    {
        
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public virtual IEnumerable<MemberAttendance> MemberAttendances { get; set; }
    }
}
