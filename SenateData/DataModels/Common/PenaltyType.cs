using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstablishmentENT
{
    public class PenaltyType
    {
        public int Id { get; set; }
        public string PenaltyType { get; set; }
        public int IsMajor { get; set; }
        public int IsActive { get; set; }
    }
}
