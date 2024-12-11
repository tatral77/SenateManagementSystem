using SenateCore.Models.CommonModels.MinistryModel;
using SenateCore.Models.CommonModels.ParliamentarySessionModel;
using SenateCore.Models.CommonModels.SenateUserModel;
using SenateCore.Models.CommonModels.TranslationTypeModel;
using SenateData.DataModels.Common;
using SenateData.DataModels.Translation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateCore.Models.QuestionModels.Question
{
    public class QuestionDto
    {
        public int Id { get; set; }
        public SenateUserDto InsertedBy { get; set; }

        public SenateUserDto UpdatedBy { get; set; }

        public SenateUserDto DeletedBy { get; set; }

        public SenateUserDto RecoveredBy { get; set; }

        public SenateUserDto SentForTranslationBy { get; set; }

        public SenateUserDto TranslatedBy { get; set; }

        public SenateUserDto AssignedForTranslationTo { get; set; }

        public SenateUserDto TranslationApprovedBy { get; set; }

        public MinistryDto Ministry { get; set; }
        public TranslationTypeDto TranslationType { get; set; }
        public ParliamentarySessionDto ParliamentarySession { get; set; }
    }
}
