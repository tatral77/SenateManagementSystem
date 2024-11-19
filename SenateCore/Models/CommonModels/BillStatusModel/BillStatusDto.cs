using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateCore.Models.CommonModels.BillStatusModel
{
    public class BillStatusDto:BaseBillStatusDto
    {
        public int Id { get; set; }
        public IList<BillDto> Bills { get; set; }
    }
}
