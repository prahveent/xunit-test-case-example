using System;
using System.Collections.Generic;
using System.Linq;
using XunitTestCaseExample.Persistence.Entity;
using Microsoft.EntityFrameworkCore;
using Moq;
using XunitTestCaseExample.Persistence;
using XunitTestCaseExample.DemoService;
using Xunit;

namespace TestCases
{
    public class DbContextMockTest
    {
        [Fact]
        public void DbContextMock()
        {
            IQueryable<User> data = GetMockUsers();
            var mockUser = SetDatabase<User>(data);

            var context = new Mock<DemoContext>();
            context.Setup(s => s.Users).Returns(mockUser.Object);

            var demoRpo = new DemoRepo(context: context.Object);
            var result = demoRpo.GetById(1);
            Assert.Equal(1, result.Id);
            Assert.True(false == result.IsActive);
        }

        private IQueryable<User> GetMockUsers()
        {
            var users = new List<User>()
            {
                new User() { Id = 1, IsActive = false },
                new User() { Id = 2, IsActive = false },
                new User() { Id = 3, IsActive = false },
                new User() { Id = 4, IsActive = false },
                new User() { Id = 5, IsActive = true },
            };
            return users.AsQueryable();
        }

        private Mock<DbSet<T>> SetDatabase<T>(IQueryable<T> data) where T : class
        {
            var mock = new Moq.Mock<DbSet<T>>();
            mock.As<IQueryable<T>>().Setup(m => m.Provider).Returns(data.Provider);
            mock.As<IQueryable<T>>().Setup(m => m.Expression).Returns(data.Expression);
            mock.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mock.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
            return mock;
        }
    }
}
