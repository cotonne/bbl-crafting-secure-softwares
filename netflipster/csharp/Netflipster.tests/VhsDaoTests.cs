using System.Linq;
using Netflipster.Repository;
using NFluent;
using NUnit.Framework;

namespace Netflipster.tests
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
