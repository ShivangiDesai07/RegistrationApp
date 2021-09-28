using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistrationApp.Entities;

namespace RegistrationApp.Services
{
    public interface IUsersDetailRepository
    {
        void AddUser(UsersDetail user);
        IEnumerable<UsersDetail> GetUserDetails();
        Task<UsersDetail> GetUserDetailsbyId(int userID);
        bool Save();

        int GetClientIDbyCode(string code);

    }
}
