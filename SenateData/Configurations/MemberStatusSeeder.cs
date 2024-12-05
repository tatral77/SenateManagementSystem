using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class MemberStatusSeeder: IEntityTypeConfiguration<MemberStatus>
    {
        public void Configure(EntityTypeBuilder<MemberStatus> builder)
        {
            builder.HasData(
                );
        }
    }
}
