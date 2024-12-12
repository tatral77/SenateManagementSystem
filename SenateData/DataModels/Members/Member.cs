using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        public string OtherPartyDesignations { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey(nameof(SenateUserId))]
        public int SenateUserId { get; set; }

        [ForeignKey(nameof(ElectionProvinceId))]
        public int ElectionProvinceId { get; set; }

        [ForeignKey(nameof(PoliticalPartyId))]
        public int PoliticalPartyId { get; set; }

        [ForeignKey(nameof(SeatTypesId))]
        public int SeatTypesId { get; set; }

        [ForeignKey(nameof(MemberTenureId))]
        public int MemberTenureId { get; set; }

        [ForeignKey(nameof(MemberStatusId))]
        public int MemberStatusId { get; set; }

        [ForeignKey(nameof(ConstituenciesId))]
        public int ConstituenciesId { get; set; }

        [ForeignKey(nameof(HouseAffiliationId))]
        public int HouseAffiliationId { get; set; }

        [ForeignKey(nameof(PartyDesignationId))]
        public int PartyDesignationId { get; set; }

        [ForeignKey(nameof(ElectTypeId))]
        public int ElectTypeId { get; set; }

    }
}
