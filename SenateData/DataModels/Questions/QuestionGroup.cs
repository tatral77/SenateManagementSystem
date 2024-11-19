using SenateData.DataModels.Common;

namespace SenateData.DataModels.Questions
{
    public class QuestionGroup
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int CorrespondingGroupId { get; set; }
        public int CorrespondingGroup { get; set; }
        public int GroupSequence { get; set; }
        public string UnstarDesc { get; set; }
        public int ParliamentarySessionId { get; set; }
        public ParliamentarySession ParliamentarySession { get; set; }
    }
}
