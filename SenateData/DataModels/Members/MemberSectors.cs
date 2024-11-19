using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class MemberSectors
    {
        public int MemberSectorId { get; set; }
        public int MemberId { get; set; }
        public int FinancialYearId { get; set; }
        public string FinancialYear { get; set; }
        public int CityId { get; set; }
        public string City { get; set; }
    }
}
