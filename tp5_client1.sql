-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 18 mai 2021 à 10:20
-- Version du serveur :  5.7.31
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `tp5_client1`
--

DELIMITER $$
--
-- Procédures
--
DROP PROCEDURE IF EXISTS `sp_DeleteCommande`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_DeleteCommande` (IN `unNumCmde` INT(50))  NO SQL
BEGIN  
            DELETE FROM commande  
            Where NumCmde = unNumCmde;
        END$$

DROP PROCEDURE IF EXISTS `sp_InsertPortefeuille`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_InsertPortefeuille` (`unNomClient` VARCHAR(50), `uneAdresseClient` VARCHAR(50))  BEGIN
	INSERT INTO CLIENT (NomClient, AdresseClient, LibTypeClient) 
	VALUES (unNomClient, uneAdresseClient, "portefeuille");
END$$

DROP PROCEDURE IF EXISTS `sp_InsertProspect`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_InsertProspect` (`unNomClient` VARCHAR(50), `uneAdresseClient` VARCHAR(50), `unNbVisites` INT)  BEGIN
	INSERT INTO CLIENT (NomClient, AdresseClient, LibTypeClient, NbVisites) 
	VALUES (unNomClient, uneAdresseClient, "prospect", unNbVisites);
END$$

DROP PROCEDURE IF EXISTS `sp_transmuter`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_transmuter` (`unNumClient` INT)  BEGIN
	Update Client
	Set LibTypeClient = "portefeuille",
		NbVisites = NULL
	Where NumClient = unNumClient;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `arch_client`
--

