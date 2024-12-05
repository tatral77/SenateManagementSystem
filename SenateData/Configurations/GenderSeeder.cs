using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SenateData.DataModels.Common;
namespace APIData.Data.Configurations
{
    public class GenderSeeder : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.HasData(
              new Gender
              {
                  Id = 1,
                  Description = "Male",
                  IsActive = true
              },
               new Gender
               {
                   Id = 2,
                   Description = "Female",
                   IsActive = true
               }

           );
        }
    }
    
    
}
