﻿namespace SenateData.DataModels.Question
{
    public class GroupDivision
    {
        public int GroupDivisionsId { get; set; }
        public int GroupsId { get; set; }
        public string Group { get; set; }
        public int DivisionsId { get; set; }
        public string Division { get; set; }
        public int GroupSequence { get; set; }
        public int CorrespondingGroup { get; set; }
    }
}
