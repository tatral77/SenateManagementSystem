using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SenateData.DataModels.Common
{
    public class LeaveType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Description { get; set; }
        [MaxLength(10)]
        public int DaysAllowed { get; set; }
        public bool IsActive { get; set; }

    }
}
