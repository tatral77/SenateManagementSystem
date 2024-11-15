using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SenateData.DataModels.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateData.DataModels.Legislation
{
    public class Bill
    {
        public int Id { get; set; }

        [ForeignKey(nameof(BillStatusId))]
        public int BillStatusId { get; set; }

        [ForeignKey(nameof(BillTypeId))]
        public int BillTypeId { get; set; }

        [ForeignKey(nameof(BillOriginId))]
        public int BillOriginId { get; set; }

        public int ParliamentarySessionId { get; set; }
        public int MemberId { get; set; }

        public BillStatus BillStatus { get; set; }
        public BillType BillType { get; set; }
        public BillOrigin BillOrigin{ get; set; }
        public IList<BillDocument> BillDocuments { get; set; }
    }
}
