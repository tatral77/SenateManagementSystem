using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class EmployeePoolSeeder: IEntityTypeConfiguration<EmployeePool>
    {
        public void Configure(EntityTypeBuilder<EmployeePool> builder)
        {
            builder.HasData(
                );
        }
    }
}
