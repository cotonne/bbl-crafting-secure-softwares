
export function register(db, userId: string, password: string): Promise<{}> {
    let p = new Promise((resolve) => {
        db.exec(`INSERT INTO USERS(ID, PASSWORD) values('${userId}', '${password}')`, () => resolve());
    });
    return p;
}

export function exist(db, userId: string, password: string) : Promise<boolean> {
    let p = new Promise<boolean>((resolve, reject) => {
        db.get("SELECT count(1) FROM USERS where id='$id' AND password='$password'",{
            id: userId,
            password: password
        },
        (err: any, row: any) => {
            if(parseInt(row) > 0)
                resolve();
            else
                reject();
        });
    });

    return p;
}