package repository;

import org.junit.Test;

import static org.junit.Assert.*;

public class UserDaoTest {

    @Test
    public void should_say_that_a_user_doesnt_exist() {
        assertFalse(UserDao.exist("random", "random"));
    }

    @Test
    public void should_say_that_a_user_exists_given_he_has_registered_previously() {
        UserDao.register("john", "123456");
        assertTrue(UserDao.exist("john", "123456"));
    }
}