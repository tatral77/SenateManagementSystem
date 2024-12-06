using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class ParliamentaryTenureSeeder: IEntityTypeConfiguration<ParliamentaryTenure>
    {
        public void Configure(EntityTypeBuilder<ParliamentaryTenure> builder)
        {
            builder.HasData(
            new ParliamentaryTenure { Id = 1, Tenure = "August 1973 to August 1975", StartDate = Convert.ToDateTime("1973-08-12 00:00:00"), EndDate = Convert.ToDateTime("1975-08-11 00:00:00"), IsActive = true, },
            new ParliamentaryTenure { Id = 2, Tenure = "August 1973 to August 1975", StartDate = Convert.ToDateTime("1975-08-13 00:00:00"), EndDate = Convert.ToDateTime("1977-08-12 00:00:00"), IsActive = true, },
            new ParliamentaryTenure { Id = 3, Tenure = "March 1985 to March 1988", StartDate = Convert.ToDateTime("1985-03-13 00:00:00"), EndDate = Convert.ToDateTime("1988-03-12 00:00:00"), IsActive = true, },
            new ParliamentaryTenure { Id = 4, Tenure = "March 1988 to March 1991", StartDate = Convert.ToDateTime("1988-03-13 00:00:00"), EndDate = Convert.ToDateTime("1991-03-12 00:00:00"), IsActive = true, },
            new ParliamentaryTenure { Id = 5, Tenure = "March 1991 to March 1994", StartDate = Convert.ToDateTime("1991-03-13 00:00:00"), EndDate = Convert.ToDateTime("1994-03-12 00:00:00"), IsActive = true, },
            new ParliamentaryTenure { Id = 6, Tenure = "March 1994 to March 1997", StartDate = Convert.ToDateTime("1994-03-13 00:00:00"), EndDate = Convert.ToDateTime("1997-03-12 00:00:00"), IsActive = true, },
            new ParliamentaryTenure { Id = 7, Tenure = "March 1997 to March 2000", StartDate = Convert.ToDateTime("1997-03-13 00:00:00"), EndDate = Convert.ToDateTime("2000-03-12 00:00:00"), IsActive = true, },
            new ParliamentaryTenure { Id = 8, Tenure = "March 2003 to March 2009", StartDate = Convert.ToDateTime("2003-03-13 00:00:00"), EndDate = Convert.ToDateTime("2009-03-12 00:00:00"), IsActive = true, },
            new ParliamentaryTenure { Id = 10, Tenure = "March 2006 to March 2012", StartDate = Convert.ToDateTime("2006-03-13 00:00:00"), EndDate = Convert.ToDateTime("2012-03-12 00:00:00"), IsActive = true, },
            new ParliamentaryTenure { Id = 11, Tenure = "March 2009 to March 2015", StartDate = Convert.ToDateTime("2009-03-13 00:00:00"), EndDate = Convert.ToDateTime("2015-03-12 00:00:00"), IsActive = true, },
            new ParliamentaryTenure { Id = 12, Tenure = "March 2012 to March 2018", StartDate = Convert.ToDateTime("2012-03-13 00:00:00"), EndDate = Convert.ToDateTime("2018-03-12 00:00:00"), IsActive = true, },
            new ParliamentaryTenure { Id = 13, Tenure = "March 2015 to March 2021", StartDate = Convert.ToDateTime("2015-03-13 00:00:00"), EndDate = Convert.ToDateTime("2021-03-12 00:00:00"), IsActive = true, },
            new ParliamentaryTenure { Id = 14, Tenure = "March 2018 to March 2024", StartDate = Convert.ToDateTime("2018-03-13 00:00:00"), EndDate = Convert.ToDateTime("2024-03-12 00:00:00"), IsActive = true, },
            new ParliamentaryTenure { Id = 15, Tenure = "March 2021 to March 2027", StartDate = Convert.ToDateTime("2021-03-13 00:00:00"), EndDate = Convert.ToDateTime("2027-03-12 00:00:00"), IsActive = true, },
            new ParliamentaryTenure { Id = 16, Tenure = "March 2024 to March 2030", StartDate = Convert.ToDateTime("2024-03-13 00:00:00"), EndDate = Convert.ToDateTime("2030-03-12 00:00:00"), IsActive = true, }
                );
        }
    }
}
