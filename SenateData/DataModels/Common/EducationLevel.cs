using System.ComponentModel.DataAnnotations;

namespace SenateData.DataModels.Common
{
    public class EducationLevel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int SortOrder { get; set; }
    }
}
