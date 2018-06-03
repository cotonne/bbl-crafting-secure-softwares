using System;
using Netflipster.Repository;

namespace Netflipster.tests
{
    public class UserHelper
    {
        public static string CreateUserId()
        {
            return "User" + Guid.NewGuid();
        }

        public static string Create()
        {
            var userId = CreateUserId();
            UserDao.Register(userId, "pwd");
            return userId;
        }

        public static string CreateWithPassword(string pwd)
        {
            return CreateWithPassword(CreateUserId(), pwd);
        }

        public static string CreateWithPassword(string userId, string pwd)
        {
            UserDao.Register(userId, pwd);
            return userId;
        }
    }
}
