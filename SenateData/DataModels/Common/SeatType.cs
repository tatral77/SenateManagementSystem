using System.ComponentModel.DataAnnotations;

namespace SenateData.DataModels.Common
{
    public class SeatType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
