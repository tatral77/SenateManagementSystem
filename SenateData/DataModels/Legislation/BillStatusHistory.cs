using SenateData.DataModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateData.DataModels.Legislation
{
    public class BillStatusHistory
    {
        public int Id { get; set; }
        public int BillStatusId { get; set; }
        public DateTime BillStatusDate { get; set; }
        public int ChangedBy { get; set; }
        public SenateUser SenateUser { get; set; }

    }
}
