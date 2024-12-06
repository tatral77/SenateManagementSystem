using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateData.Configurations
{
    public class SenateUserSeeder
    {
        public void Configure(EntityTypeBuilder<SenateUser> builder)
        {
            builder.HasData(
                );
        }
    }
}
