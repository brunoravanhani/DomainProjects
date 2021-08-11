using DomainProjects.SurveyApp.Entity;
using DomainProjects.SurveyApp.Enums;
using Xunit;

namespace DomainProjects.SurveyApp.Test.Entity
{
    public class UserTest
    {
        [Fact]
        public void ShouldCreateUserInstance()
        {
            var user = new User(UserType.Cordinator, "John", "john@gmail.com", "123456");

            Assert.Equal(UserType.Cordinator, user.Type);
            Assert.Equal("john", user.Name);
            Assert.Equal("john@gmail.com", user.Email);
            Assert.Equal("123456", user.Password);
        }
    }
}
