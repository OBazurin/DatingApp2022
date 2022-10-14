
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;
using Moq;
using Xunit;

namespace API.Tests
{
    public class UserRepositoryTests
    {
        private readonly Mock<IUserRepository> _mock = new Mock<IUserRepository>();
        private readonly DummyRepo _repo ;

        public UserRepositoryTests()
        {
            var user = new AppUser()
            {
                UserName = "Dummy"
            };

            _mock.Setup(x => x.GetUserByIdAsync(1)).ReturnsAsync(user);
            
            
            _repo = new DummyRepo(_mock.Object);
        }
        
        [Fact]
        public async Task GetUserByIdAsyncReturnsDummyUser()
        {
            var user = await _repo.GetUserByIdAsync(1);

            Assert.Equal("Dummy", user.UserName);
        }
    }
}

