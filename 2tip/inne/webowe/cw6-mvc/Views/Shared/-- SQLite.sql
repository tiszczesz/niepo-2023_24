-- SQLite
CREATE TABLE Films(
    id Integer PRIMARY Key,
    title TEXT,
    director TEXT,
    year Integer,
    price Real
);
INSERT INTO Films (title, director, year, price) VALUES ('Inception', 'Christopher Nolan', 2010, 12.99);
INSERT INTO Films (title, director, year, price) VALUES ('The Shawshank Redemption', 'Frank Darabont', 1994, 9.99);
INSERT INTO Films (title, director, year, price) VALUES ('Pulp Fiction', 'Quentin Tarantino', 1994, 11.99);
INSERT INTO Films (title, director, year, price) VALUES ('The Dark Knight', 'Christopher Nolan', 2008, 14.99);
INSERT INTO Films (title, director, year, price) VALUES ('Forrest Gump', 'Robert Zemeckis', 1994, 8.99);
INSERT INTO Films (title, director, year, price) VALUES ('The Matrix', 'Lana Wachowski, Lilly Wachowski', 1999, 10.99);
INSERT INTO Films (title, director, year, price) VALUES ('The Godfather', 'Francis Ford Coppola', 1972, 12.49);
INSERT INTO Films (title, director, year, price) VALUES ('Interstellar', 'Christopher Nolan', 2014, 13.49);
INSERT INTO Films (title, director, year, price) VALUES ('Gladiator', 'Ridley Scott', 2000, 9.99);
INSERT INTO Films (title, director, year, price) VALUES ('Titanic', 'James Cameron', 1997, 11.99);

select * FROM Films;