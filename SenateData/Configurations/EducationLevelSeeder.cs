using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class EducationLevelSeeder: IEntityTypeConfiguration<EducationLevel>
    {
        public void Configure(EntityTypeBuilder<EducationLevel> builder)
        {
            builder.HasData(
                        new EducationLevel { Id = 1, Description = "Non-Matriculation", IsActive = true, SortOrder = 8, },
                        new EducationLevel { Id = 2, Description = "Matriculation/O-Level", IsActive = true, SortOrder = 7, },
                        new EducationLevel { Id = 3, Description = "Intermediate/A-Level", IsActive = true, SortOrder = 6, },
                        new EducationLevel { Id = 4, Description = "Bachelor", IsActive = true, SortOrder = 5, },
                        new EducationLevel { Id = 5, Description = "Masters", IsActive = true, SortOrder = 4, },
                        new EducationLevel { Id = 6, Description = "M-Phil", IsActive = true, SortOrder = 3, },
                        new EducationLevel { Id = 7, Description = "Certificate", IsActive = true, SortOrder = 10, },
                        new EducationLevel { Id = 8, Description = "Diploma", IsActive = true, SortOrder = 9, },
                        new EducationLevel { Id = 9, Description = "M.S", IsActive = true, SortOrder = 2, },
                        new EducationLevel { Id = 10, Description = "P.hd", IsActive = true, SortOrder = 1, },
                        new EducationLevel { Id = 11, Description = "MBBS", IsActive = true, SortOrder = 3, },
                        new EducationLevel { Id = 12, Description = "Primary", IsActive = true, SortOrder = 8, },
                        new EducationLevel { Id = 13, Description = "Middle", IsActive = true, SortOrder = 8, }
                );
        }
    }
}
