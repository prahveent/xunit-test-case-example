namespace XunitTestCaseExample.DemoService
{
    public class UserStatDTO
    {
        public UserStatDTO(int totalUser, int activeUsers)
        {
            this.TotalUsers = totalUser;
            this.ActiveUsers = activeUsers;
        }

        public int ActiveUsers { get; private set; }
        public int TotalUsers { get; private set; }

    }
}