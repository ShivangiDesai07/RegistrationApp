using AutoMapper;
using NUnit.Framework;
using RegistrationApp.Controllers;
using RegistrationApp.Services;

namespace RegistrationApp.test
{
    public class Tests
    {
        private readonly IUsersDetailRepository _usersDetailsRepository;
        private readonly IMapper _mapper;

        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1)]
        [TestCase(2)]
        public void Task_GetUserDetailsID_OkResult(int userID, expectedOutput)
        {
            UsersController users = new UsersController(_usersDetailsRepository, _mapper);
            var i = users.GetUserDetailsByID(userID);
            Assert.AreEqual(name, result);
        }
    }
}