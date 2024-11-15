namespace SenateData.DataModels.Question
{
    public class QuestionStatusHistory
    {
        public int Id { get; set; }
        public int QuestionStatusId { get; set; }
        public int QuestionId { get; set; }
        public string QuestionStatus { get; set; }
        public int AParliamentarySessionId { get; set; }
        public string ParliamentarySession { get; set; }
        public DateTime StatusDate { get; set; }
        public DateTime ReplyDate { get; set; }
        public string Remarks { get; set; }
        public int InsertedBy { get; set; }
        public DateTime InsertedOn { get; set; }

    }
}
