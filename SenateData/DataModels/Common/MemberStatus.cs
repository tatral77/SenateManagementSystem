using System.ComponentModel.DataAnnotations;

namespace SenateData.DataModels.Common
{
    public class MemberStatus
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(15)]
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
