CREATE TABLE Students(
id INTEGER NOT NULL PRIMARY KEY,
firstname TEXT,
lastname TEXT,
age INTEGER);

SELECT * FROM Students;
INSERT INTO Students(firstname,lastname,age) VALUES('Edmund','Hytroś',22);