-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 14-12-2024 a las 04:00:43
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `tienda`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuentas`
--

CREATE TABLE `cuentas` (
  `id` int(5) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Usuario` varchar(20) NOT NULL,
  `Contrasena` varchar(20) NOT NULL,
  `Monto` int(7) NOT NULL,
  `rol` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `cuentas`
--

INSERT INTO `cuentas` (`id`, `Nombre`, `Usuario`, `Contrasena`, `Monto`, `rol`) VALUES
(1, 'Ernesto Alonso Morquecho Canales', 'ErnestoMorquecho', 'Neto_Morquecho20', 0, 'usuario'),
(2, 'Jesus Alberto Damasco Lopez', 'Jesus Damasco', 'Chuy_Damasco23', 0, 'usuario'),
(3, 'José Alejandro Contreras Becerra', 'Jose Contreras', 'Joselito_Contreras20', 0, 'usuario'),
(4, 'Emiliano de Jesús Esparza Ramírez', 'EmilianoEsparza', 'Emiliano_Esparza20', 0, 'usuario'),
(5, 'Juan Carlos Uriarte Padilla', 'Juan Uriarte', 'Juan_Uriarte20', 0, 'usuario'),
(6, 'Administrador', 'admin', 'admin1234', 0, 'admin'),
(7, 'Guest', 'guest', 'guest1234', 0, 'guest');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `id` int(5) NOT NULL,
  `imagen` varchar(10) NOT NULL,
  `Nombre` varchar(25) NOT NULL,
  `Descripcion` varchar(100) NOT NULL,
  `precio` int(10) NOT NULL,
  `existencias` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`id`, `imagen`, `Nombre`, `Descripcion`, `precio`, `existencias`) VALUES
(1, 'pencil.png', 'Lapiz', 'Lapiz del No. 2, Resistente y duradero.', 5, 20),
(2, 'pluma.png', 'Boligrafo', 'Boligrafo de alta calidad. Varios colores disponibles.', 8, 50),
(3, 'Libreta.pn', 'Libreta', 'Cuadernillo de trabajo de 100 hojas. Ideal para la escuela.', 35, 45),
(4, 'bloc.png', 'Hojas de Maquina', 'Bloc de 500 hojas de maquina. Material 100 reciclado porque cuidamos el medio ambiente.', 100, 25),
(5, 'clips.png', 'Clips', 'Caja de 100 clips para papeles.', 20, 15),
(6, 'plumones.p', 'Plumones', 'Plumones para pintarron. Empaque con varios plumones de colores variados. ', 80, 10),
(7, 'Folders.pn', 'Folder', 'Folders para guardar papeles. Diferentes colores llamativos en existencias.', 5, 100),
(8, 'Pintarron.', 'Pizarron Blanco', 'Pequeño pizarron blanco de un metro cuadrado, ideal para estudiantes o salones pequeños.', 1000, 4);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

CREATE TABLE `ventas` (
  `id` int(5) NOT NULL,
  `Usuario_Vendedor` varchar(20) NOT NULL,
  `Prod_Vendidos` varchar(50) NOT NULL COMMENT 'Aqui va una lista de id de productos',
  `total` int(10) NOT NULL,
  `fecha/hora` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cuentas`
--
ALTER TABLE `cuentas`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD PRIMARY KEY (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
