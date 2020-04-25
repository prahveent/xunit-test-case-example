
using XunitTestCaseExample.DemoService;
using XunitTestCaseExample.Persistence.Entity;
using System.Collections.Generic;
using Xunit;

namespace TestCases
{
    public class InterfaceMockTest
    {
        [Fact]
        public void DemoServiceTestWithMockRepo()
        {
            var mockRepo = new Moq.Mock<IDemoRepo>();
            var mockUsers = GetMockUsers();
            mockRepo.Setup(r => r.GetUsers()).Returns(mockUsers);
            var demoService = new DemoService(mockRepo.Object);
            var result = demoService.GetUserStat();
            Assert.Equal(5, result.TotalUsers);
            Assert.Equal(1, result.ActiveUsers);
        }


        private static IEnumerable<User> GetMockUsers()
        {
            yield return new User() { Id = 1, IsActive = false };
            yield return new User() { Id = 2, IsActive = false };
            yield return new User() { Id = 3, IsActive = false };
            yield return new User() { Id = 4, IsActive = false };
            yield return new User() { Id = 5, IsActive = true };
        }
    }
}
