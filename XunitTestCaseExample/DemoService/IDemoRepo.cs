using System;
using System.Collections.Generic;
using System.Text;
using XunitTestCaseExample.Persistence.Entity;


namespace XunitTestCaseExample.DemoService
{
    public interface IDemoRepo
    {
        User GetById(int id);
        IEnumerable<User> GetUsers();

    }
}
