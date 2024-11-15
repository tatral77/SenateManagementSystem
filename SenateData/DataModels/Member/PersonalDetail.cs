namespace SenateData.DataModels.Member

{
    public class PersonalDetail
    {
        public int SystemUsersId { get; set; }
        public int LoginId { get; set; }
        public string Password { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public string FatherHusbandName { get; set; }
        public DateTime DOB { get; set; }
        public int PlaceOfBirth { get; set; }
        public int CityOfBirth { get; set; }
        public int DomicileDistrict { get; set; }
        public int ReligionsId { get; set; }
        public string NICNumber { get; set; }
        public int NICPlace { get; set; }
        public DateTime NICDate { get; set; }
        public string NTN { get; set; }
        public int MaritalStatus { get; set; }
        public int Gender { get; set; }
        public string PermAddress { get; set; }
        public int PermCity { get; set; }
        public int PermProvince{ get; set; }
        public string Website { get; set; }
        public string LocalAddress { get; set; }
        public int LocalCityId { get; set; }
        public string LocalCity { get; set; }
        public string CorrespondenceAddress { get; set; }
        public int IsEmployee { get; set; }
        public int IsActive { get; set; }
        public int AssembliesId { get; set; }
        public string Title { get; set; }
        public string UrduName { get; set; }
        public string UrduMapping { get; set; }
        public string OldNICNo { get; set; }
        public DateTime LastUpdatedOn { get; set; }
        public int SeatTypesId { get; set; }
        public string MotherMDNName { get; set; }
        public string PictureId { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public int MemberId { get; set; }
        public string MemberName { get; set; }

        public int PoliticalPartyId { get; set; }
        public int MemberStatusId { get; set; }
        public int MemberTenureId { get; set; }

    }
}
