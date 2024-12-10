using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenateData.DataModels.Common
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        
        [MaxLength(50)]
        public string Description { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey(nameof(CountryId))]
        public int CountryId { get; set; }

        [ForeignKey(nameof(DivisionId))]
        public int DivisionId { get; set; }
        public bool IsDistrict { get; set; }
        public Country Country { get; set; }
        public IList<SenateUser> SenateUsers { get; set; }


    }
}
