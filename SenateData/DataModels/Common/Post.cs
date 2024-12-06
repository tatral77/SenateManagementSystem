using SenateData.DataModels.HRM;
namespace SenateData.DataModels.Common
{
    public class Post
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int BPSFrom { get; set; }
        public int BPSTo { get; set; }
        public int NumberOfPosts { get; set; }//
        public int PermanentPosts { get; set; }//
        public int TemporaryPosts { get; set; }//
        public string RequiredQualification { get; set; }//
        public string JobExperience { get; set; }//
        public string JobDescription { get; set; }//
        public int AppointmentModeId { get; set; }//
        public string SanctionNumber { get; set; }//
        public DateTime SanctionDate { get; set; }//
        public string Remarks { get; set; }//
        public DateTime UpgradationDate { get; set; }//

        public bool IsGazetted { get; set; }//
        public int EmployeePoolsId { get; set; }
        public int PostTypeId { get; set; }
        public int PostSubTypeId { get; set; }
        public int PostStatusId { get; set; }

        public EmployeePool EmployeePool { get; set; }
        public PostType PostType { get; set; }
        public PostSubType postSubType { get; set; }
    }
}
