using Netflipster.Repository;
using NFluent;
using Xunit;

namespace NetFlipster.Tests
{
    public class BookingDaoTests
    {
        [Fact]
        public void Book_Ok()
        {
            var userId = UserHelper.Create();
            var actual = BookingDao.Book("3", 10, userId);
            Check.That(actual).IsTrue();
        }
    }
}
