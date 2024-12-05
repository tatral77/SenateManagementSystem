using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class BillTypeSeeder: IEntityTypeConfiguration<BillType>
    {
        public void Configure(EntityTypeBuilder<BillType> builder)
        {
            builder.HasData(
                );
        }
    }
}
