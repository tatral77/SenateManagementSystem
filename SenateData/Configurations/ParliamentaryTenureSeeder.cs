using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class ParliamentaryTenureSeeder: IEntityTypeConfiguration<ParliamentaryTenure>
    {
        public void Configure(EntityTypeBuilder<ParliamentaryTenure> builder)
        {
            builder.HasData(
                );
        }
    }
}
