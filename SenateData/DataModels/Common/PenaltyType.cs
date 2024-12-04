using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SenateData.Common
{
    public class PenaltyType
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int IsMajor { get; set; }
        public int IsActive { get; set; }
    }
}
