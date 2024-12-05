using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class NOCTypeSeeder: IEntityTypeConfiguration<NOCType>
    {
        public void Configure(EntityTypeBuilder<NOCType> builder)
        {
            builder.HasData(
                );
        }
    }
}
