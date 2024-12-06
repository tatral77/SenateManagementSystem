using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class ParliamentaryTermSeeder: IEntityTypeConfiguration<ParliamentaryTerm>
    {
        public void Configure(EntityTypeBuilder<ParliamentaryTerm> builder)
        {
            builder.HasData(
                );
        }
    }
}
