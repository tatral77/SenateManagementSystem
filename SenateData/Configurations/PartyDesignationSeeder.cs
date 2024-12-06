using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class PartyDesignationSeeder: IEntityTypeConfiguration<PartyDesignation>
    {
    
        public void Configure(EntityTypeBuilder<PartyDesignation> builder)
        {
            builder.HasData(
                );
        }
    }
}
