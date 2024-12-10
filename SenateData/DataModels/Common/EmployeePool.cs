using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SenateData.DataModels.Common
{
    [Table(nameof(EmployeePool), Schema = "HRM")]
    public class EmployeePool
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

    }
}
