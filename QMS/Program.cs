using Microsoft.EntityFrameworkCore;
using SenateCore.Configurations;
using SenateCore.Contracts;
using SenateCore.Contracts.Common;
using SenateCore.Repository;
using SenateCore.Repository.Common;
using SenateData.DataModels;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpClient();
builder.Services.AddControllersWithViews();
#region DB CONTEXT
var connectionString = builder.Configuration.GetConnectionString("SenateDbConnectionString");
builder.Services.AddDbContext<SenateDBContext>(options => options.UseSqlServer(connectionString));
#endregion

builder.Services.AddAutoMapper(typeof(MapperConfig));

#region Contracts

builder.Services.AddScoped(typeof(IGenericRepo<>), typeof(GenericRepo<>));
builder.Services.AddScoped<IBasicPayScaleRepo, BasicPayScaleRepo>();
builder.Services.AddScoped<IBillOriginRepo, BillOriginRepo>();
builder.Services.AddScoped<IBillStatusRepo, BillStatusRepo>();
builder.Services.AddScoped<IBillTypeRepo, BillTypeRepo>();
builder.Services.AddScoped<IBranchRepo, BranchRepo>();
builder.Services.AddScoped<ICityRepo, CityRepo>();
builder.Services.AddScoped<IConstituencyRepo, ConstituencyRepo>();
builder.Services.AddScoped<IContractTypeRepo, ContractTypeRepo>();
builder.Services.AddScoped<ICountryRepo, CountryRepo>();
builder.Services.AddScoped<ICourseTypeRepo, CourseTypeRepo>();
builder.Services.AddScoped<IDistrictRepo, DistrictRepo>();
builder.Services.AddScoped<IDivisionRepo, DivisionRepo>();
builder.Services.AddScoped<IEducationLevelRepo, EducationLevelRepo>();
builder.Services.AddScoped<IElectionTypeRepo, ElectionTypeRepo>();
builder.Services.AddScoped<IGenderRepo, GenderRepo>();
builder.Services.AddScoped<IHouseAffiliationRepo, HouseAffiliationRepo>();
builder.Services.AddScoped<IMaritalStatusRepo, MaritalStatusRepo>();
builder.Services.AddScoped<IMemberStatusRepo, MemberStatusRepo>();
builder.Services.AddScoped<IMinistryRepo, MinistryRepo>();
builder.Services.AddScoped<IMotionStatusRepo, MotionStatusRepo>();
builder.Services.AddScoped<IMotionTypeRepo, MotionTypeRepo>();
builder.Services.AddScoped<INOCTypeRepo, NOCTypeRepo>();
builder.Services.AddScoped<IParliamentarySessionRepo, ParliamentarySessionRepo>();
builder.Services.AddScoped<IParliamentarySessionSittingRepo, ParliamentarySessionSittingRepo>();
builder.Services.AddScoped<IParliamentaryTenureRepo, ParliamentaryTenureRepo>();
builder.Services.AddScoped<IParliamentaryTermRepo, ParliamentaryTermRepo>();
builder.Services.AddScoped<IParliamentaryYearRepo, ParliamentaryYearRepo>();
builder.Services.AddScoped<IPartyDesignationRepo, PartyDesignationRepo>();
builder.Services.AddScoped<IPassportTypeRepo, PassportTypeRepo>();
builder.Services.AddScoped<IPenaltyTypeRepo, PenaltyTypeRepo>();
builder.Services.AddScoped<IPhoneTypeRepo, PhoneTypeRepo>();
builder.Services.AddScoped<IPoliticalPartyRepo, PoliticalPartyRepo>();
builder.Services.AddScoped<IPostRepo, PostRepo>();
//builder.Services.AddScoped<IPostSubTypeRepo, PostSubType>();
builder.Services.AddScoped<IPostStatusRepo, PostStatusRepo>();
builder.Services.AddScoped<IPostTypeRepo, PostTypeRepo>();
builder.Services.AddScoped<IProbationTypeRepo, ProbationTypeRepo>();
builder.Services.AddScoped<IProvinceRepo, ProvinceRepo>();
builder.Services.AddScoped<IRelationRepo, RelationRepo>();
builder.Services.AddScoped<IReligionRepo, ReligionRepo>();
builder.Services.AddScoped<IResolutionStatusRepo, ResolutionStatusRepo>();
builder.Services.AddScoped<IResolutionTypeRepo, ResolutionTypeRepo>();
builder.Services.AddScoped<ISeatTypeRepo, SeatTypeRepo>();
builder.Services.AddScoped<ISenateUserRepo, SenateUserRepo>();
builder.Services.AddScoped<ISittingTypeRepo, SittingTypeRepo>();
builder.Services.AddScoped<IVisitTypeRepo, VisitTypeRepo>();

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
