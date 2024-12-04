using System.ComponentModel.DataAnnotations.Schema;

namespace SenateData.DataModels.Member

{
    public class TravelVouchersList
    {
        public int Id { get; set; }
        public int FinancialYearId { get; set; }
        //public FinancialYears FinancialYear { get; set; }
        public int Quantity { get; set; }
        public string StartSerialNumber { get; set; }
        public string EndSerialNumber { get; set; }
        
        [ForeignKey(nameof(TravelVoucherTypeId))]
        public int TravelVoucherTypeId { get; set; }
    }
}
