using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SenateData.DataModels.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateData.DataModels
{
    public class SenateDBContext : IdentityDbContext<APIUser>
    {
        public readonly IEnumerable<object> VehicleMaintenanceType;

        public SenateDBContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            {
            }
        }
    }
}
