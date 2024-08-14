//using Business.Abstracts;
//using Microsoft.AspNetCore.Mvc;
//using UserContract;

//namespace API.Controllers
//{
//    //https://localhost:7066
//    [Route("user")]
//    [ApiController]
//    public class UserController : Controller
//    {
//        private readonly IUserServices _userService;

//        public UserController(IUserServices userService)
//        {
//            _userService = userService;
//        }
//        [HttpPost]
//        public async Task<IActionResult> AddUserAsync(User user)
//        {
//            var users = await _userService.CreateUserAsync(user);
//            return Ok(users);
//        }


//    }
//}

using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Contracts.Requests;
using Contracts.Response;
using Contracts.Enums;
using Business.Abstracts;
using UserContract;
using Contracts.Response;

namespace API.Controllers
{
    [Route("user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userService;

        public UserController(IUserServices userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> AddUserAsync([FromBody] CreateAddUserRequest request)
        {
            
            var user = new User
            {
                Name = request.Name,
                SurName = request.SurName,
                IdCard = request.IdCard,
                Email = request.Email,
                UserType = DetermineUserType(request)
            };

            
            var createdUser = await _userService.CreateUserAsync(user);

            
            var response = new CreateAddUserResponse
            {
                Name = createdUser.Name,
                SurName = createdUser.SurName,
                IdCard = createdUser.IdCard,
                Email = createdUser.Email,
                UserType = createdUser.UserType
            };

            return Ok(response); 
        }

        private UserType DetermineUserType(CreateAddUserRequest request)
        {
            return request.UserType;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            var users = await _userService.GetAllUsersAsync();
            return Ok(users);
        }
    }
}

