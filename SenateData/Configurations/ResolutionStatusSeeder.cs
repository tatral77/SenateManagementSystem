using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateData.Configurations
{
    public class ResolutionStatusSeeder
    {
        public void Configure(EntityTypeBuilder<ResolutionStatus> builder)
        {
            builder.HasData(
                new ResolutionStatus { Id = 1, Description = "Allowed", IsActive = true, },
                new ResolutionStatus { Id = 2, Description = "Disallowed", IsActive = true, },
                new ResolutionStatus { Id = 3, Description = "Withdraw", IsActive = true, },
                new ResolutionStatus { Id = 4, Description = "Admitted", IsActive = true, },
                new ResolutionStatus { Id = 5, Description = "Under Process", IsActive = true, },
                new ResolutionStatus { Id = 6, Description = "Admitted and Selected in Balloting", IsActive = true, },
                new ResolutionStatus { Id = 7, Description = "Dropped by the House", IsActive = true, },
                new ResolutionStatus { Id = 8, Description = "Admitted but Lapsed", IsActive = true, },
                new ResolutionStatus { Id = 9, Description = "Included in the order of day", IsActive = true, },
                new ResolutionStatus { Id = 10, Description = "Passed by the House", IsActive = true, },
                new ResolutionStatus { Id = 11, Description = "Passed As Amended", IsActive = true, },
                new ResolutionStatus { Id = 12, Description = "Withdrawn by the Member", IsActive = true, },
                new ResolutionStatus { Id = 13, Description = "Rejected by the House", IsActive = true, },
                new ResolutionStatus { Id = 14, Description = "Passed Unanimously", IsActive = true, },
                new ResolutionStatus { Id = 15, Description = "Under Correspondence", IsActive = true, },
                new ResolutionStatus { Id = 16, Description = "Moved and Pending for Discussion", IsActive = true, },
                new ResolutionStatus { Id = 17, Description = "Lapsed", IsActive = true, },
                new ResolutionStatus { Id = 18, Description = "Deferred", IsActive = true, },
                new ResolutionStatus { Id = 19, Description = "Refered to Standing Committee", IsActive = true, },
                new ResolutionStatus { Id = 20, Description = "Move To Session", IsActive = false, },
                new ResolutionStatus { Id = 21, Description = "Move in the House", IsActive = true, },
                new ResolutionStatus { Id = 22, Description = "Pending for further discussion", IsActive = true, },
                new ResolutionStatus { Id = 23, Description = "NFA", IsActive = true, },
                new ResolutionStatus { Id = 24, Description = "Admitted as Call Attention Notice", IsActive = true, },
                new ResolutionStatus { Id = 25, Description = "Transfered to Motion Branch", IsActive = true, },
                new ResolutionStatus { Id = 26, Description = "Transfered to Legislation Branch", IsActive = true, }

                );
        }
    }
}
