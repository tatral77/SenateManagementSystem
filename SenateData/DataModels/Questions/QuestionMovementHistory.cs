namespace SenateData.DataModels.Questions
{
    public class QuestionMovementHistory
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int PreviousQuestionId { get; set; }
        public int ParliamentarySessionId { get; set; }
        public int FromParliamentarySession { get; set; }
        public int ToParliamentarySession { get; set; }
        public DateTime MovementDate { get; set; }
        public string Remarks { get; set; }
    }
}
