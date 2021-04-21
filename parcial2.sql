-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 22-04-2021 a las 00:24:51
-- Versión del servidor: 10.4.17-MariaDB
-- Versión de PHP: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `parcial2`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aplicacion`
--

CREATE TABLE `aplicacion` (
  `pk_id_aplicacion` int(10) NOT NULL,
  `fk_id_modulo` int(10) NOT NULL,
  `nombre_aplicacion` varchar(40) NOT NULL,
  `descripcion_aplicacion` varchar(45) NOT NULL,
  `estado_aplicacion` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `aplicacion`
--

INSERT INTO `aplicacion` (`pk_id_aplicacion`, `fk_id_modulo`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES
(1, 1, 'Login', 'Ventana de Ingreso', 1),
(2, 1, 'Mantenimiento Usuario', 'Mantenimientos de usuario', 1),
(3, 1, 'Mantenimiento Aplicacion', 'ABC de las Aplicaciones', 1),
(4, 1, 'Mantenimiento Perfil', 'ABC de perfiles', 1),
(5, 1, 'Asignacion de Aplicaciones a Perfil', 'Asignacion Aplicacion y perfil', 1),
(6, 1, 'Asignacaion de Aplicaciones', 'Asignacion especificas a un usuario', 1),
(7, 1, 'Consulta Aplicacion', 'Mantenimiento de Aplicaciones', 1),
(8, 1, 'Agregar Modulo', 'Mantenimientos de Modulos', 1),
(9, 1, 'Consultar Perfil', 'Consultas de perfiles disponibles', 1),
(10, 1, 'Permisos', 'Asignar permisos a perfiles y aplicaciones', 1),
(11, 1, 'Bitacora', 'Guarda todos los movimientos', 1),
(12, 10, 'Gestión de Citas ', 'Gestionar Citas', 1),
(1302, 5, 'Tipo Caso', 'Tipo de casos', 1),
(1303, 5, 'Tipo Pasaporte', 'Tipo Pasaporte', 1),
(1304, 5, 'Tipo Tramite', 'Tipo Tramite', 1),
(1305, 5, 'Centro', 'Centro', 1),
(1306, 5, 'PROPIETARIO', 'PROPIETARIO', 1),
(1307, 5, 'TRANSACCIONES', 'TRANSACCIONES', 1),
(1308, 5, 'DISPONIBILIDAD DIARIA', 'REPORTE DE DISPONIBILIDAD DIARIA', 1),
(1309, 5, 'PETICION POLIZA', 'PETICION POLIZA', 1),
(1310, 5, 'CUENTAS CONTABLES', 'AGREGAR CUENTAS CONTABLES', 1),
(1311, 5, 'POLIZAS', 'POLIZAS', 1),
(1312, 5, 'LIBRO DIARIO', 'LIBRO DIARIO', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aplicacion_perfil`
--

