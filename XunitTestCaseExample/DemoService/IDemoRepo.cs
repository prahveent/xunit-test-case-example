using System;
using System.Collections.Generic;
using System.Text;

namespace XunitTestCaseExample.DemoService
{
    public interface IDemoRepo
    {
        IEnumerable<User> GetUsers();
    }
}
