using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class MemberAllotments
    {
        public int AllotmentId { get; set; }
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public int TenureId { get; set; }
        public string Tenure { get; set; }
        public int AccomTypeId { get; set; }
        public string AccomType { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string SubAllotments { get; set; }

        public List<MemberSubAllotments> subAllotments = null;


    }
}
