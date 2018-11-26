using Netflipster.Repository;
using NFluent;
using System.Linq;
using Xunit;

namespace NetFlipster.Tests
{
    public class VhsDaoTests
    {
        [Fact]
        public void GetIdentifiers_Ok()
        {
            var actual = VhsDao.GetIdentifiers().ToList();
            Check.That(actual.Count()).IsEqualTo(8);
        }

        [Fact]
        public void GetVhsNameById_Ok()
        {
            var actual = VhsDao.GetVhsNameById("3");
            Check.That(actual).IsEqualTo(actual);
        }
    }
}
