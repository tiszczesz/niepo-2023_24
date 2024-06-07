-- SQLite
CREATE TABLE users(
    id Integer PRIMARY KEY,
    firstname text,
    lastname text,
    mydate text
);
INSERT INTO users (id, firstname, lastname, mydate) 
VALUES(1, 'John', 'Bułka','2021-12-12');
INSERT INTO users ( firstname, lastname, mydate) 
VALUES('John', 'Bułka','2021-12-12');
INSERT INTO users ( firstname, lastname, mydate) 
VALUES( 'Antoni', 'Małecki','2022-04-02');
INSERT INTO users ( firstname, lastname, mydate) 
VALUES('Monika', 'Nowak','2019-11-23');