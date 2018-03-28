

export async function getIdentifiers(db): Promise<Array<number>> {
    let p = new Promise<Array<number>>((resolve) => {
        db.all("SELECT ID FROM DVDS WHERE ID > 0", (err, rows) => {
            resolve(rows);
        });
    });

    return p;
}

export async function getDvdNameById(db, dvdId: string): Promise<string> {
    let p = new Promise<string>((resolve) => {
        db.get("SELECT NAME FROM DVDS WHERE ID = %s", 
        dvdId,
        (err, row) => {
            resolve(row);
        });
    });

    return p;
}