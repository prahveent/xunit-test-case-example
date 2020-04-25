using System;

namespace XunitTestCaseExample
{
    public class BasicTestBase
    {
        public bool XGreaterThanY(int x, int y)
        {
            return x > y;
        }

        public bool ValidateDate(DateTime from, DateTime to)
        {
            return from < to;
        }
    }
}
