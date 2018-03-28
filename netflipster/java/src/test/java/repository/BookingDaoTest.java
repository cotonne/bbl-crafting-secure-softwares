package repository;

import org.junit.Test;

public class BookingDaoTest {

    @Test
    public void should_book_a_dvd() {
        UserDao.register("doe", "aaaaaa");
        BookingDao.book("1", 1, "doe");
    }
}