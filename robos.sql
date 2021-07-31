-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 01-08-2021 a las 00:13:05
-- Versión del servidor: 10.4.18-MariaDB
-- Versión de PHP: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `robos`
--
CREATE DATABASE IF NOT EXISTS `robos` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `robos`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `denuncias`
--
-- Creación: 28-07-2021 a las 19:23:14
-- Última actualización: 31-07-2021 a las 21:09:55
--

CREATE TABLE `denuncias` (
  `ID` int(11) NOT NULL,
  `Cedula` varchar(15) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Fecha` timestamp NOT NULL DEFAULT current_timestamp(),
  `Descripcion` varchar(150) NOT NULL,
  `Valor` double NOT NULL,
  `Lugar` varchar(50) NOT NULL,
  `Latitud` double NOT NULL,
  `Longitud` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `denuncias`
--

INSERT INTO `denuncias` (`ID`, `Cedula`, `Nombre`, `Fecha`, `Descripcion`, `Valor`, `Lugar`, `Latitud`, `Longitud`) VALUES
(4, '40233211954', 'Juan Perez', '2021-07-31 20:35:22', 'una camioneta', 150000, 'Santo domingo', 18.47186, -69.89232),
(5, '5454554', 'Pedro Martinez`', '2021-07-31 21:08:58', 'Una gorra ', 500, 'La romana ', 18.42733, -68.97285),
(6, '65454', 'Marta Diaz', '2021-07-31 21:09:55', 'Una cartera', 2000, 'Bani', 18.311683516138295, -70.3082198476562);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `denuncias`
--
ALTER TABLE `denuncias`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Cedula` (`Cedula`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `denuncias`
--
ALTER TABLE `denuncias`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
