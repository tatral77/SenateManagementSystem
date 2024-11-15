using SenateData.DataModels.Common;
using SenateData.DataModels.Legislation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateData.DataModels.HRM
{
    public class Employee:SenateUser
    {
        public string PersonalNumber { get; set; }
        public string FileNumber { get; set; }
        public DateTime GovtServiceStartDate { get; set; }
        public DateTime SenateServiceStartDate { get; set; }

        [ForeignKey(nameof(CurrentPostId))]
        public int CurrentPostId { get; set; }

        [ForeignKey(nameof(CurrentBPSId))]
        public int CurrentBPSId { get; set; }
        public int CurrentEmploymentStatusId { get; set; }
        public int QuotaId { get; set; }
        public int MainHeadId { get; set; }
        public IList<BillStatusHistory> BillStatusHistories { get; set; }
        public Post Post { get; set; }
    }
}
