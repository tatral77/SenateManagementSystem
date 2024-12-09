using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class PostSubTypeSeeder: IEntityTypeConfiguration<PostSubType>
    {
        public void Configure(EntityTypeBuilder<PostSubType> builder)
        {
            builder.HasData(
                );
        }
    }
}
