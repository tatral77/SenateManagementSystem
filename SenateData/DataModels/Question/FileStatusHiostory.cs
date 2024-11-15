using System;

namespace SenateData.DataModels.Question
{
    public class FileStatusHiostory

    {
        public int Id { get; set; }
        public int QuestionsId { get; set; }
        public int FileStatusId { get; set; }
        public string FileStatus { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateTime StatusHistoryDate { get; set; }

    }
}