DROP TABLE IF EXISTS `arch_client`;
CREATE TABLE IF NOT EXISTS `arch_client` (
  `NumClient` int(11) NOT NULL,
  `NomClient` varchar(50) NOT NULL,
  `AdresseClient` varchar(50) NOT NULL,
  `LibTypeClient` varchar(20) NOT NULL,
  `NbVisites` int(11) DEFAULT NULL,
  `DateHisto` timestamp NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `arch_client`
--

INSERT INTO `arch_client` (`NumClient`, `NomClient`, `AdresseClient`, `LibTypeClient`, `NbVisites`, `DateHisto`) VALUES
(4, 'TYTY', 'Sainte-Marie', 'prospect', 2, '2021-05-16 21:15:24');

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

DROP TABLE IF EXISTS `client`;
CREATE TABLE IF NOT EXISTS `client` (
  `NumClient` int(11) NOT NULL AUTO_INCREMENT,
  `NomClient` varchar(50) NOT NULL,
  `AdresseClient` varchar(50) NOT NULL,
  `LibTypeClient` varchar(20) NOT NULL DEFAULT '',
  `NbVisites` int(11) DEFAULT NULL,
  PRIMARY KEY (`NumClient`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `client`
--

INSERT INTO `client` (`NumClient`, `NomClient`, `AdresseClient`, `LibTypeClient`, `NbVisites`) VALUES
(1, 'PAYET', 'Saint-Denis', 'portefeuille', NULL),
(2, 'TOTO', 'Saint-André', 'prospect', 1),
(3, 'TITI', 'Sainte-Marie', 'prospect', 10),
(4, 'TYTY', 'Sainte-Marie', 'portefeuille', NULL),
(5, 'TUTU', 'Saint-Denis', 'portefeuille', NULL),
(10, 'bb', 'adresse test', 'prospect', 15),
(11, 'nnd', 'dc', 'portefeuille', NULL),
(12, 'njd', 'sd', 'prospect', 5);

--
-- Déclencheurs `client`
--
DROP TRIGGER IF EXISTS `client_bdel`;
DELIMITER $$
CREATE TRIGGER `client_bdel` BEFORE DELETE ON `client` FOR EACH ROW BEGIN
	INSERT INTO arch_client (NumClient, NomClient, AdresseClient, 
			LibTypeClient, NbVisites)
	VALUES(old.NumClient, old.NomClient, old.AdresseClient, 
		old.LibTypeClient, old.NbVisites);
END
$$
DELIMITER ;
DROP TRIGGER IF EXISTS `client_bup`;
DELIMITER $$
CREATE TRIGGER `client_bup` BEFORE UPDATE ON `client` FOR EACH ROW BEGIN
	IF old.LibTypeClient <> new.LibTypeClient THEN
		-- Cas d'une transmutation, les autres maj sont ignorées
		INSERT INTO arch_client (NumClient, NomClient, AdresseClient, 
				LibTypeClient, NbVisites)
		VALUES(old.NumClient, old.NomClient, old.AdresseClient, 
			old.LibTypeClient, old.NbVisites);
	END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `commande`
--

DROP TABLE IF EXISTS `commande`;
CREATE TABLE IF NOT EXISTS `commande` (
  `NumCmde` int(11) NOT NULL AUTO_INCREMENT,
  `DateCmde` date NOT NULL,
  `NumClient` int(11) NOT NULL,
  PRIMARY KEY (`NumCmde`),
  KEY `Commande_ClientPortefeuille_FK` (`NumClient`)
) ENGINE=InnoDB AUTO_INCREMENT=118 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `commande`
--

INSERT INTO `commande` (`NumCmde`, `DateCmde`, `NumClient`) VALUES
(100, '2020-10-10', 1),
(114, '2021-05-16', 1),
(116, '2021-05-17', 4),
(117, '2021-05-17', 1);

--
-- Déclencheurs `commande`
--
DROP TRIGGER IF EXISTS `commande_bins`;
DELIMITER $$
CREATE TRIGGER `commande_bins` BEFORE INSERT ON `commande` FOR EACH ROW BEGIN
	IF new.NumClient NOT IN (SELECT NumClient 
				FROM CLIENT
				WHERE NumClient = new.NumClient) THEN
        SIGNAL SQLSTATE '45005' 
			SET MYSQL_ERRNO = 10006, MESSAGE_TEXT = 'Ce client nexiste pas !'; 
	END IF;

	IF new.NumClient NOT IN (SELECT NumClient 
				FROM CLIENT
				WHERE LibTypeClient = "portefeuille") THEN
        SIGNAL SQLSTATE '45006' 
			SET MYSQL_ERRNO = 10007, MESSAGE_TEXT = 'Ce client est prospect, souhaitez-vous qu’il passe en portefeuille ?'; 
	END IF;
    END
$$
DELIMITER ;
DROP TRIGGER IF EXISTS `commande_bup`;
DELIMITER $$
CREATE TRIGGER `commande_bup` BEFORE UPDATE ON `commande` FOR EACH ROW BEGIN
	IF new.NumClient NOT IN (SELECT NumClient 
				FROM CLIENT
				WHERE NumClient = new.NumClient) THEN
        SIGNAL SQLSTATE '45005' 
			SET MYSQL_ERRNO = 10006, MESSAGE_TEXT =  'Ce client nexiste pas !'; 
	END IF;

	IF new.NumClient NOT IN (SELECT NumClient 
				FROM CLIENT
				WHERE LibTypeClient = "portefeuille") THEN
        SIGNAL SQLSTATE '45006' 
			SET MYSQL_ERRNO = 10007, MESSAGE_TEXT = 'Ce client est prospect, 
 souhaitez-vous qu’il passe en portefeuille ?'; 
	END IF;
    END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `vclientportefeuille`
-- (Voir ci-dessous la vue réelle)
--
DROP VIEW IF EXISTS `vclientportefeuille`;
CREATE TABLE IF NOT EXISTS `vclientportefeuille` (
`Numclient` int(11)
,`NomClient` varchar(50)
,`AdresseClient` varchar(50)
);

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `vclientprospect`
-- (Voir ci-dessous la vue réelle)
--
DROP VIEW IF EXISTS `vclientprospect`;
CREATE TABLE IF NOT EXISTS `vclientprospect` (
`Numclient` int(11)
,`NomClient` varchar(50)
,`AdresseClient` varchar(50)
,`NbVisites` int(11)
);

-- --------------------------------------------------------

--
-- Structure de la vue `vclientportefeuille`
--
DROP TABLE IF EXISTS `vclientportefeuille`;

DROP VIEW IF EXISTS `vclientportefeuille`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vclientportefeuille`  AS  select `client`.`NumClient` AS `Numclient`,`client`.`NomClient` AS `NomClient`,`client`.`AdresseClient` AS `AdresseClient` from `client` where (`client`.`LibTypeClient` = 'portefeuille') ;

-- --------------------------------------------------------

--
-- Structure de la vue `vclientprospect`
--
DROP TABLE IF EXISTS `vclientprospect`;

DROP VIEW IF EXISTS `vclientprospect`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vclientprospect`  AS  select `client`.`NumClient` AS `Numclient`,`client`.`NomClient` AS `NomClient`,`client`.`AdresseClient` AS `AdresseClient`,`client`.`NbVisites` AS `NbVisites` from `client` where (`client`.`LibTypeClient` = 'prospect') ;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `commande`
--
ALTER TABLE `commande`
  ADD CONSTRAINT `Commande_Client_FK` FOREIGN KEY (`NumClient`) REFERENCES `client` (`NumClient`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
