-- SQLite
CREATE TABLE films(
    id INTEGER PRIMARY KEY,
    title VARCHAR(50),
    director VARCHAR(50),
    price DECIMAL(10,2),
    description VARCHAR(50)
);
INSERT INTO films(
    title,director,price,description)
VALUES(
    "Rybki z ferajny","Adam Nowak",23.99,"opis...."
);
INSERT INTO films(
    title,director,price,description)
VALUES(
    "Wakacje wiedeńskie","Anna Wanna",123.99,"opis inny...."
);
INSERT INTO films(
    title,director,price,description)
VALUES(
    "Fajny Film 5","Ksawery Rowery",66.99,"kicha!!!!"
);