using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenateData.DataModels.Common
{
    public class SenateUser
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }

        [ForeignKey(nameof(GenderId))]
        public int GenderId { get; set; }
        public Gender Gender { get; set; }

        [ForeignKey(nameof(ReligionId))]
        public int ReligionId { get; set; }
        public Religion Religion { get; set; }

        [ForeignKey(nameof(MaritalStatusId))]
        public int MaritalStatusId { get; set; }
        public MaritalStatus MaritalStatus { get; set; }

        [ForeignKey(nameof(CityId))]
        public int CityId { get; set; }
        public City City { get; set; }
        public string CNIC { get; set; }
        public DateTime CNICIssuanceDate { get; set; }
        public DateTime CNICExpiryDate { get; set; }
        public bool IsEmployee { get; set; }
        //public int ProvinceId { get; set; }
        //public Province Province { get; set; }
    }
}
