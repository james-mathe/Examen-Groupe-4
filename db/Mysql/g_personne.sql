-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: May 06, 2025 at 10:26 PM
-- Server version: 8.0.30
-- PHP Version: 8.2.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `g_personne`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `AddAddress` (`idPs` BIGINT, `av` VARCHAR(250), `qua` VARCHAR(250), `com` VARCHAR(250), `villes` VARCHAR(250), `payss` VARCHAR(250))   begin
	insert into adresse(idP,avenue,quartier,commune,ville,pays) values(idPs,av,qua,com,villes,payss);
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `AddPerson` (`noms` VARCHAR(250), `pnom` VARCHAR(250), `prnom` VARCHAR(250), `sex` CHAR(1))   begin
	insert into personne(nom,postnom,prenom,sexe) values(noms,pnom,prnom,sex);
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `AddPhone` (`idPs` BIGINT, `initials` VARCHAR(4), `numeros` VARCHAR(9))   begin
	insert into telephone(idP,initial,numero) values(idPs,initials,numeros);
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `AddUser` (`usernames` VARCHAR(250), `pwds` VARCHAR(250))   begin
	insert into users(username,pwd) values(usernames,pwds);
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteAddress` (`id` BIGINT)   begin
	delete from adresse  where idA=id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DeletePerson` (`id` BIGINT)   begin
	delete from personne  where idP=id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DeletePhone` (`id` BIGINT)   begin
	delete from telephone where idT=id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteUser` (`id` BIGINT)   begin
	delete from users where idU=id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SearchAddress` (`fullnames` VARCHAR(250), `av` VARCHAR(250), `qua` VARCHAR(250), `com` VARCHAR(250), `villes` VARCHAR(250), `payss` VARCHAR(250))   begin
	select * from listPersonAddress where fullname like CONCAT('%',fullnames,'%') or avenue like CONCAT('%',av,'%') or quartier like CONCAT('%',qua,'%') or ville like CONCAT('%',villes,'%') or commune like CONCAT('%',com,'%') or pays like CONCAT('%',payss,'%');
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SearchPerson` (`noms` VARCHAR(250), `pnom` VARCHAR(250), `prnom` VARCHAR(250), `sex` CHAR(1))   begin
	select * from personne  where nom like CONCAT('%',noms,'%') or postnom like CONCAT('%',pnom,'%') or prenom like CONCAT('%',prnom,'%') or sexe like CONCAT('%',sex,'%');
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SearchPhone` (`fullnames` VARCHAR(250), `initials` VARCHAR(4), `numeros` VARCHAR(9))   begin
	select * from listPersonNumber where fullname like CONCAT('%',fullnames,'%') or initial like CONCAT('%',initials,'%') or numero like CONCAT('%',numeros,'%');
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SearchUser` (`usernames` VARCHAR(250))   begin
	select * from users where username like CONCAT('%',usernames,'%');
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateAddress` (`id` BIGINT, `idPs` BIGINT, `av` VARCHAR(250), `qua` VARCHAR(250), `com` VARCHAR(250), `villes` VARCHAR(250), `payss` VARCHAR(250))   begin
	update adresse set idP=idPs,avenue=av,quartier=qua,commune=com,ville=villes,pays=payss where idA=id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdatePerson` (`id` BIGINT, `noms` VARCHAR(250), `pnom` VARCHAR(250), `prnom` VARCHAR(250), `sex` CHAR(1))   begin
	update personne set nom=noms,postnom=pnom,prenom=prnom,sexe=sex where idP=id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdatePhone` (`id` BIGINT, `idPs` BIGINT, `initials` VARCHAR(4), `numeros` VARCHAR(9))   begin
	update telephone set idP=idPs,initial=initials,numero=numeros where idT=id;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateUser` (`id` BIGINT, `usernames` VARCHAR(250), `pwds` VARCHAR(250))   begin
	Update users set username=usernames,pwd=pwds where idU=id;
end$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `adresse`
--

