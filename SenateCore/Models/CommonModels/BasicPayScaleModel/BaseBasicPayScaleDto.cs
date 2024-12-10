using System.ComponentModel.DataAnnotations;

namespace SenateCore.Models.CommonModels.BasicPayScaleModel
{
    public class BaseBasicPayScaleDto
    {
        [Required]
        [StringLength(50, ErrorMessage = "Description cannot be longer than 50 characters.")]
        public string Description { get; set; }
        public bool IsActive { get; set; }
       
    }
}
