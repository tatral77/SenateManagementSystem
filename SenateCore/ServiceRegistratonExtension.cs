using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SenateCore.Contracts;
using SenateCore.Contracts.Common;
using SenateCore.Repository;
using SenateCore.Repository.Common;
using SenateData.DataModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateCore
{
    public static class ServiceRegistratonExtension
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            string connectionString = "Data Source=172.16.15.8;packet size=4096;user id=sa;pwd=X#Bv7_4qT!Ma;Trusted_Connection=False;TrustServerCertificate=True;initial catalog=TravellingAPI";
            services.AddDbContext<SenateDBContext>(options => options.UseSqlServer(connectionString));
            #region Contracts
            services.AddScoped(typeof(IGenericRepo<>), typeof(GenericRepo<>));
            services.AddScoped<IBasicPayScaleRepo, BasicPayScaleRepo>();
            return services;
        }

        #endregion
    }
}
