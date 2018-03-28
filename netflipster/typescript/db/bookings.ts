
export function book(db, dvdId: string, quantity: number, userId: string) {
    let p = new Promise((resolve) => {
        db.exec(`INSERT INTO BOOKINGS(DVD_ID, QUANTITY, USER_ID) values('${dvdId}', ${quantity}, '${userId}')`, () => resolve());
    });
    return p;  
}