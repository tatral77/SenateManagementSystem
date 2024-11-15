using SenateData.DataModels.Common;
using System.ComponentModel.DataAnnotations.Schema;
namespace SenateData.DataModels.Member

{
    public class TravelHistory
    {
        public int Id { get; set; }
        
        [ForeignKey(nameof(EmpId))]
        public int EmpId { get; set; }

        [ForeignKey(nameof(SystemUserId))]
        public int SystemUserId { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public string Purpose { get; set; }
        public int IsOfficial { get; set; }
        public int OfficialVisitTypesId { get; set; }
        public string OfficialVisitType { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string IsParlDeleLeader { get; set; }
        public string TravelYear { get; set; }
    }
}
