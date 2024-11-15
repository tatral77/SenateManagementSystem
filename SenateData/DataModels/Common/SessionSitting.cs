namespace SenateData.DataModels.Common
{
    public class SessionSitting
    {
        public int Id { get; set; }
        public int ParliamentarySessionId { get; set; }
        public DateTime SittingDate { get; set; }
        public int IsMorningSitting { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double TotalTimeConsumed { get; set; }
        public string Remarks { get; set; }
        public string SittingGernal { get; set; }
        public DateTime EvenStartTime { get; set; }
        public DateTime EvenEndTime { get; set; }
        public virtual IList<ParliamentarySession> ParliamentarySessions { get; set; }

    }
}
