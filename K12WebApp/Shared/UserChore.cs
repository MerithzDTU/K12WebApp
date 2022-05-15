using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace K12WebApp.Shared
{
    public class UserChore
    {
        public int AssignedRoomNo { get; set; }
        public User? AssignedUser { get; set; }
        public int ChoreMonthId { get; set; }
        public ChoreMonth? ChoreMonth { get; set; }
    }
}
