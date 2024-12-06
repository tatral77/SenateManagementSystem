using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class PassportTypeSeeder: IEntityTypeConfiguration<PassportType>
    {
    
        public void Configure(EntityTypeBuilder<PassportType> builder)
        {
            builder.HasData(
                );
        }
    }
}
