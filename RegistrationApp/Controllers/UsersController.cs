using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistrationApp.Services;
using AutoMapper;
using RegistrationApp.Models;
using RegistrationApp.Cache;

namespace RegistrationApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersDetailRepository _usersDetailsRepository;
        private readonly IMapper _mapper;
        public UsersController(IUsersDetailRepository usersDetailsRepository,
            IMapper mapper)
        {
            _usersDetailsRepository = usersDetailsRepository ??
                throw new ArgumentNullException(nameof(usersDetailsRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("{userId}", Name = "GetUserDetailByID")]
        //[Cached(600)]
        public async Task<ActionResult<UsersDetailDto>> GetUserDetailsByID(int userId)
        {
            var user = await _usersDetailsRepository.GetUserDetailsbyId(userId);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<UsersDetailDto>(user));
        }

        [Route("UserDetails")]
        [HttpGet]
       // [Cached(600)]
        public ActionResult<IEnumerable<UsersDetailDto>> GetUserDetails()
        {
            var users = _usersDetailsRepository.GetUserDetails();

            if (users == null)
            {
                return NotFound();
            }
            //no user created.
            return Ok(_mapper.Map<IEnumerable<UsersDetailDto>>(users));
        }

        [Route("RegisterUser")]
        [HttpPost]
        public ActionResult<UsersDetailDto> RegisterUser(UsersDetailsForCreationDto user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            int clientId = _usersDetailsRepository.GetClientIDbyCode(user.ClientCode);
            if(clientId == 0)
            {
                return BadRequest("Invalid Client.");
            }    

            var userEntity = _mapper.Map<Entities.UsersDetail>(user);
            userEntity.ClientID = clientId;
            _usersDetailsRepository.AddUser(userEntity);
            _usersDetailsRepository.Save();

            var UserToReturn = _mapper.Map<UsersDetailDto>(userEntity);
            
            return CreatedAtRoute("GetUserDetailByID",
                new { userId = userEntity.UserID },
                UserToReturn);
        }
    }
}
