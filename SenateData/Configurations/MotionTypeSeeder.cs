using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class MotionTypeSeeder: IEntityTypeConfiguration<MotionType>
    {
        public void Configure(EntityTypeBuilder<MotionType> builder)
        {
            builder.HasData(
                new MotionType { Id = 1, Description = "Adjournment Motion", IsActive = true, },
                new MotionType { Id = 2, Description = "Call Attention Notice", IsActive = true, },
                new MotionType { Id = 4, Description = "Privilege Motion", IsActive = true, },
                new MotionType { Id = 5, Description = "Laying of Copy", IsActive = true, },
                new MotionType { Id = 6, Description = "Motion For Consideration/Discussion", IsActive = true, },
                new MotionType { Id = 7, Description = "Motion Under Rule 194", IsActive = true, },
                new MotionType { Id = 8, Description = "Motion Under Rule 218", IsActive = true, },
                new MotionType { Id = 9, Description = "Motion Under Rule 60", IsActive = true, }

                );
        }
    }
}
