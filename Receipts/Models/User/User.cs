using Microsoft.AspNetCore.Identity;

namespace Data.Users
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string loggin { get; set; }

        public User(string name, string lastName, string password, string loggin)
        {
            Name = name;
            LastName = lastName;
            Password = password;
            this.loggin = loggin;
        }
    }
}