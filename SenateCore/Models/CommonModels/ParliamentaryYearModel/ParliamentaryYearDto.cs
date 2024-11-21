using SenateData.DataModels.Common;

namespace SenateCore.Models.CommonModels.ParliamentaryYearModel
{
<<<<<<< HEAD
    public class ParliamentaryYearDto: BaseParliamentaryYearDto
=======
    public class ParliamentaryYearDto
>>>>>>> 7066553944da5b9dcedd5b6e90b2f32be78e8468
    {
        public int Id { get; set; }
        public ParliamentaryTerm ParliamentaryTerm { get; set; }
        public virtual IList<ParliamentarySession> ParliamentarySessions { get; set; }
    }
}