CREATE TABLE `adresse` (
  `idA` bigint NOT NULL,
  `idP` bigint NOT NULL,
  `avenue` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `quartier` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `commune` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `ville` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `pays` varchar(50) COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Stand-in structure for view `listpersonaddress`
-- (See below for the actual view)
--
CREATE TABLE `listpersonaddress` (
`idA` bigint
,`idP` bigint
,`fullname` varchar(152)
,`avenue` varchar(50)
,`quartier` varchar(50)
,`ville` varchar(50)
,`commune` varchar(50)
,`pays` varchar(50)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `listpersonnumber`
-- (See below for the actual view)
--
CREATE TABLE `listpersonnumber` (
`idT` bigint
,`idP` bigint
,`fullname` varchar(152)
,`initial` varchar(4)
,`numero` varchar(9)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `listpersonwithnumberandaddress`
-- (See below for the actual view)
--
CREATE TABLE `listpersonwithnumberandaddress` (
`idP` bigint
,`fullname` varchar(152)
,`initial` varchar(4)
,`numero` varchar(9)
,`avenue` varchar(50)
,`quartier` varchar(50)
,`commune` varchar(50)
,`ville` varchar(50)
,`pays` varchar(50)
);

-- --------------------------------------------------------

--
-- Table structure for table `personne`
--

CREATE TABLE `personne` (
  `idP` bigint NOT NULL,
  `nom` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `postnom` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `prenom` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `sexe` varchar(1) COLLATE utf8mb4_general_ci NOT NULL DEFAULT 'M'
) ;

-- --------------------------------------------------------

--
-- Table structure for table `telephone`
--

CREATE TABLE `telephone` (
  `idT` bigint NOT NULL,
  `idP` bigint NOT NULL,
  `initial` varchar(4) COLLATE utf8mb4_general_ci NOT NULL,
  `numero` varchar(9) COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `idU` bigint NOT NULL,
  `username` varchar(250) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `pwd` varchar(250) COLLATE utf8mb4_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`idU`, `username`, `pwd`) VALUES
(1, 'admin', 'admin');

-- --------------------------------------------------------

--
-- Structure for view `listpersonaddress`
--
DROP TABLE IF EXISTS `listpersonaddress`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `listpersonaddress`  AS SELECT `a`.`idA` AS `idA`, `a`.`idP` AS `idP`, concat(`p`.`nom`,' ',`p`.`postnom`,' ',`p`.`prenom`) AS `fullname`, `a`.`avenue` AS `avenue`, `a`.`quartier` AS `quartier`, `a`.`ville` AS `ville`, `a`.`commune` AS `commune`, `a`.`pays` AS `pays` FROM (`adresse` `a` join `personne` `p` on((`a`.`idP` = `p`.`idP`))) ;

-- --------------------------------------------------------

--
-- Structure for view `listpersonnumber`
--
DROP TABLE IF EXISTS `listpersonnumber`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `listpersonnumber`  AS SELECT `t`.`idT` AS `idT`, `t`.`idP` AS `idP`, concat(`p`.`nom`,' ',`p`.`postnom`,' ',`p`.`prenom`) AS `fullname`, `t`.`initial` AS `initial`, `t`.`numero` AS `numero` FROM (`telephone` `t` join `personne` `p` on((`t`.`idP` = `p`.`idP`))) ;

-- --------------------------------------------------------

--
-- Structure for view `listpersonwithnumberandaddress`
--
DROP TABLE IF EXISTS `listpersonwithnumberandaddress`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `listpersonwithnumberandaddress`  AS SELECT `p`.`idP` AS `idP`, concat(`p`.`nom`,' ',`p`.`postnom`,' ',`p`.`prenom`) AS `fullname`, `t`.`initial` AS `initial`, `t`.`numero` AS `numero`, `a`.`avenue` AS `avenue`, `a`.`quartier` AS `quartier`, `a`.`commune` AS `commune`, `a`.`ville` AS `ville`, `a`.`pays` AS `pays` FROM ((`personne` `p` join `telephone` `t` on((`p`.`idP` = `t`.`idP`))) join `adresse` `a` on((`p`.`idP` = `a`.`idP`))) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `adresse`
--
ALTER TABLE `adresse`
  ADD PRIMARY KEY (`idA`),
  ADD KEY `fk_A_P` (`idP`);

--
-- Indexes for table `personne`
--
ALTER TABLE `personne`
  ADD PRIMARY KEY (`idP`),
  ADD UNIQUE KEY `un_P` (`nom`,`postnom`,`prenom`);

--
-- Indexes for table `telephone`
--
ALTER TABLE `telephone`
  ADD PRIMARY KEY (`idT`),
  ADD KEY `fk_T_P` (`idP`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`idU`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `adresse`
--
ALTER TABLE `adresse`
  MODIFY `idA` bigint NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `personne`
--
ALTER TABLE `personne`
  MODIFY `idP` bigint NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `telephone`
--
ALTER TABLE `telephone`
  MODIFY `idT` bigint NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `idU` bigint NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `adresse`
--
ALTER TABLE `adresse`
  ADD CONSTRAINT `fk_A_P` FOREIGN KEY (`idP`) REFERENCES `personne` (`idP`) ON DELETE CASCADE;

--
-- Constraints for table `telephone`
--
ALTER TABLE `telephone`
  ADD CONSTRAINT `fk_T_P` FOREIGN KEY (`idP`) REFERENCES `personne` (`idP`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
