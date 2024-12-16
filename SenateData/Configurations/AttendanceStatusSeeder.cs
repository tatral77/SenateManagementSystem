using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class AttendanceStatusSeeder : IEntityTypeConfiguration<AttendanceStatus>
    {
        public void Configure(EntityTypeBuilder<AttendanceStatus> builder)
        {
            //builder.HasData(
            //    );
        }
    }
}
