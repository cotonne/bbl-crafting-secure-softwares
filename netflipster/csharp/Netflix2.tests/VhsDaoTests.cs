using System.Linq;
using Netflix2.repository;
using NFluent;
using NUnit.Framework;

namespace Netflix2.tests
{
    [TestFixture]
    public class VhsDaoTests
    {
        [Test]
        public void GetIdentifiers_Ok()
        {
            var actual = VhsDao.GetIdentifiers().ToList();
            Check.That(actual.Count()).IsEqualTo(8);
        }

        [Test]
        public void GetVhsNameById_Ok()
        {
            var actual = VhsDao.GetVhsNameById("3");
            Check.That(actual).IsEqualTo(actual);
        }
    }
}
