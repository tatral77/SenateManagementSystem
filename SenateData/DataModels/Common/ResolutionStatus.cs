using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenateData.DataModels.Common
{
    [Table(nameof(ResolutionStatus),Schema = "Resolution")]
    public class ResolutionStatus
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Description { get; set; }
        public bool IsActive { get; set; }

    }
}
