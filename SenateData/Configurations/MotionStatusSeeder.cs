using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class MotionStatusSeeder: IEntityTypeConfiguration<MotionStatus>
    {
        public void Configure(EntityTypeBuilder<MotionStatus> builder)
        {
            builder.HasData(
                );
        }
    }
}
