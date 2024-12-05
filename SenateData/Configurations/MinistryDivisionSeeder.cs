using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class MinistryDivisionSeeder: IEntityTypeConfiguration<MinistryDivision>
    {
        public void Configure(EntityTypeBuilder<MinistryDivision> builder)
        {
            builder.HasData(
                );
        }
    }
}
