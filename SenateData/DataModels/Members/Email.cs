using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Email
    {
        public int UserEmailId { get; set; }
        public string Emails { get; set; }
        public int IsOfficial { get; set; }
        public int IsActive { get; set; }


    }
}
