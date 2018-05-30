package repository;

import org.junit.Test;

public class BookingDaoTest {

    @Test
    public void should_book_a_vhs() {
        UserDao.register("doe", "aaaaaa");
        BookingDao.book("1", 1, "doe");
        BookingDao.book("1", 1, "1");
    }
}