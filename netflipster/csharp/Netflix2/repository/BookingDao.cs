namespace Netflix2.repository
{
    public static class BookingDao
    {
        public static bool Book(string dvdId, int quantity, string userId)
        {
            return DB.Insert($"INSERT INTO BOOKINGS(DVD_ID, QUANTITY, USER_ID) values('{dvdId}', {quantity}, '{userId}')");
        }
    }
}