using DL;

namespace UI
{
    internal class UserOperations
    {
        static UserSQLRepo UR = new UserSQLRepo();

        public static void GetAllUsers()
        {
            UR.GetAllUsers();
        }

        public static void AddDummyUser()
        {
            User user1 = new User()
            {
                Fullname = "Jane Doe",
                Username = "JD11",
                Email = "janedoe@demo.com",
                UserID = 2,
            };

            UR.AddUser(user1);
        }
    }
}
