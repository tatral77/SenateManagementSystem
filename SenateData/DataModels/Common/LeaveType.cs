using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SenateData.DataModels.Common
{
    public class LeaveType
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int DaysAllowed { get; set; }
        public bool IsActive { get; set; }

    }
}
