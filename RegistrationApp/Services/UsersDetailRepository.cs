using RegistrationApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistrationApp.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace RegistrationApp.Services
{
    public class UsersDetailRepository : IUsersDetailRepository
    {
        private readonly RegistrationContext _context;

        public UsersDetailRepository(RegistrationContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void AddUser(UsersDetail user)
        {
            _context.UsersDetails.Add(user);
        }

        public async Task<UsersDetail> GetUserDetailsbyId(int userID)
        {
            return await _context.UsersDetails
                    .Where(c => c.UserID == userID).FirstOrDefaultAsync();
        }

        public IEnumerable<UsersDetail> GetUserDetails()
        {
            return _context.UsersDetails.OrderBy(c => c.FirstName).ToList();
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public int GetClientIDbyCode(string code)
        {
            return _context.Clients
                    .Where(c => c.ClientCode == code).Select(i => i.ClientId).SingleOrDefault();
        }
    }
}
