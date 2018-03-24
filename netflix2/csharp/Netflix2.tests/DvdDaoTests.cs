using System.Linq;
using Netflix2.repository;
using NFluent;
using NUnit.Framework;

namespace Netflix2.tests
{
    [TestFixture]
    public class DvdDaoTests
    {
        [Test]
        public void GetIdentifiers_Ok()
        {
            var actual = DvdDao.GetIdentifiers();
            Check.That(actual.Count()).IsEqualTo(8);
        }

        [Test]
        public void GetDvdNameById_Ok()
        {
            var actual = DvdDao.GetDvdNameById("3");
            Check.That(actual).IsEqualTo(actual);
        }
    }
}
