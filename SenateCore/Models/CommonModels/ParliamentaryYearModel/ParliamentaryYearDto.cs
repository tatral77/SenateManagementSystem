using SenateData.DataModels.Common;

namespace SenateCore.Models.CommonModels.ParliamentaryYearModel
{
    public class ParliamentaryYearDto: BaseParliamentaryYearDto
    {
        public int Id { get; set; }
        public ParliamentaryTerm ParliamentaryTerm { get; set; }
        public virtual IList<ParliamentarySession> ParliamentarySessions { get; set; }
    }
}
