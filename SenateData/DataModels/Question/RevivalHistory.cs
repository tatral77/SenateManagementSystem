namespace SenateData.DataModels.Question
{
    public class RevivalHistory
    {
        public int Id { get; set; }
        public int QuestionsId { get; set; }
        public DateTime RevivalDate { get; set; }
        public int FromParliamentarySessionId { get; set; }
        public string FromParliamentarySession { get; set; }
        public int ToParliamentarySessionId { get; set; }
        public string ToParliamentarySession { get; set; }
        public int NoticeOfficediaryNumber { get; set; }
        public int InsertedBy { get; set; }
        public DateTime InsertedOn { get; set; }

    }
}
