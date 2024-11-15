﻿using System;

namespace SenateData.DataModels.Resolution
{
    public class Resolution
    {
        public int Id { get; set; }
        public int ResolutionNumber { get; set; }
        public string SessionNumber { get; set; }
        public int ResolutionTypesId { get; set; }
      //  public string ResType { get; set; }
        public DateTime SysDate { get; set; }
        public string ResolutionFile { get; set; }
        public int ParliamentaryYearId { get; set; }
        public DateTime SubmissionDate { get; set; }
        public DateTime SubmissionTime { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string UrduSubject { get; set; }
        public string UrduDescription { get; set; }
        public string EnglishSubject { get; set; }
        public string EnglishDescription { get; set; }
        public int RolesId { get; set; }
        public int ResolutionStatusId { get; set; }
        public string ResolutionStatus { get; set; }
        public int LastUpdatedBy { get; set; }
        public DateTime ResolutionStatusDate { get; set; }
        public int FileNo { get; set; }
        public string FileSubject { get; set; }
        public string RecordStatus { get; set; }
        public string RackNo { get; set; }
        public int AssemblySessionsId { get; set; }
        public int ResolutionsIdentifier { get; set; }
        public int IsLatestVer { get; set; }
        public int NoticeDiaryNo { get; set; }
        public DateTime NoticeDiaryDate { get; set; }
        public int ResolutionDiaryNo { get; set; }
        public DateTime ResolutionsDiaryDate { get; set; }
        public string Decisions { get; set; }
        public DateTime NoticeDiaryTime { get; set; }
        public DateTime ResolutionsDiaryTime { get; set; }
        public DateTime TotalTime { get; set; }
        public int YesVotes { get; set; }
        public int NoVotes { get; set; }
        public int NotVotes { get; set; }
        public int AbsentVotes { get; set; }
        public DateTime MovedDate { get; set; }
        public DateTime PassedDate { get; set; }
        public DateTime DiscussedDate { get; set; }
        public string Remarks { get; set; }
        public int IsSelBallot { get; set; }
        public string Letter { get; set; }
        public string Noting { get; set; }
        public bool IsSentToTranslation { get; set; }
        public string UrduText { get; set; }
        public int IsAdmitted { get; set; }
        public int PrevSessionId { get; set; }
        public int IsUrdu { get; set; }
        public DateTime SentForTranslationOn { get; set; }
        public DateTime ReturnedFromTranslationOn { get; set; }

    }
}
