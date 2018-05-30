package repository;

import source.DB;

public class BookingDao {

    public static void book(String vhsId, int quantity, String userId) {
        DB.insert(String.format("INSERT INTO BOOKINGS(VHS_ID, QUANTITY, USER_ID) values('%s', %s, '%s')", vhsId, quantity, userId));
    }
}
