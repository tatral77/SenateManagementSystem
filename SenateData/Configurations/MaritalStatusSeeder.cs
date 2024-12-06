using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class MaritalStatusSeeder: IEntityTypeConfiguration<MaritalStatus>
    {
        public void Configure(EntityTypeBuilder<MaritalStatus> builder)
        {
            builder.HasData(
                new MaritalStatus { Id = 1, Description = "Married", IsActive = true, },
                new MaritalStatus { Id = 2, Description = "Single", IsActive = true, },
                new MaritalStatus { Id = 3, Description = "Divorced", IsActive = true, },
                new MaritalStatus { Id = 4, Description = "Widowed", IsActive = true, },
                new MaritalStatus { Id = 5, Description = "Separated", IsActive = true, },
                new MaritalStatus { Id = 6, Description = "Other", IsActive = true, }
                );
        }
    }
}
