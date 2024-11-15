﻿using System;

namespace SenateData.DataModels.Notice
{
    public class MemberSeat
    {
        public int SeatNumber { get; set; }
        public int SystemUsersId { get; set; }
        public string MemberEnglishName { get; set; }
        public string MemberUrduName { get; set; }
        public string SeatColour { get; set; }
        public bool IsActive { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}
