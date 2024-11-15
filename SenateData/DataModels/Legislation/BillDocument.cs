using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateData.DataModels.Legislation
{
    public class BillDocument
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public string Description { get; set; }
        public DateTime DocumentDate { get; set; }
        public string DocumentUrl { get; set; }
        public Bill Bill { get; set; }
    }
}
