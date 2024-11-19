using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateData.DataModels.Questions
{
    public class QuestionStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }
        public virtual IList<Question> Questions { get; set; }
    }
}
