using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.Common;
namespace SenateData.Configurations
{
    public class PenaltyTypeSeeder: IEntityTypeConfiguration<PenaltyType>
    {
    
        public void Configure(EntityTypeBuilder<PenaltyType> builder)
        {
            builder.HasData(
                );
        }
    }
}
