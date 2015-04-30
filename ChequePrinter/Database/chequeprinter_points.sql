CREATE DATABASE  IF NOT EXISTS `chequeprinter` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `chequeprinter`;
-- MySQL dump 10.13  Distrib 5.6.13, for Win32 (x86)
--
-- Host: localhost    Database: chequeprinter
-- ------------------------------------------------------
-- Server version	5.6.14

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `points`
--

DROP TABLE IF EXISTS `points`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `points` (
  `tid` int(11) NOT NULL AUTO_INCREMENT,
  `templatename` varchar(45) DEFAULT NULL,
  `xauth` int(11) DEFAULT NULL,
  `xperpay` int(11) DEFAULT NULL,
  `yperpay` int(11) DEFAULT NULL,
  `xdate` int(11) DEFAULT NULL,
  `ydate` int(11) DEFAULT NULL,
  `xpayword` int(11) DEFAULT NULL,
  `ypayword` int(11) DEFAULT NULL,
  `xpaydig` int(11) DEFAULT NULL,
  `ypaydig` int(11) DEFAULT NULL,
  `yauth` int(11) DEFAULT NULL,
  `col` varchar(45) DEFAULT NULL,
  `chec` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`tid`),
  UNIQUE KEY `templatename_UNIQUE` (`templatename`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `points`
--

LOCK TABLES `points` WRITE;
/*!40000 ALTER TABLE `points` DISABLE KEYS */;
INSERT INTO `points` VALUES (4,'fir',422,116,3,631,14,11,68,567,68,174,'C0C0C0',0),(5,'dsa',422,116,3,631,14,11,68,567,68,174,'',0),(6,'checking',39,47,0,538,87,14,201,371,112,59,'C0C0C0',0),(7,'tr1',422,57,15,631,14,52,58,79,172,174,'80FFFF',0);
/*!40000 ALTER TABLE `points` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2013-10-19 13:47:12
