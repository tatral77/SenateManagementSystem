using System.ComponentModel.DataAnnotations;

namespace SenateData.DataModels.Common
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string CountryCode { get; set; }
        public virtual IList<City> Cities { get; set; }

    }
}
