using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class ElectionTypeSeeder: IEntityTypeConfiguration<ElectionType>
    {
        public void Configure(EntityTypeBuilder<ElectionType> builder)
        {
            builder.HasData(
                );
        }
    }
}
