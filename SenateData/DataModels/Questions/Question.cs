using SenateData.DataModels.Common;
using SenateData.DataModels.Ministries;
using SenateData.DataModels.Translation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenateData.DataModels.Questions
{
    public class Question
    {

        public int Id { get; set; }
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


        [ForeignKey(nameof(MinistryId))]
        public int MinistryId { get; set; }

        [ForeignKey(nameof(MinistryGroupId))]
        public int MinistryGroupId { get; set; }

        [ForeignKey(nameof(DivisionId))]
        public int DivisionId { get; set; }

        [ForeignKey(nameof(DepartmentsId))]
        public int DepartmentsId { get; set; }

        [ForeignKey(nameof(ParliamentarySessionId))]
        public int ParliamentarySessionId { get; set; }

        [ForeignKey(nameof(ParliamentarySessionSittingsId))]
        public int ParliamentarySessionSittingsId { get; set; }

        [ForeignKey(nameof(TranslationTypeId))]
        public int TranslationTypeId { get; set; }

        [ForeignKey(nameof(QuestionStatusId))]
        public int QuestionStatusId { get; set; }

        [ForeignKey(nameof(FileStatusId))]
        public int FileStatusId { get; set; }



        [ForeignKey(nameof(InsertedById))]
        public int InsertedById { get; set; }

        [ForeignKey(nameof(UpdatedById))]
        public int UpdatedById { get; set; }


        [ForeignKey(nameof(DeletedById))]
        public int DeletedById { get; set; }

        [ForeignKey(nameof(RecoveredById))]
        public int RecoveredById { get; set; }


        [ForeignKey(nameof(SentForTranslationById))]
        public int SentForTranslationById { get; set; }

        [ForeignKey(nameof(TranslatedById))]
        public int TranslatedById { get; set; }
       

        [ForeignKey(nameof(AssignedForTranslationToId))]
        public int AssignedForTranslationToId { get; set; }

        [ForeignKey(nameof(TranslationApprovedById))]
        public int TranslationApprovedById { get; set; }


        public SenateUser InsertedBy { get; set; }
       
        public SenateUser UpdatedBy { get; set; }

        public SenateUser DeletedBy { get; set; }

        public SenateUser RecoveredBy { get; set; }

        public SenateUser SentForTranslationBy { get; set; }

        public SenateUser TranslatedBy { get; set; }

        public SenateUser AssignedForTranslationTo { get; set; }

        public SenateUser TranslationApprovedBy { get; set; }




        [ForeignKey(nameof(ParliamentaryYearsId))]
        public int ParliamentaryYearsId { get; set; }

        [ForeignKey(nameof(MoverId))]
        public int MoverId { get; set; }

        [ForeignKey(nameof(QuestionCategoryId))]
        public int QuestionCategoryId { get; set; }

       
        public Ministry Ministry { get; set; }
        public TranslationType TranslationType { get; set; }
        public ParliamentarySession ParliamentarySession { get; set; }
    }
}
