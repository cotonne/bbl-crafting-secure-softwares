package repository;

import org.junit.Test;

import java.util.Collection;

import static org.junit.Assert.*;

public class DvdDaoTest {

    @Test
    public void should_find_dvds() {
        Collection<String> identifiers = DvdDao.getIdentifiers();
        assertEquals(8, identifiers.size());
    }

    @Test
    public void should_get_a_dvd() {
        String name = DvdDao.getDvdNameById("1");
        assertEquals("Harry Potter and the Philosophers Stone (2001)", name);
    }
}