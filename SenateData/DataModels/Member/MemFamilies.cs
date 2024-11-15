namespace SenateData.DataModels.Member

{
    public class MemFamilies
    {
        public int Id { get; set; }
        public int MemberFamiliesId { get; set; }
        public int SystemUsersId { get; set; }
        public string FamilyMemberName { get; set; }
        public int RelationShipsId { get; set; }
        public int OccupationsId { get; set; }
        public int IsDependent { get; set; }
        public string OtherInfo { get; set; }
        public int NICNumber { get; set; }
        public DateTime NICDate { get; set; }
        public int NICPlace { get; set; }
        public string Qualification { get; set; }
        public int PassportNumber { get; set; }
        public DateTime PassportDate { get; set; }
        public DateTime PassportExpDate { get; set; }
        public string FamilyName { get; set; }
        public string FirstName { get; set; }
        public DateTime DOB { get; set; }
        public string PlaceOfBirth { get; set; }
        public string ResidenceCity { get; set; }
        public string ResidenceCountry { get; set; }


    }
}
