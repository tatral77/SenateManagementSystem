using System.ComponentModel.DataAnnotations;

namespace SenateData.DataModels.Common
{
    public class ResolutionType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Description { get; set; }
        public bool IsActive { get; set; }

    }
}
