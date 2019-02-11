-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 09, 2019 at 05:46 PM
-- Server version: 10.1.37-MariaDB
-- PHP Version: 7.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `movies`
--

-- --------------------------------------------------------

--
-- Table structure for table `movie`
--

CREATE TABLE `movie` (
  `id` int(40) NOT NULL,
  `name` varchar(60) NOT NULL,
  `description` varchar(600) DEFAULT NULL,
  `Rating` int(6) DEFAULT NULL,
  `Categorie` varchar(20) DEFAULT NULL,
  `studio` varchar(20) DEFAULT NULL,
  `img` varchar(1000) DEFAULT NULL,
  `dateReleased` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `movie`
--

INSERT INTO `movie` (`id`, `name`, `description`, `Rating`, `Categorie`, `studio`, `img`, `dateReleased`) VALUES
(1, 'Naruto', 'best anime', 10, 'adventure', 'mashahi kisimato stu', '\r\ndata:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBwgHBgkIBwgKCgkLDRYPDQwMDRsUFRAWIB0iIiAdHx8kKDQsJCYxJx8fLT0tMTU3Ojo6Iys/RD84QzQ5OjcBCgoKDQwNGg8PGjclHyU3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3N//AABEIALcAeAMBIgACEQEDEQH/xAAcAAABBQEBAQAAAAAAAAAAAAAGAAIDBAUHAQj/xABGEAACAQIFAQUFBAcECAcAAAABAgMEEQAFEiExQQYTIlFhFDJxgZFCobHRFSMzUsHw8QckQ5MlYmNyc4OS4RZFgqKywtL/xAAaAQACAwEBAAAAAAAAAAAAAAAEBQECAwAG/8QALhEAAgIBAwQBAwMDBQAAAAAAAQIAAxEEEiEFMUFREyJhoRTR4YHB8CNScZGx/9oADAMBAAIRAxEAPwAli/tHimlWODJKyR291VlUsfkBieTt/wBzp9oyOrj1306p0sbWB+lxfyvgVoEVuzNWlD4q+WqVJkT9oacLqsAN9JbY/Q4myvKou6Zq1otcUyxiJ5dK06sA8rvYjTZQBYfa0g8WBhqqUnjtBxZYexhKO38J4ymf/PX8sSp25ia3+jJhf/br+WMCjgy4wxPMyxQ9/NP+tZgRSoSFLC4sWuukbMTv0IxItLSKyJNLEr09E00kYlX9bKT4IydVlKgb+7e+1rXxTbR6M7dd/uhAnbWFveyye/8AxlxZTtdC1/7hMLecqYERBHLOjRSUsUcmooDOBpCAAsxPCk3N+N9r7XnoxC70xlqIESYLIxaRR3aEjdrnw36Dk74k11EZE4WW5wYWP2nhjcpNSMkgQSaDPGW0HhrXvY4nTP43bT7HNe9ral5wMCaGuqJ6qVoI6fvnqGYSDxd34Y11MxW/hUjizAYkiqlgC1KyxB4KVn0cAzs', '2016-02-10');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `movie`
--
ALTER TABLE `movie`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `movie`
--
ALTER TABLE `movie`
  MODIFY `id` int(40) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
