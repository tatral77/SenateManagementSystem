using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateCore.Models.CommonModels.BasicPayScaleModel
{
    public class BasicPayScaleDto: BaseBasicPayScaleDto
    {
        public int Id { get; set; }
        public IList<EmployeeDto> Employees { get; set; }
    }
}
