using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SenateData.DataModels.Common;

namespace APIData.Data.Configurations
{
    internal class GenderConf : IEntityTypeConfiguration<Gender>
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
