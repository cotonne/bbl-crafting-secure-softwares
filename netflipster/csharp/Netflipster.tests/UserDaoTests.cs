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
            var userId = UserHelper.CreateUserId();
            var result = UserDao.Register(userId, "pwd");
            Check.That(result).IsTrue();
        }

        [Test]
        public void Exist_User()
        {
            var userId = UserHelper.CreateUserId();
            UserDao.Register(userId, "pwd");
            var actual = UserDao.Exist(userId, "pwd");
            Check.That(actual).IsTrue();
        }

        [Test]
        public void Exist_NoUser()
        {
            var actual = UserDao.Exist("totoZorglub", "pwdImpossible");
            Check.That(actual).IsFalse();
        }
    }
}
