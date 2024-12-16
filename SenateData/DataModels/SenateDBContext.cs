using EstablishmentENT;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SenateData.Common;
using SenateData.Configurations;
using SenateData.DataModels.Auth;
using SenateData.DataModels.Common;
using SenateData.DataModels.Ministries;
namespace SenateData.DataModels
{
    public class SenateDBContext : IdentityDbContext<ApplicationUser>
    {
        public SenateDBContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            {
            }
            #region Configurations
            modelBuilder.ApplyConfiguration(new BasicPayScaleSeeder());
            //modelBuilder.ApplyConfiguration(new BookingTypeConfiguration());
            //modelBuilder.ApplyConfiguration(new PaymentMethodConfiguration());
            //modelBuilder.ApplyConfiguration(new PaymentStatusConfiguration());
            //modelBuilder.ApplyConfiguration(new VehicleMakeConfiguration());
            //modelBuilder.ApplyConfiguration(new VehicleTypeConfiguration());
            //modelBuilder.ApplyConfiguration(new VehicleMaintenanceTypeConfiguration());
            //modelBuilder.ApplyConfiguration(new VehiclePeriodicalExpenseTypeConfiguration());
            #endregion
        }

        #region Common
        public DbSet<AttendanceStatus> AttendanceStatuses { get; set; }
        public DbSet<BasicPayScale> BasicPayScales { get; set; }
        public DbSet<BillStatus> BillStatuses { get; set; }
        public DbSet<BillType> BillTypes { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Constituency> Constituencies { get; set; }
        public DbSet<ContractType> ContractTypes { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CourseType> CourseTypes { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<MinistryDivision> Divisions { get; set; }
        public DbSet<EducationLevel> EducationLevels { get; set; }
        public DbSet<ElectionType> ElectionTypes { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<HouseAffiliation> HouseAffiliations { get; set; }
        public DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public DbSet<MemberStatus> MemberStatuses { get; set; }
        public DbSet<Ministry> Ministries { get; set; }
        public DbSet<MotionStatus> MotionStatuses { get; set; }
        public DbSet<MotionType> MotionTypes { get; set; }
        public DbSet<NOCType> NOCtypes { get; set; }
        public DbSet<ParliamentarySession> ParliamentarySessions { get; set; }
        public DbSet<ParliamentaryTenure> ParliamentaryTenures { get; set; }
        public DbSet<ParliamentaryTerm> ParliamentaryTerms { get; set; }
        public DbSet<ParliamentaryYear> ParliamentaryYears { get; set; }
        public DbSet<PartyDesignation> PartyDesignations { get; set; }
        public DbSet<PassportType> PassportTypes { get; set; }
        public DbSet<PenaltyType> PenaltyTypes { get; set; }
        public DbSet<PhoneType> PhoneTypes { get; set; }
        public DbSet<PoliticalParty> PoliticalParties { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostStatus> PostStatuses { get; set; }
        public DbSet<PostSubType> PostSubTypes { get; set; }
        public DbSet<PostType> postTypes { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<ProvinceDivision> ProvinceDivisions { get; set; }
        public DbSet<Relation> Relations { get; set; }
        public DbSet<Religion> Religions { get; set; }
        public DbSet<ResolutionStatus> ResolutionStatuses { get; set; }
        public DbSet<ResolutionType> ResolutionTypes { get; set; }
        public DbSet<SeatType> SeatTypes { get; set; }
        public DbSet<SenateUser> SenateUsers { get; set; }
        public DbSet<ParliamentarySessionSitting> SessionSittings { get; set; }
        public DbSet<SittingType> SittingTypes { get; set; }
        public DbSet<VisitType> VisitTypes { get; set; }
        #endregion  Common

        #region HRM

        #endregion

        #region Legislation

        #endregion

        #region Member

        #endregion

        #region Motion

        #endregion

        #region Notice

        #endregion

        #region Question

        #endregion

        #region Resolution

        #endregion

        #region Translation

        #endregion

    }
}
