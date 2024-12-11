using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenateData.DataModels.Common
{
    public class District
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey(nameof(ProvinceId))]
        public int ProvinceId { get; set; }
        public ProvinceDivision ProvinceDivision { get; set; }

    }
}
