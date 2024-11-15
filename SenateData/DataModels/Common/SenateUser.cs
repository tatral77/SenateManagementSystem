namespace SenateData.DataModels.Common
{
    public class SenateUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public int ReligionId { get; set; }
        public Religion Religion { get; set; }
        public int MaritalStatusId { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int ProvinceId { get; set; }
        public Province Province { get; set; }
        public string CNIC { get; set; }
        public DateTime CNICIssuanceDate { get; set; }
        public DateTime CNICExpiryDate { get; set; }
        public bool IsEmployee { get; set; }
     
    
      
      

       

    }
}
