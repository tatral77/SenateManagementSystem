using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class BasicPayScaleSeeder : IEntityTypeConfiguration<BasicPayScale>
    {
        public void Configure(EntityTypeBuilder<BasicPayScale> builder)
        {
            builder.HasData(
                    new BasicPayScale { Id = 1, Description = "BS-1", IsActive = true },
                    new BasicPayScale { Id = 2, Description = "BS-2", IsActive = true },
                    new BasicPayScale { Id = 3, Description = "BS-3", IsActive = true },
                    new BasicPayScale { Id = 4, Description = "BS-4", IsActive = true },
                    new BasicPayScale { Id = 5, Description = "BS-5", IsActive = true },
                    new BasicPayScale { Id = 6, Description = "BS-6", IsActive = true },
                    new BasicPayScale { Id = 7, Description = "BS-7", IsActive = true },
                    new BasicPayScale { Id = 8, Description = "BS-8", IsActive = true },
                    new BasicPayScale { Id = 9, Description = "BS-9", IsActive = true },
                    new BasicPayScale { Id = 10, Description = "BS-10", IsActive = true },
                    new BasicPayScale { Id = 11, Description = "BS-11", IsActive = true },
                    new BasicPayScale { Id = 12, Description = "BS-12", IsActive = true },
                    new BasicPayScale { Id = 13, Description = "BS-13", IsActive = true },
                    new BasicPayScale { Id = 14, Description = "BS-14", IsActive = true },
                    new BasicPayScale { Id = 15, Description = "BS-15", IsActive = true },
                    new BasicPayScale { Id = 16, Description = "BS-16", IsActive = true },
                    new BasicPayScale { Id = 17, Description = "BS-17", IsActive = true },
                    new BasicPayScale { Id = 18, Description = "BS-18", IsActive = true },
                    new BasicPayScale { Id = 19, Description = "BS-19", IsActive = true },
                    new BasicPayScale { Id = 20, Description = "BS-20", IsActive = true },
                    new BasicPayScale { Id = 21, Description = "BS-21", IsActive = true },
                    new BasicPayScale { Id = 22, Description = "BS-22", IsActive = true },
                    new BasicPayScale { Id = 23, Description = "Not Mentioned", IsActive = true }
           );
        }
    }
}
