using System.ComponentModel.DataAnnotations;

namespace SenateData.DataModels.Common
{
    public class ParliamentaryTerm
    {
        [Key]
        public int Id { get; set; }
        public string Term { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TenureId { get; set; }
        public ParliamentaryTenure ParliamentaryTenure { get; set; }
    }
}
