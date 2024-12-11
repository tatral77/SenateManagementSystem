using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateData.DataModels.Ministries
{
    public class DivisionDepartment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200,ErrorMessage ="Division Name must not exceed 200 characters")]
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
