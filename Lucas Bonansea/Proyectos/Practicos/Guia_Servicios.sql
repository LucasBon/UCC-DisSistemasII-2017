CREATE DATABASE `guia_servicios`;

CREATE TABLE `rubro` (
  `idrubro` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `padre` int(11) DEFAULT NULL,
  `logo` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idrubro`)
);

CREATE TABLE `empresa` (
  `idempresa` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `direccion` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`idempresa`)
) ;

CREATE TABLE `contacto_empresa` (
  `idcontactoEmpresa` int(11) NOT NULL AUTO_INCREMENT,
  `contacto` varchar(155) DEFAULT NULL,
  `desde` datetime(2) DEFAULT NULL,
  `hasta` datetime(2) DEFAULT NULL,
  PRIMARY KEY (`idcontactoEmpresa`)
) ;

CREATE TABLE `servicio` (
  `idservicio` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `empresa` int(11) DEFAULT NULL,
  `rubro` int(11) DEFAULT NULL,
  `comentarios` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`idservicio`)
) ;



