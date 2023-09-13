-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 13 Wrz 2023, 13:43
-- Wersja serwera: 10.4.22-MariaDB
-- Wersja PHP: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `3ti_2023_24_cw1`
--
CREATE DATABASE IF NOT EXISTS `3ti_2023_24_cw1` DEFAULT CHARACTER SET utf8 COLLATE utf8_polish_ci;
USE `3ti_2023_24_cw1`;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `miejsca`
--

CREATE TABLE `miejsca` (
  `id` int(11) NOT NULL,
  `nazwa` varchar(100) COLLATE utf8_polish_ci NOT NULL,
  `cena` decimal(10,2) NOT NULL,
  `termin` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `miejsca`
--

INSERT INTO `miejsca` (`id`, `nazwa`, `cena`, `termin`) VALUES
(1, 'Warszawa', '2000.00', '2023-07-12'),
(2, 'Zakopane', '500.00', '2023-08-15'),
(3, 'Gdańsk', '800.00', '2023-08-19'),
(4, 'Wrocław', '300.00', '2023-08-11');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `miejsca`
--
ALTER TABLE `miejsca`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT dla zrzuconych tabel
--

--
-- AUTO_INCREMENT dla tabeli `miejsca`
--
ALTER TABLE `miejsca`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
