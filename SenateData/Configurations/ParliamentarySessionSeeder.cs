using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class ParliamentarySessionSeeder: IEntityTypeConfiguration<ParliamentarySession>
    {
        public void Configure(EntityTypeBuilder<ParliamentarySession> builder)
        {
            builder.HasData(
                );
        }
    }
}
