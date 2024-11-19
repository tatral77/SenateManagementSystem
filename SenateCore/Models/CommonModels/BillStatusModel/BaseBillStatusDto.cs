using SenateData.DataModels.Legislation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateCore.Models.CommonModels.BillStatusModel
{
    public class BaseBillStatusDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public IList<BillDto> Bills { get; set; }
    }
}
