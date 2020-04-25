using System;
using System.Collections.Generic;

namespace TestCases
{
    internal static class ValidateDateMock
    {
        public static IEnumerable<object[]> GenerateDefineDateTestData()
        {
            yield return new object[] {
                new ValidDateArgs(DateTime.Now.AddDays(-10), DateTime.Now.AddDays(20)),
                false

            };
            yield return new object[] {
                new ValidDateArgs(DateTime.Now.AddDays(-10), DateTime.Now.AddDays(20)),
                false
            };
        }

    }

    public class ValidDateArgs
    {
        public DateTime From { get; }
        public DateTime To { get; }

        public ValidDateArgs(DateTime from, DateTime to)
        {
            this.From = from;
            this.From = to;
        }
    }
}
