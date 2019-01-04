package repository;

import org.junit.Test;

public class BookingDaoTest {

    @Test
    public void should_book_a_vhs() {
        // Register a new user
        UserDao.register("doe", "aaaaaa");
        // Should be able to buy a VHS
        BookingDao.book("1", 1, "1");
    }
}