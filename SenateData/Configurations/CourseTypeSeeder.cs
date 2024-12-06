using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class CourseTypeSeeder: IEntityTypeConfiguration<CourseType>
    {
        public void Configure(EntityTypeBuilder<CourseType> builder)
        {
            builder.HasData(
                new CourseType { Id = 1, Description = "Local", IsActive = true, },
                new CourseType { Id = 2, Description = "Foreign", IsActive = true, }
                );
        }
    }
}
