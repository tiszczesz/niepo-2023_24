-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 02 Paź 2023, 09:21
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
-- Baza danych: `3ti_2023_24_cw2`
--
CREATE DATABASE IF NOT EXISTS `3ti_2023_24_cw2` DEFAULT CHARACTER SET utf8 COLLATE utf8_polish_ci;
USE `3ti_2023_24_cw2`;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `divisions`
--

DROP TABLE IF EXISTS `divisions`;
CREATE TABLE `divisions` (
  `id` int(11) NOT NULL,
  `name` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `teacher_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `divisions`
--

INSERT INTO `divisions` (`id`, `name`, `teacher_id`) VALUES
(1, 'grupa 1', 1),
(2, 'grupa 2', 4),
(3, 'grupa 3', 2),
(4, 'grupa 4', 3);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `student`
--

DROP TABLE IF EXISTS `student`;
CREATE TABLE `student` (
  `id` int(11) NOT NULL,
  `firstname` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `lastname` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `division_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `student`
--

INSERT INTO `student` (`id`, `firstname`, `lastname`, `division_id`) VALUES
(1, 'Tomasz ', 'Małecki', 1),
(2, 'Adrian', 'Dusza', 1),
(3, 'Grażyna ', 'Małecka', 1),
(4, 'Eryk', 'Turek', 2),
(5, 'Urszula', 'Groźna', 3),
(6, 'Martyna', 'Rygiel', 3),
(7, 'Wojciech', 'Rynek', 3),
(8, 'Henryk', 'Firek', 3),
(9, 'Janusz', 'Gajos', 4),
(10, 'Marzena', 'Tomara', 4),
(11, 'Monika', 'Grycek', 4),
(12, 'Julia', 'Malina', 4);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `teachers`
--

DROP TABLE IF EXISTS `teachers`;
CREATE TABLE `teachers` (
  `id` int(11) NOT NULL,
  `firstname` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `lastname` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `salary` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `teachers`
--

INSERT INTO `teachers` (`id`, `firstname`, `lastname`, `salary`) VALUES
(1, 'Franciszek', 'Małecki', '5600'),
(2, 'Renata', 'Sałata', '6000'),
(3, 'Roman', 'Boman', '7200'),
(4, 'Marcelina', 'Sprężyna', '4300');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `divisions`
--
ALTER TABLE `divisions`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_division_teacher` (`teacher_id`);

--
-- Indeksy dla tabeli `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_division_student` (`division_id`);

--
-- Indeksy dla tabeli `teachers`
--
ALTER TABLE `teachers`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT dla zrzuconych tabel
--

--
-- AUTO_INCREMENT dla tabeli `divisions`
--
ALTER TABLE `divisions`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT dla tabeli `student`
--
ALTER TABLE `student`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT dla tabeli `teachers`
--
ALTER TABLE `teachers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Ograniczenia dla zrzutów tabel
--

--
-- Ograniczenia dla tabeli `divisions`
--
ALTER TABLE `divisions`
  ADD CONSTRAINT `fk_division_teacher` FOREIGN KEY (`teacher_id`) REFERENCES `teachers` (`id`);

--
-- Ograniczenia dla tabeli `student`
--
ALTER TABLE `student`
  ADD CONSTRAINT `fk_division_student` FOREIGN KEY (`division_id`) REFERENCES `divisions` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
