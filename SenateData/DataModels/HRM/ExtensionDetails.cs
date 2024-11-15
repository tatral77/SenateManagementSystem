using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstablishmentENT
{
    public class ExtensionDetails
    {
        public int ExtensionId { get; set; }
        public int EmploymentHistoryId { get; set; }
        public int SystemUsersId { get; set; }
        public DateTime ExtendedTo { get; set; }
        public string Remarks { get; set; }
    }
}
