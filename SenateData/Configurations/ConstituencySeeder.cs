using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class ConstituencySeeder: IEntityTypeConfiguration<Constituency>
    {
        public void Configure(EntityTypeBuilder<Constituency> builder)
        {
            builder.HasData(
                );
        }
    }
}
