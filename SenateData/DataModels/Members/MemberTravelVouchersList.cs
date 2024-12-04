namespace SenateData.DataModels.Member

{
    public class MemberTravelVouchersList
    {
        public int MemberTravelVouchersListId { get; set; }
        public int MemberId { get; set; }
        public int FinancialYearId { get; set; }
        public int TravelVoucherSubTypeId { get; set; }
        public string TravelVoucherSubType { get; set; }
       // public FinancialYears FinancialYear { get; set; }
        public DateTime Fromdate { get; set; }
        public DateTime ToDate { get; set; }

    }
}
