using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class ParliamentarySessionSittingSeeder : IEntityTypeConfiguration<ParliamentarySessionSitting>
    {
        public void Configure(EntityTypeBuilder<ParliamentarySessionSitting> builder)
        {
            builder.HasData(
                );
        }
    }
}
