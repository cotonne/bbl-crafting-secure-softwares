namespace Netflix2.repository
{
    public static class BookingDao
    {
        public static bool Book(string vhsId, int quantity, string userId)
        {
            return DB.Insert($"INSERT INTO BOOKINGS(VHS_ID, QUANTITY, USER_ID) values('{vhsId}', {quantity}, '{userId}')");
        }
    }
}