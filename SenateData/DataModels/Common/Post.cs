using SenateData.DataModels.HRM;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SenateData.DataModels.Common
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int BPSFrom { get; set; }
        public int BPSTo { get; set; }
        public int NumberOfPosts { get; set; }
        public int PermanentPosts { get; set; }
        public int TemporaryPosts { get; set; }
        public string RequiredQualification { get; set; }
        public string JobExperience { get; set; }
        public string JobDescription { get; set; }
        public int AppointmentModeId { get; set; }
        public string SanctionNumber { get; set; }
        public DateTime SanctionDate { get; set; }
        public string Remarks { get; set; }
        public DateTime UpgradationDate { get; set; }
        public bool IsGazetted { get; set; }

        [ForeignKey(nameof(EmployeePoolsId))]
        public int EmployeePoolsId { get; set; }
        public EmployeePool EmployeePool { get; set; }

        [ForeignKey(nameof(PostStatusId))]
        public int PostStatusId { get; set; }
        public PostStatus postStatus { get; set; }

        [ForeignKey(nameof(PostTypeId))]
        public int PostTypeId { get; set; }
        public PostType PostType { get; set; }

        [ForeignKey(nameof(PostSubTypeId))]
        public int PostSubTypeId { get; set; }
        public PostSubType postSubType { get; set; }

      
    }
}
