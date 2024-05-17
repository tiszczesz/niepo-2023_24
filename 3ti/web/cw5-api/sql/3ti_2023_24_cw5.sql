-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Maj 17, 2024 at 10:20 AM
-- Wersja serwera: 10.4.32-MariaDB
-- Wersja PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `3ti_2023_24_cw5`
--
CREATE DATABASE IF NOT EXISTS `3ti_2023_24_cw5` DEFAULT CHARACTER SET utf8 COLLATE utf8_polish_ci;
USE `3ti_2023_24_cw5`;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `date` date NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `firstname`, `lastname`, `date`) VALUES
(1, 'Roman', 'Boman', '2024-05-17'),
(2, 'Monika', 'Klika', '2024-05-14'),
(3, 'Ryszard', 'Małecki', '2024-05-17'),
(4, 'Julia', 'Małaga', '2024-05-17'),
(5, 'Henryk', 'Uryga', '2024-02-13'),
(6, 'Wojciech', 'Kowalski', '2024-05-19');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
