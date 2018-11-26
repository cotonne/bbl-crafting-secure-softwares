using Netflipster.Repository;
using NFluent;
using Xunit;

namespace NetFlipster.Tests
{
    public class UserDaoTests
    {
        [Fact]
        public void Insert_User()
        {
            var name = UserHelper.CreateUserName();
            var result = UserDao.Register(name, "pwd");
            Check.That(result).IsTrue();
        }

        [Fact]
        public void Exist_User()
        {
            var name = UserHelper.CreateUserName();
            UserDao.Register(name, "pwd");
            var actual = UserDao.FindId(name, "pwd");
            Check.That(actual).IsNotEmpty();
        }

        [Fact]
        public void Exist_NoUser()
        {
            var actual = UserDao.FindId("totoZorglub", "pwdImpossible");
            Check.That(actual).IsEmpty();
        }
    }
}
