using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenateData.DataModels.Common;
namespace SenateData.Configurations
{
    public class MotionStatusSeeder: IEntityTypeConfiguration<MotionStatus>
    {
        public void Configure(EntityTypeBuilder<MotionStatus> builder)
        {
            builder.HasData(
                new MotionStatus { Id = 1, Description = "Referred to Standing Committee", IsActive = true, },
new MotionStatus { Id = 2, Description = "Ruled out of Order", IsActive = true, },
new MotionStatus { Id = 3, Description = "Withdrawn in the House", IsActive = true, },
new MotionStatus { Id = 4, Description = "Withdrawn at Secretariat Level", IsActive = true, },
new MotionStatus { Id = 5, Description = "Under Process", IsActive = true, },
new MotionStatus { Id = 6, Description = "Allowed", IsActive = true, },
new MotionStatus { Id = 7, Description = "Disposed Off", IsActive = true, },
new MotionStatus { Id = 8, Description = "Admitted for 2 Hr. Discussion", IsActive = true, },
new MotionStatus { Id = 9, Description = "Disallowed in Chamber", IsActive = true, },
new MotionStatus { Id = 10, Description = "Ruled out of Order in the house", IsActive = true, },
new MotionStatus { Id = 11, Description = "Moved in the house without notice", IsActive = true, },
new MotionStatus { Id = 12, Description = "Lapsed", IsActive = true, },
new MotionStatus { Id = 14, Description = "Not Pressed", IsActive = true, },
new MotionStatus { Id = 15, Description = "Ruling Reserved", IsActive = true, },
new MotionStatus { Id = 16, Description = "Referred to Spl Cmt", IsActive = true, },
new MotionStatus { Id = 17, Description = "Referred to Priv Cmt.", IsActive = true, },
new MotionStatus { Id = 18, Description = "Infructuous", IsActive = true, },
new MotionStatus { Id = 19, Description = "Moved and Deferred", IsActive = true, },
new MotionStatus { Id = 20, Description = "Admitted", IsActive = true, },
new MotionStatus { Id = 21, Description = "Disallowed", IsActive = true, },
new MotionStatus { Id = 22, Description = "Discuss in the House", IsActive = true, },
new MotionStatus { Id = 23, Description = "Withdrawn by the Member", IsActive = true, },
new MotionStatus { Id = 24, Description = "Droped by the House", IsActive = true, },
new MotionStatus { Id = 25, Description = "Under-Correspondence", IsActive = true, },
new MotionStatus { Id = 26, Description = "Admitted but Lapsed", IsActive = true, },
new MotionStatus { Id = 27, Description = "Deferred", IsActive = true, },
new MotionStatus { Id = 28, Description = "Dropped", IsActive = true, },
new MotionStatus { Id = 29, Description = "Discussed", IsActive = true, },
new MotionStatus { Id = 30, Description = "Move To Session", IsActive = true, },
new MotionStatus { Id = 31, Description = "To be heard but Lapsed", IsActive = true, },
new MotionStatus { Id = 32, Description = "Referred to Special Committee", IsActive = true, },
new MotionStatus { Id = 33, Description = "Moved in the House", IsActive = true, },
new MotionStatus { Id = 34, Description = "Selected/Not Sel. for Statement", IsActive = true, },
new MotionStatus { Id = 36, Description = "Notice Received for 2nd Time", IsActive = true, },
new MotionStatus { Id = 37, Description = "Referred to the Privileges Committee", IsActive = true, },
new MotionStatus { Id = 38, Description = "Moved and is Pending for Discussion", IsActive = true, },
new MotionStatus { Id = 39, Description = "To be heard", IsActive = true, },
new MotionStatus { Id = 40, Description = "Admissibility not Allowed by the House", IsActive = true, },
new MotionStatus { Id = 41, Description = "Talked Out", IsActive = true, },
new MotionStatus { Id = 42, Description = "Held in Order", IsActive = true, },
new MotionStatus { Id = 43, Description = "Held out of Order", IsActive = true, },
new MotionStatus { Id = 44, Description = "Approved", IsActive = true, }

                );
        }
    }
}
