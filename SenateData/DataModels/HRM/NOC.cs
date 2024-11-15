using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstablishmentENT
{
    public class NOC
    {
        public int NocId { get; set; }
        public string NocNumber { get; set; }
        public int SystemUserId{get;set;}
        public int NocTypeId { get; set; }
        public string NocType { get; set; }
        public DateTime IssueDate { get; set; }
        public string Remarks { get; set; }
       
    }
}
