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
                );
        }
    }
}
