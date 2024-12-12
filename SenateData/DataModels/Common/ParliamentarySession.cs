using System.ComponentModel.DataAnnotations;

namespace SenateData.DataModels.Common
{
    public class ParliamentarySession
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
        public int CalledBy { get; set; }
        public bool IsJointSession { get; set; }
        //public string SessionType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int SittingTypeId { get; set; }
        public bool IsActive { get; set; }
        //public int AssembliesId { get; set; }
        //public int SittingPlansId { get; set; }
        public int SummonedBy { get; set; }
        public int ProroguedBy { get; set; }
        public int LegislationDiaryNo { get; set; }
        public DateTime LegislationDiaryDate { get; set; }
        public int SessionStatusesId { get; set; }
        public bool IsQuorumAdjourned { get; set; }

        // tables will be created
        public string QuestionSessions { get; set; }
        public string MotionSessions { get; set; }
        public string ResolutionSessions { get; set; }

       ////
        public int BusinessStatusId { get; set; }  //carry forward or lapse
        public DateTime LegislationDiaryTime { get; set; }
        public int NoticeDiaryNo { get; set; }
        public DateTime NoticeDiaryDate { get; set; }
        public DateTime NoticeDiaryTime { get; set; }
        public string FileNo { get; set; }
        public DateTime RequisitionDate { get; set; }
        public DateTime RequisitionTime { get; set; }
        public int TotalWorkingDays { get; set; }
        public int ActualSittingDays { get; set; }
        public DateTime SummonNoticeDate { get; set; }
        public DateTime SummonNoticeTime { get; set; }
        public string Purpose { get; set; }
        public ParliamentaryYear ParliamentaryYear { get; set; }

    }
}
