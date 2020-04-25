using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XunitTestCaseExample.DemoService
{
    public class DemoService : IDemoService
    {
        public DemoService(IDemoRepo demoRepo)
        {
            this.DemoRepo = demoRepo;
        }

        private IDemoRepo DemoRepo { get; }

        public UserStatDTO GetUserStat()
        {
            IEnumerable<User> users = this.DemoRepo.GetUsers();
            return new UserStatDTO(users.Count(), users.Where(u => u.IsActive).Count());
        }
    }
}
