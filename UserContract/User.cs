using Contracts.Enums;

namespace UserContract
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string IdCard { get; set; }
        public string Email { get; set; }
        public UserType UserType { get; set; }

    }


}
