package repository;

import org.junit.Test;

import java.util.Collection;

import static org.junit.Assert.*;

public class VhsDaoTest {

    @Test
    public void should_find_vhs() {
        Collection<String> identifiers = VhsDao.getIdentifiers();
        assertEquals(8, identifiers.size());
    }

    @Test
    public void should_get_a_vhs() {
        String name = VhsDao.getVhsNameById("1");
        assertEquals("Harry Potter and the Philosophers Stone (2001)", name);
    }
}