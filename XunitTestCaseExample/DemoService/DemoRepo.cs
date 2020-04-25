using System;
using System.Collections.Generic;
using System.Text;

namespace XunitTestCaseExample.DemoService
{
    public class DemoRepo : IDemoRepo
    {
        public IEnumerable<User> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
