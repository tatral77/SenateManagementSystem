using SenateData.DataModels.Notice;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateData.DataModels.Common
{
    public class AttendanceStatus
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20,ErrorMessage ="Status should not be more than 20 characters")]
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public virtual IEnumerable<MemberAttendance> MemberAttendances { get; set; }
    }
}
