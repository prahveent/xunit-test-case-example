using System;
using Xunit;
using XunitTestCaseExample;

namespace TestCases
{
    public class BasicTest
    {
        [Fact]
        public void CheckXGreatorThanY()
        {
            var result1 = new BasicTestBase().XGreaterThanY(2, 1);
            var result2 = new BasicTestBase().XGreaterThanY(1, 2);
            Assert.True(true == result1);
            Assert.True(false == result2);
        }

        [Theory]
        [InlineData(2, 1, true)]
        [InlineData(1, 2, false)]
        public void CheckXGreatorThanYWithTheory(int x, int y, bool expectedResult)
        {
            var result = new BasicTestBase().XGreaterThanY(x, y);
            Assert.True(expectedResult == result);
        }

        [Theory]
        [MemberData(nameof(ValidateDateMock.GenerateDefineDateTestData), MemberType = typeof(ValidateDateMock))]
        public void ValidDateWithMemberData(ValidDateArgs args, bool expectedResult)
        {
            var result = new BasicTestBase().ValidateDate(from: args.From, to: args.To);
            Assert.Equal(expectedResult, result);
        }


    }
}
