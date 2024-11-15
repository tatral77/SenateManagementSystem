using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstablishmentENT
{
    public class UserEmail
    {
        public int Id { get; set; }
        public int SenateUserId { get; set; }
        public string Email { get; set; }
        public int IsOfficial { get; set; }
        public int IsActive { get; set; }
    }
}
