
export function init(db) {
    let p = new Promise((resolve) => {
        db.exec(`CREATE TABLE USERS (
            ID VARCHAR(255),
            PASSWORD VARCHAR(255),
            PRIMARY KEY(ID)
        );
        
        CREATE TABLE DVDS (
            ID INT,
            NAME VARCHAR(255),
            PRIMARY KEY(ID)
        );
        
        CREATE TABLE BOOKINGS (
            DVD_ID INT,
            USER_ID VARCHAR(255),
            QUANTITY VARCHAR(255),
            PRIMARY KEY(DVD_ID, USER_ID),
            FOREIGN KEY(DVD_ID) REFERENCES DVDS(ID),
            FOREIGN KEY(USER_ID) REFERENCES USERS(ID)
        );
        
        INSERT INTO DVDS(ID, NAME) VALUES(1,'Harry Potter and the Philosophers Stone (2001)');
        INSERT INTO DVDS(ID, NAME) VALUES(2,'Harry Potter and the Chamber of Secrets (2002)');
        INSERT INTO DVDS(ID, NAME) VALUES(3,'Harry Potter and the Prisoner of Azkaban (2004)');
        INSERT INTO DVDS(ID, NAME) VALUES(4,'Harry Potter and the Goblet of Fire (2005)');
        INSERT INTO DVDS(ID, NAME) VALUES(5,'Harry Potter and the Order of the Phoenix (2007)');
        INSERT INTO DVDS(ID, NAME) VALUES(6,'Harry Potter and the Half-Blood Prince (2009)');
        INSERT INTO DVDS(ID, NAME) VALUES(7,'Harry Potter and the Deathly Hallows – Part 1 (2010)');
        INSERT INTO DVDS(ID, NAME) VALUES(8,'Harry Potter and the Deathly Hallows – Part 2 (2011)');
        INSERT INTO DVDS(ID, NAME) VALUES(0,'https://youtu.be/dQw4w9WgXcQ');
        `, () => resolve());
    });
    return p;  
}