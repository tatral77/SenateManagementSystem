using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstablishmentENT
{
    public class EmployeeVisit
    {
        public int ForeignVisitId { get; set; }
        public int System_User_Id { get; set; }
        public int CountryId { get; set; }
        public string Country { get; set; }
        public int VisitTypeId { get; set; }
        public string VisitType { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime NocDate { get; set; }
        public string Purpose { get; set; }
    }
}
