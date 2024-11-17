using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstablishmentENT
{
    public class OtherCharge
    {
        public int OtherChargeId { get; set; }
        public int SystemUserId { get; set; }
        public int OtherChargeTypeId { get; set; }
        public string OtherChargeType { get; set; }
        public int PostId { get; set; }
        public string Post { get; set; }
        public int BPSID { get; set;}
        public string BPS { get; set; }
        public int BranchId { get; set; }
        public string Branch { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Remarks { get; set; }
    }
}
