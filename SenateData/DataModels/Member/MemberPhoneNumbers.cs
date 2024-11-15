using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class MemberPhoneNumbers
    {
        public int MemberPhonesId { get; set; }
        public string Description { get; set; }
        public int PhoneTypeId { get; set; }
        public string PhoneType { get; set; }
        public string PhoneNumber { get; set; }
        public int EmpId { get; set; }

    }
}
