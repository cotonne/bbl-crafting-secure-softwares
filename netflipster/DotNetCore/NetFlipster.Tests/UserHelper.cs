using Netflipster.Repository;
using System;

namespace NetFlipster.Tests
{
    public class UserHelper
    {
        public static string CreateUserName()
        {
            return "User" + Guid.NewGuid();
        }

        public static string Create()
        {
            var name = CreateUserName();
            UserDao.Register(name, "pwd");
            return name;
        }

        public static string CreateWithPassword(string pwd)
        {
            return CreateWithPassword(CreateUserName(), pwd);
        }

        public static string CreateWithPassword(string name, string pwd)
        {
            UserDao.Register(name, pwd);
            return name;
        }
    }
}