using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K12WebApp.Shared.DTOs.UserDTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public int RoomNo { get; set; }
        public string FirstName { get; set; }
        public List<ChoreMonth> Chores { get; set; }

    }
}
