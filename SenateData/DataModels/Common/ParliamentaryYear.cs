using System.ComponentModel.DataAnnotations;

namespace SenateData.DataModels.Common
{
    public class ParliamentaryYear
    {
        [Key]
        public int Id { get; set; }
        public string Year { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TermId { get; set; }
        public ParliamentaryTerm ParliamentaryTerm { get; set; }
        public virtual IList<ParliamentarySession> ParliamentarySessions { get; set; }
    }
}
