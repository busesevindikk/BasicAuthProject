using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstracts;
using Contracts.Dtos;
using Contracts.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using UserContract;

namespace Business.Concrete
{
    public class Services : IUserServices
    {
        // JsonSerializerSettings'in tanımlanması
        private static readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings
        {
            Converters = { new StringEnumConverter() } // Enum'ları string olarak dönüştürür
        };
        
        public Task<CreateAddUserResponse> CreateUserAsync(User user)
        {
            UserStorage.AddUser(user);
            var userResponse = new CreateAddUserResponse
            {
                Name = user.Name,
                SurName = user.SurName,
                Email = user.Email,
                IdCard = user.IdCard,
                UserType = user.UserType
            };

            //string json = JsonConvert.SerializeObject(userResponse, JsonSerializerSettings);

            //var result = JsonConvert.DeserializeObject<CreateAddUserResponse>(json, JsonSerializerSettings);

            // JSON formatındaki response'u döndür
            return Task.FromResult(userResponse);

        }


        public Task<List<CreateAddUserResponse>> GetAllUsersAsync()
        {
            
            var users = UserStorage.GetAllUsers();

            
            var userDtos = users.Select(user => new CreateAddUserResponse
            {
                Name = user.Name,
                SurName = user.SurName,
                Email = user.Email,
                IdCard = user.IdCard,
                UserType = user.UserType
            }).ToList();

           
            string json = JsonConvert.SerializeObject(userDtos, JsonSerializerSettings);

            
            var result = JsonConvert.DeserializeObject<List<CreateAddUserResponse>>(json, JsonSerializerSettings);
            Console.WriteLine(json);

            
            return Task.FromResult(result);
        }
    }
}
