using Netflipster.Repository;
using NFluent;
using NUnit.Framework;

namespace Netflipster.tests
{
    [TestFixture]
    public class UserDaoTests
    {
        [Test]
        public void Insert_User()
        {
            var name = UserHelper.CreateUserName();
            var result = UserDao.Register(name, "pwd");
            Check.That(result).IsTrue();
        }

        [Test]
        public void Exist_User()
        {
            var name = UserHelper.CreateUserName();
            UserDao.Register(name, "pwd");
            var actual = UserDao.Exist(name, "pwd");
            Check.That(actual).IsNotEmpty();
        }

        [Test]
        public void Exist_NoUser()
        {
            var actual = UserDao.Exist("totoZorglub", "pwdImpossible");
            Check.That(actual).IsEmpty();
        }
    }
}
