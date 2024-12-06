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
                new PhoneType { Id = 1, Description = "Residence", IsActive = true, },
                new PhoneType { Id = 2, Description = "Office", IsActive = true, },
                new PhoneType { Id = 3, Description = "Mobile", IsActive = true, },
                new PhoneType { Id = 4, Description = "Fax", IsActive = true, }
                );
        }
    }
}
