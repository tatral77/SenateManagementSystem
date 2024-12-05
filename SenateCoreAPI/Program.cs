using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using SenateCore.Configurations;
using SenateCore.Contracts;
using SenateCore.Contracts.Common;
using SenateCore.Middleware;
using SenateCore.Repository;
using SenateCore.Repository.Common;
using SenateData.DataModels;
using SenateData.DataModels.Auth;
using SenateData.DataModels.Common;
using Serilog;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
#region DB CONTEXT
var connectionString = builder.Configuration.GetConnectionString("SenateDbConnectionString");
builder.Services.AddDbContext<SenateDBContext>(options => options.UseSqlServer(connectionString));
#endregion

#region IDENTITY
builder.Services.AddIdentityCore<APIUser>()
    .AddRoles<IdentityRole>()
    .AddTokenProvider<DataProtectorTokenProvider<APIUser>>("TravellingApi")
    .AddEntityFrameworkStores<SenateDBContext>()
    .AddDefaultTokenProviders();
#endregion

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

#region Swagger
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "Hotel Listing API", Version = "v1" });
    options.AddSecurityDefinition(JwtBearerDefaults.AuthenticationScheme, new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header using the Bearer scheme. 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      Example: 'Bearer 12345abcdef'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = JwtBearerDefaults.AuthenticationScheme
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference {
                                Type = ReferenceType.SecurityScheme,
                                Id = JwtBearerDefaults.AuthenticationScheme
                            },
                Scheme = "0auth2",
                Name = JwtBearerDefaults.AuthenticationScheme,
                In = ParameterLocation.Header
            },
            new List<string>()
        }
    });
});

#endregion

#region CORS
builder.Services.AddCors(options =>
options.AddPolicy("AllowAll",
    b => b.AllowAnyHeader().
        AllowAnyOrigin().
        AllowAnyMethod())
);
#endregion

#region VERSIONING
//builder.Services.AddApiVersioning(options =>
//{
//    options.AssumeDefaultVersionWhenUnspecified = true;
//    options.DefaultApiVersion = new Asp.Versioning.ApiVersion(1, 0);
//    options.ReportApiVersions = true;
//    options.ApiVersionReader = ApiVersionReader.Combine(
//         new QueryStringApiVersionReader("api-version"),
//         new HeaderApiVersionReader("X-Version"),
//         new MediaTypeApiVersionReader("ver")
//    );
//}).AddApiExplorer(
//    options =>
//    {
//        options.GroupNameFormat = "'v'VVV";
//        options.SubstituteApiVersionInUrl = true;
//    });
#endregion


#region SERLOG
builder.Host.UseSerilog((context, loggerConfiguration) =>
    loggerConfiguration.WriteTo.Console()
                       .ReadFrom.Configuration(context.Configuration));
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

// Add services to the container.

#region JWT
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero,
        ValidIssuer = builder.Configuration["JWTSettings:Issuer"],
        ValidAudience = builder.Configuration["JWTSettings:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWTSettings:Key"]))
    };
});
builder.Services.AddResponseCaching(options =>
{
    options.MaximumBodySize = 1024;
    options.UseCaseSensitivePaths = true;
});

#endregion
builder.Services.AddControllers().AddOData(options =>
{
    options.Select().Filter().OrderBy();
});
var app = builder.Build();
app.UseStaticFiles();
// Configure the HTTP request pipeline.

app.UseSwagger();
if (app.Environment.IsProduction())
{
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        c.RoutePrefix = string.Empty; // To serve the Swagger UI at the app's root
    });
}
else
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwaggerUI();
    }
}

app.UseSerilogRequestLogging();

app.UseMiddleware<ExceptionMiddleware>();

app.UseHttpsRedirection();

app.UseCors("AllowAll");
#region CACHING
app.UseResponseCaching();

app.Use(async (context, next) =>
{
    context.Response.GetTypedHeaders().CacheControl =
        new Microsoft.Net.Http.Headers.CacheControlHeaderValue()
        {
            Public = true,
            MaxAge = TimeSpan.FromSeconds(10)
        };
    context.Response.Headers[Microsoft.Net.Http.Headers.HeaderNames.Vary] =
        new string[] { "Accept-Encoding" };

    await next();
});
#endregion

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
