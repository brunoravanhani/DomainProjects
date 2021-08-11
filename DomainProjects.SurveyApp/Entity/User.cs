using DomainProjects.SurveyApp.Enums;
using DomainProjects.SurveyApp.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainProjects.SurveyApp.Entity
{
    public class User
    {
        public int UserId { get; }
        public UserType Type { get; }

        public string Name { get; }
        public Email Email { get; }
        public Password Password { get; }

        public User(UserType type, string name, string email, string password)
        {
            Type = type;
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
