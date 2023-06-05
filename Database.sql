-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: workshop_control
-- ------------------------------------------------------
-- Server version	8.0.31

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `division`
--

DROP TABLE IF EXISTS `division`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `division` (
  `Id` int NOT NULL,
  `Name` varchar(45) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `division`
--

LOCK TABLES `division` WRITE;
/*!40000 ALTER TABLE `division` DISABLE KEYS */;
INSERT INTO `division` VALUES (1,'Сотрудник отдела кадров'),(2,'Сотрудник службы безопасности'),(3,'Начальник цеха'),(4,'Работник цеха');
/*!40000 ALTER TABLE `division` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee` (
  `Code` int NOT NULL,
  `Surname` varchar(45) NOT NULL,
  `Name` varchar(45) NOT NULL,
  `Patronomic` varchar(45) NOT NULL,
  `Gender` char(1) NOT NULL,
  `Birthdate` date NOT NULL,
  `Photo` varchar(45) DEFAULT 'PlaceholderMale.png',
  `Password` varchar(45) DEFAULT NULL,
  `Workshop` int NOT NULL,
  `Subdivision` int DEFAULT NULL,
  `Status` text,
  `Is_verificated` tinyint NOT NULL DEFAULT '0',
  `CanVisitOtherWorkshops` tinyint NOT NULL DEFAULT '0',
  PRIMARY KEY (`Code`),
  KEY `Division_idx` (`Subdivision`),
  KEY `Workshop_idx` (`Workshop`),
  CONSTRAINT `Division` FOREIGN KEY (`Subdivision`) REFERENCES `division` (`Id`),
  CONSTRAINT `Workshop` FOREIGN KEY (`Workshop`) REFERENCES `workshop` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES (12345678,'Мусифуллин','Тимур','Эдуардович','М','2004-03-30','Male1.png','123123',1,2,'Работает',0,0),(54745236,'Филимонова','Агата','Кирилловна','Ж','2001-01-18','Female1.png','123123',2,1,'Работает',0,0),(54745238,'Смаков','Дмитрий','Петрович','М','1981-07-10','Male3.png','123123',1,4,'Уволен по распоряжению главы отдела.',1,0),(54745239,'Сигналов','Ахмет','Вазгенович','М','1995-07-07','Сигналов_Ахмет_Вазгенович.png','123123123',1,3,'Работает.',0,1);
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `logs`
--

DROP TABLE IF EXISTS `logs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `logs` (
  `Datetime` datetime NOT NULL,
  `Action` text NOT NULL,
  `Employee` int NOT NULL,
  PRIMARY KEY (`Datetime`),
  KEY `Employee1_idx` (`Employee`),
  CONSTRAINT `Employee1` FOREIGN KEY (`Employee`) REFERENCES `employee` (`Code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `logs`
--

LOCK TABLES `logs` WRITE;
/*!40000 ALTER TABLE `logs` DISABLE KEYS */;
INSERT INTO `logs` VALUES ('2023-05-23 18:28:42','Сотрудник отдела кадров Агата Филимонова Кирилловна вошла в систему',54745236),('2023-05-23 18:29:13','Сотрудник отдела кадров Агата Филимонова Кирилловна добавила пользователя Сумналов Ашот Владимирович',54745236),('2023-05-23 18:29:16','Сотрудник отдела кадров Агата Филимонова Кирилловна вышла из системы',54745236),('2023-05-23 18:29:20','Сотрудник службы безопасности Тимур Мусифуллин Эдуардович вошел в систему',12345678),('2023-05-23 18:30:28','Сотрудник службы безопасности Тимур Мусифуллин Эдуардович вошел в систему',12345678),('2023-05-23 18:30:29','Сотрудник службы безопасности Тимур Мусифуллин Эдуардович вышел из системы',12345678),('2023-05-23 18:34:08','Начальник цеха Ахмет Сигналов Вазгенович вошел в систему',54745239),('2023-05-23 18:38:05','Работник цеха Дмитрий Смаков Петрович вошел в систему',54745238),('2023-05-23 18:38:29','Работник цеха Дмитрий Смаков Петрович вышел из системы',54745238);
/*!40000 ALTER TABLE `logs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `request`
--

DROP TABLE IF EXISTS `request`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `request` (
  `Id` int NOT NULL,
  `Employee_making_request` int NOT NULL,
  `Target_employee` int NOT NULL,
  `Discription` text NOT NULL,
  `Accepted` tinyint NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `request`
--

LOCK TABLES `request` WRITE;
/*!40000 ALTER TABLE `request` DISABLE KEYS */;
INSERT INTO `request` VALUES (1,34673472,12345678,'Получить доступ на посещение других цехов',0),(2,34673472,12345678,'Получить доступ на посещение других цехов',0),(3,34673472,12345678,'Получить доступ на посещение других цехов',0);
/*!40000 ALTER TABLE `request` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `workshop`
--

DROP TABLE IF EXISTS `workshop`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `workshop` (
  `Id` int NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `workshop`
--

LOCK TABLES `workshop` WRITE;
/*!40000 ALTER TABLE `workshop` DISABLE KEYS */;
INSERT INTO `workshop` VALUES (1,'Производственный цех №1'),(2,'Коммуникационный центр');
/*!40000 ALTER TABLE `workshop` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'workshop_control'
--

--
-- Dumping routines for database 'workshop_control'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-05-23 18:40:12
