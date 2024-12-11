using SenateData.DataModels.Common;
using SenateData.DataModels.Translation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateCore.Models.QuestionModels.Question
{
    public class BaseQuestionDto
    {
        public int QuestionListId { get; set; }
        public string SuplimentaryListNo { get; set; }
        public DateTime QuestionDate { get; set; }
        public string QuestionTime { get; set; }
        public string Subject { get; set; }
        public string QuestionText { get; set; }
        public int NoticeDiaryNo { get; set; }
        public DateTime NoticeDiaryDate { get; set; }
        public DateTime NoticeDiaryTime { get; set; }
        public int QuestionDiaryNo { get; set; }
        public int PreviousSessionNumber { get; set; }
        public DateTime QuestionStatusDate { get; set; }
        public string QuestionFile { get; set; }
        public bool IsActive { get; set; }
        public int IsLattestVer { get; set; }
        public string Reply { get; set; }
        public DateTime ReplyDate { get; set; }
        public string ReplyAttachment { get; set; }
        public int QuestionIdentifier { get; set; }
        public string UrduText { get; set; }
        public bool IsSentToTranslation { get; set; }
        public int PrevSessionId { get; set; }
        public string UnstarDescription { get; set; }
        public int GroupSequence { get; set; }
        public int Priority { get; set; }
        public bool Checked { get; set; }
        public DateTime SentForTranslationOn { get; set; }
        public DateTime ReturnedFromTranslationOn { get; set; }
        public DateTime TranslatedOn { get; set; }
        public int TranslationStatusId { get; set; }
        public DateTime UpdatedOn { get; set; }
        public DateTime InsertedOn { get; set; }
        public DateTime DeletedOn { get; set; }
        public DateTime RecoveredOn { get; set; }
        public DateTime TranslationApprovedOn { get; set; }
        public DateTime AssignedForTranslationOn { get; set; }


        public int MinistryId { get; set; }

        public int MinistryGroupId { get; set; }

        public int DivisionId { get; set; }

        public int DepartmentsId { get; set; }

        public int ParliamentarySessionId { get; set; }

        public int ParliamentarySessionSittingsId { get; set; }

        public int TranslationTypeId { get; set; }

        public int QuestionStatusId { get; set; }

        public int FileStatusId { get; set; }

        public int InsertedById { get; set; }
        public SenateUser InsertedBy { get; set; }
        public int UpdatedById { get; set; }
        public SenateUser UpdatedBy { get; set; }

        public int DeletedById { get; set; }
        public SenateUser DeletedBy { get; set; }

        public int RecoveredById { get; set; }
        public SenateUser RecoveredBy { get; set; }

        public int SentForTranslationById { get; set; }
        public SenateUser SentForTranslationBy { get; set; }

        public int TranslatedById { get; set; }
        public SenateUser TranslatedBy { get; set; }

        public int AssignedForTranslationToId { get; set; }
        public SenateUser AssignedForTranslationTo { get; set; }

        public int TranslationApprovedById { get; set; }
        public SenateUser TranslationApprovedBy { get; set; }




        public int ParliamentaryYearsId { get; set; }

        public int MoverId { get; set; }

        public int QuestionCategoryId { get; set; }

  

    
    }
}
