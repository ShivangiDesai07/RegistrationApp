using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationApp.Models
{
    public class UsersDetailDto
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PersonalNumber { get; set; }
        public string FavoriteFootBallTeam { get; set; }
    }
}
