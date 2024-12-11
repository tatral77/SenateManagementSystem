using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenateData.DataModels.Common
{
    public class ProvinceDivision
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Description { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey(nameof(ProvinceId))]
        public int ProvinceId { get; set; }
        public Province Province { get; set; }
        public IList<District> Districts { get; set; }
    }
}
