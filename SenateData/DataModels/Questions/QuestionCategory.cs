namespace SenateData.DataModels.Questions
{
    public class QuestionCategory
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public bool IsActive { get; set; }
        public virtual IList<Question> Questions { get; set; }
    }
}
