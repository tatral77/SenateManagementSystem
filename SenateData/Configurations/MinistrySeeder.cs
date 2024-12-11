using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Ministries;
namespace SenateData.Configurations
{
    public class MinistrySeeder: IEntityTypeConfiguration<Ministry>
    {
        public void Configure(EntityTypeBuilder<Ministry> builder)
        {
            builder.HasData(
                );
        }
    }
}
