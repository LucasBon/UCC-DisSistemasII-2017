CREATE DATABASE `iplayadb`;

CREATE TABLE `darsena` (
  `idDarsena` int(11) NOT NULL AUTO_INCREMENT,
  `Numero` int(11) NOT NULL,
  `Estado` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`idDarsena`)
) COMMENT='Representa una darsena de la playa';

CREATE TABLE `estadia` (
  `idEstadia` int(11) NOT NULL AUTO_INCREMENT,
  `entrada` datetime(2) NOT NULL,
  `salida` datetime(2) DEFAULT NULL,
  `codigo` int(11) NOT NULL,
  `dominio` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idEstadia`)
);


