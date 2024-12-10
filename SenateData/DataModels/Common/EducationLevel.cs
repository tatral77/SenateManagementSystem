namespace SenateData.DataModels.Common
{
    public class EducationLevel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int SortOrder { get; set; }
    }
}
