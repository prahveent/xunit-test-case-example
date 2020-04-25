using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XunitTestCaseExample.Persistence;
using XunitTestCaseExample.Persistence.Entity;

namespace XunitTestCaseExample.DemoService
{
    public class DemoRepo : IDemoRepo
    {
        private DemoContext Context;

        public DemoRepo(DemoContext context)
        {
            this.Context = context;
        }

        public User GetById(int id)
        {
            return this.Context.Users.FirstOrDefault(u => u.Id == id);
        }

        public IEnumerable<User> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
