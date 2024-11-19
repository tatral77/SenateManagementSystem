using SenateData.DataModels.HRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateCore.Models.CommonModels.BranchModel
{
    public class BranchDto:BaseBranchDto
    {
        public int Id { get; set; }
        public IList<EmployeeDto> Employees { get; set; }
    }
}