CREATE TABLE `aplicacion_perfil` (
  `pk_id_aplicacion_perfil` int(10) NOT NULL,
  `fk_idaplicacion_aplicacion_perfil` int(10) DEFAULT NULL,
  `fk_idperfil_aplicacion_perfil` int(10) DEFAULT NULL,
  `fk_idpermiso_aplicacion_perfil` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `aplicacion_perfil`
--

INSERT INTO `aplicacion_perfil` (`pk_id_aplicacion_perfil`, `fk_idaplicacion_aplicacion_perfil`, `fk_idperfil_aplicacion_perfil`, `fk_idpermiso_aplicacion_perfil`) VALUES
(1, 1, 1, 1),
(2, 4, 1, 2),
(3, 5, 1, 3),
(4, 2, 1, 4),
(5, 3, 1, 5),
(6, 6, 1, 6),
(7, 8, 1, 7),
(8, 2, 3, 8),
(9, 3, 3, 9),
(10, 4, 3, 11),
(11, 2, 4, 12),
(12, 8, 4, 13),
(13, 8, 5, 15);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aplicacion_usuario`
--

CREATE TABLE `aplicacion_usuario` (
  `pk_id_aplicacion_usuario` int(10) NOT NULL,
  `fk_idlogin_aplicacion_usuario` int(10) DEFAULT NULL,
  `fk_idaplicacion_aplicacion_usuario` int(10) DEFAULT NULL,
  `fk_idpermiso_aplicacion_usuario` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `aplicacion_usuario`
--

INSERT INTO `aplicacion_usuario` (`pk_id_aplicacion_usuario`, `fk_idlogin_aplicacion_usuario`, `fk_idaplicacion_aplicacion_usuario`, `fk_idpermiso_aplicacion_usuario`) VALUES
(1, 1, 4, 1),
(2, 1, 5, 2),
(3, 1, 6, 3),
(4, 3, 8, 10),
(5, 4, 6, 14),
(6, 5, 5, 16),
(7, 5, 2, 17),
(8, 6, 2, 1),
(9, 6, 3, 1),
(10, 6, 4, 1),
(11, 6, 6, 1),
(12, 6, 8, 1),
(13, 6, 1302, 1),
(14, 6, 1303, 1),
(15, 6, 1304, 1),
(16, 6, 1305, 1),
(17, 6, 1306, 1),
(18, 6, 12, 1),
(19, 7, 12, 19),
(20, 8, 1, 26),
(21, 8, 2, 27),
(22, 8, 3, 28),
(23, 8, 4, 29),
(24, 8, 5, 30),
(25, 8, 6, 31),
(26, 8, 7, 32),
(27, 8, 8, 33),
(28, 8, 9, 34),
(29, 8, 10, 35),
(30, 8, 11, 36),
(31, 8, 12, 37),
(32, 8, 1302, 38),
(33, 8, 1303, 39),
(34, 8, 1304, 40),
(35, 8, 1305, 41),
(36, 8, 1306, 42);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bitacora`
--

CREATE TABLE `bitacora` (
  `pk_id_bitacora` int(10) NOT NULL,
  `fk_idusuario_bitacora` int(10) DEFAULT NULL,
  `fk_idaplicacion_bitacora` int(10) DEFAULT NULL,
  `fechahora_bitacora` varchar(50) DEFAULT NULL,
  `direccionhost_bitacora` varchar(20) DEFAULT NULL,
  `nombrehost_bitacora` varchar(20) DEFAULT NULL,
  `accion_bitacora` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `bitacora`
--

INSERT INTO `bitacora` (`pk_id_bitacora`, `fk_idusuario_bitacora`, `fk_idaplicacion_bitacora`, `fechahora_bitacora`, `direccionhost_bitacora`, `nombrehost_bitacora`, `accion_bitacora`) VALUES
(1, 6, 1, '21/04/2021 14:54:08', '192.168.0.5', 'Man', 'Logeo Exitoso'),
(2, 6, 6, '21/04/2021 14:54:08', '192.168.0.5', 'Man', 'Ingreso a la asignacion de aplicaciones'),
(3, 6, 2, '21/04/2021 14:54:08', '192.168.0.5', 'Man', 'Ingreso al mantenimiento de usuarios'),
(4, 6, 2, '21/04/2021 14:54:08', '192.168.0.5', 'Man', ' INSERT INTO login VALUES ( 8,  Man,  bfcX++36cvYV3gXb8nuJdw==,  Manuel,  1) '),
(5, 6, 6, '21/04/2021 14:54:08', '192.168.0.5', 'Man', 'Ingreso a la asignacion de aplicaciones'),
(6, 6, 1, '21/04/2021 15:01:31', '192.168.0.5', 'Man', 'Logeo Exitoso'),
(7, 6, 2, '21/04/2021 15:01:31', '192.168.0.5', 'Man', 'Ingreso a la aplicacion Tipo de caso'),
(8, 6, 2, '21/04/2021 15:01:31', '192.168.0.5', 'Man', 'Ingreso a la aplicacion Tipo de caso'),
(9, 6, 2, '21/04/2021 15:01:31', '192.168.0.5', 'Man', 'Ingreso a la aplicacion Tipo de caso'),
(10, 6, 2, '21/04/2021 15:01:31', '192.168.0.5', 'Man', 'Ingreso a la aplicacion Tipo de caso'),
(11, 6, 1, '21/04/2021 15:03:30', '192.168.0.5', 'Man', 'Logeo Exitoso'),
(12, 6, 2, '21/04/2021 15:03:30', '192.168.0.5', 'Man', 'Ingreso a la aplicacion Tipo de caso'),
(13, 8, 1, '21/04/2021 15:04:21', '192.168.0.5', 'Man', 'Logeo Exitoso'),
(14, 8, 2, '21/04/2021 15:04:21', '192.168.0.5', 'Man', 'Ingreso a la aplicacion Tipo de caso'),
(15, 8, 1, '21/04/2021 15:05:15', '192.168.0.5', 'Man', 'Logeo Exitoso'),
(16, 8, 2, '21/04/2021 15:05:15', '192.168.0.5', 'Man', 'Ingreso a la aplicacion Tipo de caso'),
(17, 8, 1, '21/04/2021 15:13:27', '192.168.0.5', 'Man', 'Logeo Exitoso'),
(18, 8, 2, '21/04/2021 15:13:27', '192.168.0.5', 'Man', 'Ingreso a la aplicacion Tipo de caso'),
(19, 8, 2, '21/04/2021 15:13:27', '192.168.0.5', 'Man', ' INSERT INTO tipo VALUES ( 1,  Terror,  1) '),
(20, 8, 2, '21/04/2021 15:13:27', '192.168.0.5', 'Man', ' INSERT INTO tipo VALUES ( 2,  Acción,  1) '),
(21, 8, 2, '21/04/2021 15:13:27', '192.168.0.5', 'Man', ' INSERT INTO tipo VALUES ( 3,  Fantasía,  1) '),
(22, 8, 2, '21/04/2021 15:13:27', '192.168.0.5', 'Man', 'Ingreso a la aplicacion Tipo de caso'),
(23, 8, 2, '21/04/2021 15:13:27', '192.168.0.5', 'Man', 'Ingreso a la aplicacion Tipo de caso'),
(24, 8, 2, '21/04/2021 15:13:27', '192.168.0.5', 'Man', 'Ingreso a la aplicacion Tipo de caso'),
(25, 6, 1, '21/04/2021 15:13:27', '192.168.0.5', 'Man', 'Logeo Exitoso'),
(26, 6, 2, '21/04/2021 15:13:27', '192.168.0.5', 'Man', 'Ingreso a la aplicacion Tipo de caso'),
(27, 6, 2, '21/04/2021 15:13:27', '192.168.0.5', 'Man', ' INSERT INTO dvd VALUES ( 1,  Hard Day,  1,  Película de Acción en Navidad,  John McTiernan,  25,  6,  Terror) '),
(28, 8, 1, '21/04/2021 15:21:03', '192.168.0.5', 'Man', 'Logeo Exitoso'),
(29, 8, 2, '21/04/2021 15:21:03', '192.168.0.5', 'Man', 'Ingreso a la aplicacion Tipo de caso'),
(30, 8, 2, '21/04/2021 15:21:03', '192.168.0.5', 'Man', ' INSERT INTO dvd VALUES ( 1,  Oblivion,  1,  Se ha tenido una aventura,  James Cameron,  25.55,  25,  Fantasía) '),
(31, 8, 2, '21/04/2021 15:21:03', '192.168.0.5', 'Man', ' INSERT INTO dvd VALUES ( 1,  qweqwe,  1,  aedadsad,  asdasdasd,  4564,  45,  Fantasía) '),
(32, 8, 2, '21/04/2021 15:21:03', '192.168.0.5', 'Man', 'Ingreso a la aplicacion Tipo de caso'),
(33, 8, 2, '21/04/2021 15:21:03', '192.168.0.5', 'Man', 'Ingreso a la aplicacion Tipo de caso'),
(34, 8, 2, '21/04/2021 15:21:03', '192.168.0.5', 'Man', 'Ingreso a la aplicacion Tipo de caso'),
(35, 8, 1, '21/04/2021 15:25:46', '192.168.0.5', 'Man', 'Logeo Exitoso'),
(36, 8, 2, '21/04/2021 15:25:46', '192.168.0.5', 'Man', 'Ingreso a la aplicacion Tipo de caso'),
(37, 8, 2, '21/04/2021 15:25:46', '192.168.0.5', 'Man', ' INSERT INTO dvd VALUES ( 1,  Oblivion,  1,  Pelicula de ciencia ficcion con fantasía,  James Cameron,  2312,  234,  Fantasía) '),
(38, 8, 2, '21/04/2021 15:25:46', '192.168.0.5', 'Man', ' INSERT INTO dvd VALUES ( 1,  asdasd,  1,  asdasd,  asdasd12,  123,  123,  Fantasía) '),
(39, 8, 1, '21/04/2021 15:31:43', '192.168.0.5', 'Man', 'Logeo Exitoso'),
(40, 8, 2, '21/04/2021 15:31:43', '192.168.0.5', 'Man', 'Ingreso a la aplicacion Tipo de caso'),
(41, 8, 2, '21/04/2021 15:31:43', '192.168.0.5', 'Man', ' INSERT INTO dvd VALUES ( 1,  Oblivion,  1,  Pelicula de accion y fantasia,  James Cameron,  321,  45,  Fantasía) '),
(42, 8, 2, '21/04/2021 15:31:43', '192.168.0.5', 'Man', ' INSERT INTO dvd VALUES ( 1,  qweqwe,  1,  qweqwe,  qweqwe,  123,  12,  Fantasía) '),
(43, 8, 2, '21/04/2021 15:31:43', '192.168.0.5', 'Man', 'Ingreso a la aplicacion Tipo de caso'),
(44, 8, 2, '21/04/2021 15:31:43', '192.168.0.5', 'Man', ' INSERT INTO juegos VALUES ( 1,  qweqwe,  1,  123,  123,  Acción,  qweqwe,  qweqwe) '),
(45, 8, 1, '21/04/2021 15:35:58', '192.168.0.5', 'Man', 'Logeo Exitoso'),
(46, 8, 2, '21/04/2021 15:35:58', '192.168.0.5', 'Man', 'Ingreso a la aplicacion Tipo de caso'),
(47, 8, 2, '21/04/2021 15:35:58', '192.168.0.5', 'Man', ' INSERT INTO dvd VALUES ( 1,  qweqwe,  1,  qweqwe,  asdasd,  123,  123,  1) '),
(48, 8, 2, '21/04/2021 15:35:58', '192.168.0.5', 'Man', ' INSERT INTO dvd VALUES ( 1,  123123,  1,  123213,  qweqwe,  123123,  123123,  1) '),
(49, 8, 1, '21/04/2021 16:15:38', '192.168.0.5', 'Man', 'Logeo Exitoso'),
(50, 8, 2, '21/04/2021 16:15:38', '192.168.0.5', 'Man', 'Ingreso a la aplicacion Tipo de caso'),
(51, 8, 1, '21/04/2021 16:17:04', '192.168.0.5', 'Man', 'Logeo Exitoso'),
(52, 8, 2, '21/04/2021 16:17:04', '192.168.0.5', 'Man', 'Ingreso a la aplicacion Tipo de caso'),
(53, 8, 1, '21/04/2021 16:18:14', '192.168.0.5', 'Man', 'Logeo Exitoso'),
(54, 8, 2, '21/04/2021 16:18:14', '192.168.0.5', 'Man', 'Ingreso a la aplicacion Tipo de caso'),
(55, 8, 1, '21/04/2021 16:22:35', '192.168.0.5', 'Man', 'Logeo Exitoso'),
(56, 8, 2, '21/04/2021 16:22:35', '192.168.0.5', 'Man', 'Ingreso a la aplicacion Tipo de caso');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `pk_id_cliente` int(10) NOT NULL,
  `nombres_cliente` varchar(50) DEFAULT NULL,
  `apellidos_cliente` varchar(50) DEFAULT NULL,
  `dpi_cliente` int(10) DEFAULT NULL,
  `telefono_cliente` int(10) DEFAULT NULL,
  `correo_cliente` varchar(50) DEFAULT NULL,
  `estado` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`pk_id_cliente`, `nombres_cliente`, `apellidos_cliente`, `dpi_cliente`, `telefono_cliente`, `correo_cliente`, `estado`) VALUES
(1, 'Mario Jose', 'Lopez Lopez', 123213123, 465656, '3123123', 1),
(2, 'Jose Jorge', 'Lopez Barahona', 465546465, 123123, '645654465', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_bitacora`
--

CREATE TABLE `detalle_bitacora` (
  `pk_id_detalle_bitacora` int(10) NOT NULL,
  `fk_idbitacora_detalle_bitacora` int(10) DEFAULT NULL,
  `querryantigua_detalle_bitacora` varchar(50) DEFAULT NULL,
  `querrynueva_detalle_bitacora` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_registro_anual`
--

CREATE TABLE `detalle_registro_anual` (
  `pk_id_detalle` int(10) NOT NULL,
  `fk_id_ra` int(5) DEFAULT NULL,
  `total_gastado` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `dvd`
--

CREATE TABLE `dvd` (
  `pk_id_dvd` int(10) NOT NULL,
  `nombre_dvd` varchar(50) DEFAULT NULL,
  `descripcion_dvd` varchar(50) DEFAULT NULL,
  `autor_dvd` varchar(50) DEFAULT NULL,
  `fk_idtipo` int(10) DEFAULT NULL,
  `precio_dia_dvd` varchar(50) DEFAULT NULL,
  `existencia_dvd` varchar(50) DEFAULT NULL,
  `estado` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `dvd`
--

INSERT INTO `dvd` (`pk_id_dvd`, `nombre_dvd`, `descripcion_dvd`, `autor_dvd`, `fk_idtipo`, `precio_dia_dvd`, `existencia_dvd`, `estado`) VALUES
(1, 'Oblivion', 'Pelicula de Accion y Fantasia', 'James Cameron', 2, '256.25', '25', 1),
(2, 'Terminator', 'Pelicula de accion y suspenso', 'James Cameorn', 2, '300.00', '50', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `encabezado_registro_anual`
--

CREATE TABLE `encabezado_registro_anual` (
  `pk_id_ra` int(10) NOT NULL,
  `fk_id_cliente` int(5) DEFAULT NULL,
  `fk_id_dvd` int(5) DEFAULT NULL,
  `fk_id_juego` int(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `juegos`
--

CREATE TABLE `juegos` (
  `pk_id_juego` int(10) NOT NULL,
  `nombre_juego` varchar(50) DEFAULT NULL,
  `descripcion_juego` varchar(50) DEFAULT NULL,
  `autor_juego` varchar(50) DEFAULT NULL,
  `fk_idtipo` int(10) DEFAULT NULL,
  `precio_dia_juego` varchar(50) DEFAULT NULL,
  `existencia_juego` varchar(50) DEFAULT NULL,
  `estado` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `juegos`
--

INSERT INTO `juegos` (`pk_id_juego`, `nombre_juego`, `descripcion_juego`, `autor_juego`, `fk_idtipo`, `precio_dia_juego`, `existencia_juego`, `estado`) VALUES
(1, 'Resident Evil', 'Juego de Survival Horror', 'Capcom', 1, '250', '350', 1),
(2, 'Final Fantasy', 'Juego RPG de Acción y aventura', 'Square Soft', 3, '250', '123', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `login`
--

CREATE TABLE `login` (
  `pk_id_login` int(10) NOT NULL,
  `usuario_login` varchar(45) DEFAULT NULL,
  `contraseña_login` varchar(45) DEFAULT NULL,
  `nombreCompleto_login` varchar(100) DEFAULT NULL,
  `estado_login` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `login`
--

INSERT INTO `login` (`pk_id_login`, `usuario_login`, `contraseña_login`, `nombreCompleto_login`, `estado_login`) VALUES
(1, 'sistema', 'bi0PL96rbxVRPKJQsLJJAg==', 'Usuario de prueba', 1),
(2, 'bjsican', '0FOYy5u5h0djKjzCYqfvkg==', 'Billy Sican', 1),
(3, 'bmaza', 'xTfsC3/XR/CVyDvNr1Fs+g==', 'Bryan Mazariegos', 1),
(4, 'jsican', 'jsican', 'Jeshua Sican', 0),
(5, 'jmorataya', '123', 'Julio Morataya', 0),
(6, 'JLOPEZ', 'LwUsihMe9Bl//D/5WaIzLA==', 'JOSE LOPEZ', 1),
(7, 'cliente', '21LRuDS2GcjNgOcK8q54Aw==', 'Usuario para clientes', 1),
(8, 'Man', 'bfcX++36cvYV3gXb8nuJdw==', 'Manuel', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `modulo`
--

CREATE TABLE `modulo` (
  `pk_id_modulo` int(10) NOT NULL,
  `nombre_modulo` varchar(30) NOT NULL,
  `descripcion_modulo` varchar(50) NOT NULL,
  `estado_modulo` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `modulo`
--

INSERT INTO `modulo` (`pk_id_modulo`, `nombre_modulo`, `descripcion_modulo`, `estado_modulo`) VALUES
(1, 'Seguridad', 'Aplicaciones de seguridad', 1),
(2, 'Consultas', 'Consultas Inteligentes', 1),
(3, 'Reporteador', 'Aplicaciones de Reporteador', 1),
(4, 'HRM', 'Aplicaciones de Recursos Humanos', 1),
(5, 'FRM', 'Aplicaciones de Finanzas', 1),
(6, 'SCM', 'Aplicaciones Control de Inventario', 1),
(7, 'MRP', 'Aplicaciones de Produccion', 1),
(8, 'CRM', 'Aplicaciones de Ventas', 1),
(9, 'PRUEBA', 'PRUEBA', 1),
(10, 'Gestión de Citas', 'En este modulo se pueden gestionar las citas', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfil`
--

CREATE TABLE `perfil` (
  `pk_id_perfil` int(10) NOT NULL,
  `nombre_perfil` varchar(50) DEFAULT NULL,
  `descripcion_perfil` varchar(100) DEFAULT NULL,
  `estado_perfil` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `perfil`
--

INSERT INTO `perfil` (`pk_id_perfil`, `nombre_perfil`, `descripcion_perfil`, `estado_perfil`) VALUES
(1, 'Admin', 'Administracion del programa', 1),
(2, 'Sistema', 'Administrador del sistema', 1),
(3, 'Digitador', 'Digitador para Cuentas', 1),
(4, 'Consultor', 'Unicamente consultas ', 1),
(5, 'Reportes', 'Ingreso y consultas de reportes', 1),
(6, 'Pruebas', 'pruebas', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfil_usuario`
--

CREATE TABLE `perfil_usuario` (
  `pk_id_perfil_usuario` int(10) NOT NULL,
  `fk_idusuario_perfil_usuario` int(10) DEFAULT NULL,
  `fk_idperfil_perfil_usuario` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `perfil_usuario`
--

INSERT INTO `perfil_usuario` (`pk_id_perfil_usuario`, `fk_idusuario_perfil_usuario`, `fk_idperfil_perfil_usuario`) VALUES
(2, 3, 3),
(4, 4, 1),
(5, 5, 5),
(6, 1, 1),
(7, 8, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `permiso`
--

CREATE TABLE `permiso` (
  `pk_id_permiso` int(10) NOT NULL,
  `insertar_permiso` tinyint(1) DEFAULT NULL,
  `modificar_permiso` tinyint(1) DEFAULT NULL,
  `eliminar_permiso` tinyint(1) DEFAULT NULL,
  `consultar_permiso` tinyint(1) DEFAULT NULL,
  `imprimir_permiso` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `permiso`
--

INSERT INTO `permiso` (`pk_id_permiso`, `insertar_permiso`, `modificar_permiso`, `eliminar_permiso`, `consultar_permiso`, `imprimir_permiso`) VALUES
(1, 1, 1, 1, 1, 1),
(2, 1, 0, 0, 1, 1),
(3, 1, 1, 1, 0, 0),
(4, 1, 1, 1, 1, 1),
(5, 1, 1, 1, 1, 1),
(6, 1, 1, 1, 1, 1),
(7, 1, 1, 1, 1, 1),
(8, 1, 0, 1, 0, 0),
(9, 1, 1, 0, 0, 0),
(10, 1, 1, 0, 0, 0),
(11, 1, 1, 1, 1, 1),
(12, 0, 0, 0, 1, 0),
(13, 0, 0, 0, 1, 0),
(14, 0, 0, 0, 0, 0),
(15, 1, 0, 0, 1, 0),
(16, 0, 0, 0, 0, 0),
(17, 1, 1, 0, 0, 0),
(18, 0, 0, 0, 0, 0),
(19, 0, 0, 0, 0, 0),
(20, 0, 0, 0, 0, 0),
(21, 0, 0, 0, 0, 0),
(22, 0, 0, 0, 0, 0),
(23, 0, 0, 0, 0, 0),
(24, 0, 0, 0, 0, 0),
(25, 0, 0, 0, 0, 0),
(26, 0, 0, 0, 0, 0),
(27, 0, 0, 0, 0, 0),
(28, 0, 0, 0, 0, 0),
(29, 0, 0, 0, 0, 0),
(30, 0, 0, 0, 0, 0),
(31, 0, 0, 0, 0, 0),
(32, 0, 0, 0, 0, 0),
(33, 0, 0, 0, 0, 0),
(34, 0, 0, 0, 0, 0),
(35, 0, 0, 0, 0, 0),
(36, 0, 0, 0, 0, 0),
(37, 0, 0, 0, 0, 0),
(38, 0, 0, 0, 0, 0),
(39, 0, 0, 0, 0, 0),
(40, 0, 0, 0, 0, 0),
(41, 0, 0, 0, 0, 0),
(42, 0, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `renta_dvd`
--

CREATE TABLE `renta_dvd` (
  `pk_id_renta_dvd` int(10) NOT NULL,
  `fk_id_cliente` int(5) DEFAULT NULL,
  `fk_id_dvd` int(5) DEFAULT NULL,
  `dias_renta` int(10) DEFAULT NULL,
  `costo_renta` int(10) DEFAULT NULL,
  `fecha_vencimiento` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `renta_juego`
--

CREATE TABLE `renta_juego` (
  `pk_id_renta_juego` int(10) NOT NULL,
  `fk_id_cliente` int(5) DEFAULT NULL,
  `fk_id_juego` int(5) DEFAULT NULL,
  `dias_renta` int(10) DEFAULT NULL,
  `costo_renta` int(10) DEFAULT NULL,
  `fecha_vencimiento` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo`
--

CREATE TABLE `tipo` (
  `pk_id_tipo` int(10) NOT NULL,
  `nombre_tipo` varchar(50) DEFAULT NULL,
  `estado` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tipo`
--

INSERT INTO `tipo` (`pk_id_tipo`, `nombre_tipo`, `estado`) VALUES
(1, 'Terror', 1),
(2, 'Acción', 1),
(3, 'Fantasía', 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `aplicacion`
--
ALTER TABLE `aplicacion`
  ADD PRIMARY KEY (`pk_id_aplicacion`),
  ADD KEY `pk_id_aplicacion` (`pk_id_aplicacion`),
  ADD KEY `fk_aplicacion_modulo` (`fk_id_modulo`);

--
-- Indices de la tabla `aplicacion_perfil`
--
ALTER TABLE `aplicacion_perfil`
  ADD PRIMARY KEY (`pk_id_aplicacion_perfil`),
  ADD KEY `fk_aplicacionperfil_aplicacion` (`fk_idaplicacion_aplicacion_perfil`),
  ADD KEY `fk_aplicacionperfil_perfil` (`fk_idperfil_aplicacion_perfil`),
  ADD KEY `fk_aplicacionperfil_permiso` (`fk_idpermiso_aplicacion_perfil`);

--
-- Indices de la tabla `aplicacion_usuario`
--
ALTER TABLE `aplicacion_usuario`
  ADD PRIMARY KEY (`pk_id_aplicacion_usuario`),
  ADD KEY `fk_aplicacionusuario_login` (`fk_idlogin_aplicacion_usuario`),
  ADD KEY `fk_aplicacionusuario_aplicacion` (`fk_idaplicacion_aplicacion_usuario`),
  ADD KEY `fk_aplicacionusuario_permiso` (`fk_idpermiso_aplicacion_usuario`);

--
-- Indices de la tabla `bitacora`
--
ALTER TABLE `bitacora`
  ADD PRIMARY KEY (`pk_id_bitacora`),
  ADD KEY `fk_login_bitacora` (`fk_idusuario_bitacora`),
  ADD KEY `fk_aplicacion_bitacora` (`fk_idaplicacion_bitacora`);

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`pk_id_cliente`);

--
-- Indices de la tabla `detalle_bitacora`
--
ALTER TABLE `detalle_bitacora`
  ADD PRIMARY KEY (`pk_id_detalle_bitacora`),
  ADD KEY `fk_bitacora_detallebitacora` (`fk_idbitacora_detalle_bitacora`);

--
-- Indices de la tabla `detalle_registro_anual`
--
ALTER TABLE `detalle_registro_anual`
  ADD PRIMARY KEY (`pk_id_detalle`),
  ADD KEY `fk_detalle_ra` (`fk_id_ra`);

--
-- Indices de la tabla `dvd`
--
ALTER TABLE `dvd`
  ADD PRIMARY KEY (`pk_id_dvd`),
  ADD KEY `fk_dvd_tipo` (`fk_idtipo`);

--
-- Indices de la tabla `encabezado_registro_anual`
--
ALTER TABLE `encabezado_registro_anual`
  ADD PRIMARY KEY (`pk_id_ra`),
  ADD KEY `fk_ra_cliente` (`fk_id_cliente`),
  ADD KEY `fk_ra_dvd` (`fk_id_dvd`),
  ADD KEY `fk_ra_juego` (`fk_id_juego`);

--
-- Indices de la tabla `juegos`
--
ALTER TABLE `juegos`
  ADD PRIMARY KEY (`pk_id_juego`),
  ADD KEY `fk_juegos_tipo` (`fk_idtipo`);

--
-- Indices de la tabla `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`pk_id_login`);

--
-- Indices de la tabla `modulo`
--
ALTER TABLE `modulo`
  ADD PRIMARY KEY (`pk_id_modulo`),
  ADD KEY `pk_id_modulo` (`pk_id_modulo`);

--
-- Indices de la tabla `perfil`
--
ALTER TABLE `perfil`
  ADD PRIMARY KEY (`pk_id_perfil`);

--
-- Indices de la tabla `perfil_usuario`
--
ALTER TABLE `perfil_usuario`
  ADD PRIMARY KEY (`pk_id_perfil_usuario`),
  ADD KEY `fk_perfil_usuario_login` (`fk_idusuario_perfil_usuario`),
  ADD KEY `fk_perfil_usuario_perfil` (`fk_idperfil_perfil_usuario`);

--
-- Indices de la tabla `permiso`
--
ALTER TABLE `permiso`
  ADD PRIMARY KEY (`pk_id_permiso`);

--
-- Indices de la tabla `renta_dvd`
--
ALTER TABLE `renta_dvd`
  ADD PRIMARY KEY (`pk_id_renta_dvd`),
  ADD KEY `fk_renta_cliente_dvd` (`fk_id_cliente`),
  ADD KEY `fk_renta_dvd` (`fk_id_dvd`);

--
-- Indices de la tabla `renta_juego`
--
ALTER TABLE `renta_juego`
  ADD PRIMARY KEY (`pk_id_renta_juego`),
  ADD KEY `fk_renta_cliente_juego` (`fk_id_cliente`),
  ADD KEY `fk_renta_juego` (`fk_id_juego`);

--
-- Indices de la tabla `tipo`
--
ALTER TABLE `tipo`
  ADD PRIMARY KEY (`pk_id_tipo`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `aplicacion`
--
ALTER TABLE `aplicacion`
  MODIFY `pk_id_aplicacion` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1313;

--
-- AUTO_INCREMENT de la tabla `aplicacion_perfil`
--
ALTER TABLE `aplicacion_perfil`
  MODIFY `pk_id_aplicacion_perfil` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de la tabla `aplicacion_usuario`
--
ALTER TABLE `aplicacion_usuario`
  MODIFY `pk_id_aplicacion_usuario` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT de la tabla `bitacora`
--
ALTER TABLE `bitacora`
  MODIFY `pk_id_bitacora` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=57;

--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `pk_id_cliente` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `detalle_bitacora`
--
ALTER TABLE `detalle_bitacora`
  MODIFY `pk_id_detalle_bitacora` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `detalle_registro_anual`
--
ALTER TABLE `detalle_registro_anual`
  MODIFY `pk_id_detalle` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `dvd`
--
ALTER TABLE `dvd`
  MODIFY `pk_id_dvd` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `encabezado_registro_anual`
--
ALTER TABLE `encabezado_registro_anual`
  MODIFY `pk_id_ra` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `juegos`
--
ALTER TABLE `juegos`
  MODIFY `pk_id_juego` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `login`
--
ALTER TABLE `login`
  MODIFY `pk_id_login` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `modulo`
--
ALTER TABLE `modulo`
  MODIFY `pk_id_modulo` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de la tabla `perfil`
--
ALTER TABLE `perfil`
  MODIFY `pk_id_perfil` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `perfil_usuario`
--
ALTER TABLE `perfil_usuario`
  MODIFY `pk_id_perfil_usuario` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `permiso`
--
ALTER TABLE `permiso`
  MODIFY `pk_id_permiso` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=43;

--
-- AUTO_INCREMENT de la tabla `renta_dvd`
--
ALTER TABLE `renta_dvd`
  MODIFY `pk_id_renta_dvd` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `renta_juego`
--
ALTER TABLE `renta_juego`
  MODIFY `pk_id_renta_juego` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tipo`
--
ALTER TABLE `tipo`
  MODIFY `pk_id_tipo` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `aplicacion`
--
ALTER TABLE `aplicacion`
  ADD CONSTRAINT `fk_aplicacion_modulo` FOREIGN KEY (`fk_id_modulo`) REFERENCES `modulo` (`pk_id_modulo`);

--
-- Filtros para la tabla `aplicacion_perfil`
--
ALTER TABLE `aplicacion_perfil`
  ADD CONSTRAINT `fk_aplicacionperfil_aplicacion` FOREIGN KEY (`fk_idaplicacion_aplicacion_perfil`) REFERENCES `aplicacion` (`pk_id_aplicacion`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_aplicacionperfil_perfil` FOREIGN KEY (`fk_idperfil_aplicacion_perfil`) REFERENCES `perfil` (`pk_id_perfil`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_aplicacionperfil_permiso` FOREIGN KEY (`fk_idpermiso_aplicacion_perfil`) REFERENCES `permiso` (`pk_id_permiso`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `aplicacion_usuario`
--
ALTER TABLE `aplicacion_usuario`
  ADD CONSTRAINT `fk_aplicacionusuario_aplicacion` FOREIGN KEY (`fk_idaplicacion_aplicacion_usuario`) REFERENCES `aplicacion` (`pk_id_aplicacion`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_aplicacionusuario_login` FOREIGN KEY (`fk_idlogin_aplicacion_usuario`) REFERENCES `login` (`pk_id_login`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_aplicacionusuario_permiso` FOREIGN KEY (`fk_idpermiso_aplicacion_usuario`) REFERENCES `permiso` (`pk_id_permiso`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `bitacora`
--
ALTER TABLE `bitacora`
  ADD CONSTRAINT `fk_aplicacion_bitacora` FOREIGN KEY (`fk_idaplicacion_bitacora`) REFERENCES `aplicacion` (`pk_id_aplicacion`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_login_bitacora` FOREIGN KEY (`fk_idusuario_bitacora`) REFERENCES `login` (`pk_id_login`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `detalle_bitacora`
--
ALTER TABLE `detalle_bitacora`
  ADD CONSTRAINT `fk_bitacora_detallebitacora` FOREIGN KEY (`fk_idbitacora_detalle_bitacora`) REFERENCES `bitacora` (`pk_id_bitacora`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `detalle_registro_anual`
--
ALTER TABLE `detalle_registro_anual`
  ADD CONSTRAINT `fk_detalle_ra` FOREIGN KEY (`fk_id_ra`) REFERENCES `encabezado_registro_anual` (`pk_id_ra`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `dvd`
--
ALTER TABLE `dvd`
  ADD CONSTRAINT `fk_dvd_tipo` FOREIGN KEY (`fk_idtipo`) REFERENCES `tipo` (`pk_id_tipo`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `encabezado_registro_anual`
--
ALTER TABLE `encabezado_registro_anual`
  ADD CONSTRAINT `fk_ra_cliente` FOREIGN KEY (`fk_id_cliente`) REFERENCES `clientes` (`pk_id_cliente`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_ra_dvd` FOREIGN KEY (`fk_id_dvd`) REFERENCES `dvd` (`pk_id_dvd`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_ra_juego` FOREIGN KEY (`fk_id_juego`) REFERENCES `juegos` (`pk_id_juego`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `juegos`
--
ALTER TABLE `juegos`
  ADD CONSTRAINT `fk_juegos_tipo` FOREIGN KEY (`fk_idtipo`) REFERENCES `tipo` (`pk_id_tipo`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `perfil_usuario`
--
ALTER TABLE `perfil_usuario`
  ADD CONSTRAINT `fk_perfil_usuario_login` FOREIGN KEY (`fk_idusuario_perfil_usuario`) REFERENCES `login` (`pk_id_login`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_perfil_usuario_perfil` FOREIGN KEY (`fk_idperfil_perfil_usuario`) REFERENCES `perfil` (`pk_id_perfil`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `renta_dvd`
--
ALTER TABLE `renta_dvd`
  ADD CONSTRAINT `fk_renta_cliente_dvd` FOREIGN KEY (`fk_id_cliente`) REFERENCES `clientes` (`pk_id_cliente`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_renta_dvd` FOREIGN KEY (`fk_id_dvd`) REFERENCES `dvd` (`pk_id_dvd`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `renta_juego`
--
ALTER TABLE `renta_juego`
  ADD CONSTRAINT `fk_renta_cliente_juego` FOREIGN KEY (`fk_id_cliente`) REFERENCES `clientes` (`pk_id_cliente`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_renta_juego` FOREIGN KEY (`fk_id_juego`) REFERENCES `juegos` (`pk_id_juego`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
