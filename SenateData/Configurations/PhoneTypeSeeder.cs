using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class PhoneTypeSeeder: IEntityTypeConfiguration<PhoneType>
    {
    
        public void Configure(EntityTypeBuilder<PhoneType> builder)
        {
            builder.HasData(
                );
        }
    }
}
