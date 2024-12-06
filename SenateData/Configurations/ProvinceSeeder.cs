using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateData.Configurations
{
    public class ProvinceSeeder
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder.HasData(
                );
        }
    }
}
