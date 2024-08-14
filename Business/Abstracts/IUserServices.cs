using Contracts.Dtos;
using Contracts.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserContract;

namespace Business.Abstracts
{
    public interface IUserServices
    {
        Task<CreateAddUserResponse> CreateUserAsync(User user);
        Task<List<CreateAddUserResponse>> GetAllUsersAsync();

    }

}
