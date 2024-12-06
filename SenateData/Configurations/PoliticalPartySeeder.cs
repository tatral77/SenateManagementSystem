using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class PoliticalPartySeeder: IEntityTypeConfiguration<PoliticalParty>
    {
    
        public void Configure(EntityTypeBuilder<PoliticalParty> builder)
        {
            builder.HasData(
                );
        }
    }
}
