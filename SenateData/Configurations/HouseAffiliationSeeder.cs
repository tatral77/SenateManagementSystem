using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class HouseAffiliationSeeder: IEntityTypeConfiguration<HouseAffiliation>
    {
        public void Configure(EntityTypeBuilder<HouseAffiliation> builder)
        {
            builder.HasData(
                );
        }
    }
}
