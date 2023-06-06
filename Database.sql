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
INSERT INTO `employee` VALUES (54745236,'Филимонова','Агата','Кирилловна','Ж','2001-01-18','Female1.png','J7h4j9T_',2,1,'Работает.',1,0),(54745238,'Смаков','Дмитрий','Петрович','М','1981-07-10','Male3.png','^i=U_j,9',1,4,'Уволен по распоряжению главы отдела.',1,0),(54745239,'Сигналов','Ахмет','Вазгенович','М','1995-07-07','Сигналов_Ахмет_Вазгенович.png','i5uW!A!P',1,3,'Работает.',1,1),(54745240,'Колесников','Михаил','Арсентьевич','М','1980-02-15','Male2.png','TVAJ%vU7',1,2,'Работает.',1,0),(54745241,'Никитина','Мария','Арсентьевна','Ж','1989-08-24','Female1.png','2ijX^y!Q',1,1,'Работает.',1,0),(54745242,'Свиридова','Василиса','Робертовна','Ж','1981-07-10','Female1.png',':3kj?e_7',1,2,'На проверке.',0,0),(54745243,'Орлова','Злата','Максимовна','Ж','2001-01-18','Female1.png','?JChg~6H',1,3,'Работает.',1,0),(54745244,'Терентьев','Богдан','Артёмович','М','1981-07-10','Male1.png','#=XWJp6@',1,4,'Работает.',1,0),(54745245,'Давыдов','Семён','Александрович','М','1989-08-24','Male3.png','m6+@9EjX',1,1,'Уволен по распоряжению главы отдела.',1,0),(54745246,'Ершов','Кирилл','Фёдорович','М','2001-01-18','Male3.png','Y5av^ApV',1,2,'Работает.',1,0),(54745247,'Максимова','Софья','Артёмовна','Ж','1981-07-10','Female1.png','x5y%PqWp',2,3,'Работает.',1,0),(54745248,'Трифонов','Артём','Юрьевич','М','1989-08-24','Male1.png','J3p:Caay',2,4,'Работает.',1,0),(54745249,'Зуева','Эвелина','Платоновна','Ж','2001-01-18','Female1.png','s9PQ]?p]',2,1,'Работает.',1,0),(54745250,'Егоров','Алексей','Максимович','М','1981-07-10','Male3.png','rWL?CDh4',1,2,'На проверке.',0,0),(54745251,'Поляков','Иван','Русланович','М','1981-07-10','Male3.png','d!i>4h2:',2,3,'Работает.',1,0),(54745252,'Богданова','Алиса','Павловна','Ж','2001-01-18','Female1.png','xq3gUCuR',1,4,'Работает.',1,0),(54745253,'Карасев','Пётр','Русланович','М','1989-08-24','Male1.png','oHhsx05L',2,1,'Работает.',1,0),(54745254,'Бобров','Елисей','Тимурович','М','1981-07-10','Male3.png','stB9Vk0M',2,2,'Работает.',1,0),(54745255,'Иванова','Марьяна','Кирилловна','Ж','1981-07-10','Female1.png','k1DPJi61',2,3,'Уволен по распоряжению главы отдела.',1,0),(54745256,'Зайцева','Арина','Михайловна','Ж','2001-01-18','Female1.png','sNKcA6jN',1,4,'Работает.',1,0),(54745257,'Яковлев','Константин','Вячеславович','М','1981-07-10','Male1.png','T4Q7y3Po',2,1,'Работает.',1,0),(54745258,'Карпова','Анна','Павловна','Ж','1981-07-10','Female1.png','KGKhB7om',2,2,'Уволен по распоряжению главы отдела.',1,0),(54745259,'Мельникова','Юлия','Ивановна','Ж','1981-07-10','Female1.png','02wF3wXP',2,3,'Работает.',1,0),(54745260,'Зуева','Вера','Егоровна','Ж','1989-08-24','Female1.png','3zD5Nj4d',2,4,'На проверке.',0,0),(54745261,'Захаров','Олег','Иванович','М','1981-07-10','Male3.png','hsKr7UTW',1,1,'Работает.',1,0),(54745262,'Зимин','Тимофей','Маркович','М','1981-07-10','Male3.png','DiNEym59',1,2,'Работает.',1,0),(54745263,'Ларионов','Максим','Валерьевич','М','1989-08-24','Male1.png','aDFp2y5f',2,3,'Работает.',1,0),(54745264,'Кузнецова','Анастасия','Тимофеевна','Ж','1981-07-10','Female1.png','r6E1J5wE',1,4,'Работает.',1,0),(54745265,'Захарова','Арина','Семёновна','Ж','1981-07-10','Female1.png','Rzw5sVob',1,1,'Уволен по распоряжению главы отдела.',1,0),(54745266,'Цветкова','Маргарита','Ильинична','Ж','1981-07-10','Female1.png','dJhFnoY2',2,2,'Работает.',1,0),(54745267,'Андреева','Таисия','Марковна','Ж','1989-08-24','Female1.png','QjHHp2y7',2,3,'Работает.',1,0),(54745268,'Еремина','Екатерина','Сергеевна','Ж','1981-07-10','Female1.png','i1C8Tkg2',1,4,'Работает.',1,0),(54745269,'Столяров','Владимир','Андреевич','М','1981-07-10','Male1.png','aagHXgg2',1,1,'Работает.',1,0);
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
INSERT INTO `logs` VALUES ('2023-05-23 18:28:42','Сотрудник отдела кадров Агата Филимонова Кирилловна вошла в систему',54745236),('2023-05-23 18:29:13','Сотрудник отдела кадров Агата Филимонова Кирилловна добавила пользователя Сумналов Ашот Владимирович',54745236),('2023-05-23 18:29:16','Сотрудник отдела кадров Агата Филимонова Кирилловна вышла из системы',54745236),('2023-05-23 18:34:08','Начальник цеха Ахмет Сигналов Вазгенович вошел в систему',54745239),('2023-05-23 18:38:05','Работник цеха Дмитрий Смаков Петрович вошел в систему',54745238),('2023-05-23 18:38:29','Работник цеха Дмитрий Смаков Петрович вышел из системы',54745238),('2023-06-05 13:30:19','Сотрудник отдела кадров Агата Филимонова Кирилловна вошла в систему',54745236),('2023-06-05 13:30:23','Сотрудник отдела кадров Агата Филимонова Кирилловна создала свод сотрудников.',54745236),('2023-06-05 13:30:50','Сотрудник отдела кадров Агата Филимонова Кирилловна вышла из системы',54745236),('2023-06-05 13:32:20','Сотрудник службы безопасности Михаил Колесников Арсентьевич вошел в систему',54745240),('2023-06-05 13:32:54','Сотрудник службы безопасности Михаил Колесников Арсентьевич вышел из системы',54745240),('2023-06-05 13:33:06','Начальник цеха Ахмет Сигналов Вазгенович вошел в систему',54745239),('2023-06-05 13:34:04','Начальник цеха Ахмет Сигналов Вазгенович вышел из системы',54745239),('2023-06-05 13:34:14','Работник цеха Дмитрий Смаков Петрович вошел в систему',54745238),('2023-06-05 13:34:16','Работник цеха Дмитрий Смаков Петрович вышел из системы',54745238),('2023-06-05 15:00:20','Сотрудник отдела кадров Агата Филимонова Кирилловна вошла в систему',54745236),('2023-06-05 15:00:28','Сотрудник отдела кадров Агата Филимонова Кирилловна создала свод сотрудников.',54745236),('2023-06-05 15:01:08','Сотрудник отдела кадров Агата Филимонова Кирилловна вышла из системы',54745236),('2023-06-05 15:01:25','Сотрудник службы безопасности Михаил Колесников Арсентьевич вошел в систему',54745240),('2023-06-05 15:02:01','Сотрудник службы безопасности Михаил Колесников Арсентьевич вышел из системы',54745240),('2023-06-05 15:02:14','Начальник цеха Ахмет Сигналов Вазгенович вошел в систему',54745239),('2023-06-05 15:03:41','Начальник цеха Ахмет Сигналов Вазгенович вышел из системы',54745239),('2023-06-05 15:03:52','Работник цеха Дмитрий Смаков Петрович вошел в систему',54745238);
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

-- Dump completed on 2023-06-06  8:29:40
