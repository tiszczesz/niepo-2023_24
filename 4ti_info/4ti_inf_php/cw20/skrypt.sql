
-- najpierw utworz baze danych o nazwie 4ti_inf_2024_cw20
-- z polskim kodowaniem
-- Tworzenie tabeli Cars
CREATE TABLE Cars (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    branch VARCHAR(50),
    distance INT,
    price DECIMAL(10, 2)
);

-- Wstawianie przykładowych rekordów
INSERT INTO Cars (branch, distance, price) VALUES ('Toyota', 10000, 25000.00);
INSERT INTO Cars (branch, distance, price) VALUES ('Honda', 8000, 22000.50);
INSERT INTO Cars (branch, distance, price) VALUES ('Ford', 12000, 18000.75);
INSERT INTO Cars (branch, distance, price) VALUES ('Chevrolet', 15000, 21000.25);
INSERT INTO Cars (branch, distance, price) VALUES ('Nissan', 9000, 23000.80);
INSERT INTO Cars (branch, distance, price) VALUES ('BMW', 5000, 35000.00);
INSERT INTO Cars (branch, distance, price) VALUES ('Mercedes', 7000, 40000.50);
INSERT INTO Cars (branch, distance, price) VALUES ('Audi', 11000, 32000.75);
INSERT INTO Cars (branch, distance, price) VALUES ('Volkswagen', 14000, 28000.25);
INSERT INTO Cars (branch, distance, price) VALUES ('Hyundai', 9500, 20000.80);
