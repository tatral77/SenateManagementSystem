namespace SenateCore.Models.CommonModels.CourseTypeModel
{
    public class CourseTypeDto: BaseCourseTypeDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
