using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class ParliamentaryYearSeeder: IEntityTypeConfiguration<ParliamentaryYear>
    {
        public void Configure(EntityTypeBuilder<ParliamentaryYear> builder)
        {
            builder.HasData(
                );
        }
    }
}
