using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class BillOriginSeeder: IEntityTypeConfiguration<BillOrigin>
    {
        public void Configure(EntityTypeBuilder<BillOrigin> builder)
        {
            builder.HasData(
                );
        }
    }
}
