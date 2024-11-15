namespace SenateData.DataModels.Question
{
    public class QuestionsRota
    {
        public int RotaListId { get; set; }
        public int ParliamentarySessionId { get; set; }
        public int SessionNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int StartGroup { get; set; }
        public string SkipDays { get; set; }
    }
}
