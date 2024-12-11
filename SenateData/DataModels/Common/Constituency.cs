using System.ComponentModel.DataAnnotations;

namespace SenateData.DataModels.Common
{
    public class Constituency
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

    }
}
