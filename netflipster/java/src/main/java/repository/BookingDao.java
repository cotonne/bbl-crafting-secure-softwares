package repository;

import source.DB;

public class BookingDao {

    public static void book(String dvdId, int quantity, String userId) {
        DB.insert(String.format("INSERT INTO BOOKINGS(DVD_ID, QUANTITY, USER_ID) values('%s', %s, '%s')", dvdId, quantity, userId));
    }
}
