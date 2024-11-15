using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class MembersDescription
    {
        public int EmpId { get; set; }
        public int SystemUserId { get; set; }
        public int ElectionProvince { get; set; }
        public int PoliticalParty { get; set; }
        public int Portfolio { get; set; }
        public int MemberStatus { get; set; }
        public int ConstituenciesId { get; set; }
        public int PolAffiliation { get; set; }
        public int IsActive { get; set; }
        public int AssembliesId { get; set; }
        public string SuiteNo { get; set; }
        public string AccountId { get; set; }
        public int HouseAffiliationId { get; set; }
        public int PartyDesignationId { get; set; }
        public int MemElectTypesId { get; set; }
        public int ElectionTypesId { get; set; }
        public int PartyDesignationsId { get; set; }
        public DateTime TenureFrom { get; set; }
        public DateTime TenureTo { get; set; }
        public int Predecessor { get; set; }
        public string OtherPartyDesignation { get; set; }
        public int SeatTypesId { get; set; }
        public string Description { get; set; }
        public string Achievements { get; set; }
        public string SPLTravelInstructions { get; set; }
        public int MemTenuresId { get; set; }

    }
}
