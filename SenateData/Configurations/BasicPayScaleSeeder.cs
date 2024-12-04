using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SenateData.DataModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateData.Configurations
{
    public class BasicPayScaleSeeder : IEntityTypeConfiguration<BasicPayScale>
    {
        public void Configure(EntityTypeBuilder<BasicPayScale> builder)
        {
            builder.HasData(
              new BasicPayScale
              {
                  Id = 1,
                  Description = "BS-1",
                  IsActive = true
              },
               new BasicPayScale
               {
                   Id = 2,
                   Description = "BS-1",
                   IsActive = true
               },
                new BasicPayScale
                {
                    Id = 3,
                    Description = "BS-3",
                    IsActive = true
                }
           );
        }
    }
}
