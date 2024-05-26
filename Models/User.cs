using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserManagement.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Avatar { get; set; }
    }

    public class UserCreateRequest
    {
        public string Name { get; set; }
        public string Job { get; set; }
    }

    public class UserResponse
    {
        public IEnumerable<User> Data { get; set; }
    }

    public class UserDetailResponse
    {
        public User Data { get; set; }
    }
}