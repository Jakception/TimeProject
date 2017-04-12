-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Mar 11 Avril 2017 à 19:29
-- Version du serveur :  5.6.15-log
-- Version de PHP :  5.4.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `timeproject`
--

-- --------------------------------------------------------

--
-- Structure de la table `action`
--

CREATE TABLE IF NOT EXISTS `action` (
  `ID_EVENT` char(32) NOT NULL,
  `ETAT` char(32) DEFAULT NULL,
  `DT_EVENT` date DEFAULT NULL,
  `EVENT_CORPS` char(32) DEFAULT NULL,
  `importance` int(11) NOT NULL,
  `ID_USER` varchar(32) NOT NULL,
  PRIMARY KEY (`ID_EVENT`),
  KEY `ID_USER` (`ID_USER`),
  KEY `ID_USER_2` (`ID_USER`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Contenu de la table `action`
--

INSERT INTO `action` (`ID_EVENT`, `ETAT`, `DT_EVENT`, `EVENT_CORPS`, `importance`, `ID_USER`) VALUES
('proj0_01', '2', '2017-03-17', 'tu as une tache urgente a faire', 1, '1'),
('proj0_02', '4', '2017-03-29', 'ttu as un rendu a faire', 1, '1'),
('ydaysACT3', '3', '2017-04-12', 'Presentation du projet', 1, 'RiRo342'),
('ydaysACT1', '4', '2017-04-10', 'Compte rendu d avancement du pro', 1, 'RiRo342'),
('ydaysACT2', '5', '2017-04-12', 'video de presentation du projet', 1, 'RiRo342'),
('ydaysACT4', '1', '2017-04-12', 'finalisation de l affichage', 3, 'RiRo342'),
('ydaysACT6', '1', '2017-04-10', 'ACTION FORTE', 1, 'RiRo342'),
('ydaysACT7', '1', '2017-04-10', 'ACTION FORTE EN ATTENTE', 1, 'RiRo342');

-- --------------------------------------------------------

--
-- Structure de la table `architecte`
--

CREATE TABLE IF NOT EXISTS `architecte` (
  `ID_ARCHI` int(11) NOT NULL AUTO_INCREMENT,
  `NOM_ARCHI` char(32) DEFAULT NULL,
  `ADRESSE_ARCHI` char(32) DEFAULT NULL,
  `CP_ARCHI` char(32) DEFAULT NULL,
  `VILLE_ARCHI` char(32) DEFAULT NULL,
  PRIMARY KEY (`ID_ARCHI`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Contenu de la table `architecte`
--

INSERT INTO `architecte` (`ID_ARCHI`, `NOM_ARCHI`, `ADRESSE_ARCHI`, `CP_ARCHI`, `VILLE_ARCHI`) VALUES
(1, 'Architecte generique', NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `bordereau_envoi`
--

CREATE TABLE IF NOT EXISTS `bordereau_envoi` (
  `CODE_BORDEREAU` char(32) NOT NULL,
  `NUMERO_BORDEREAU` char(32) DEFAULT NULL,
  `DESIGNATION` char(32) DEFAULT NULL,
  `EXEMPLAIRE` char(32) DEFAULT NULL,
  `VERSION` char(32) DEFAULT NULL,
  `ETAT` int(11) NOT NULL,
  `date_crea` date NOT NULL,
  PRIMARY KEY (`CODE_BORDEREAU`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Contenu de la table `bordereau_envoi`
--

INSERT INTO `bordereau_envoi` (`CODE_BORDEREAU`, `NUMERO_BORDEREAU`, `DESIGNATION`, `EXEMPLAIRE`, `VERSION`, `ETAT`, `date_crea`) VALUES
('ydays0', '1', 'Validation maquette', '1', '1', 2, '0000-00-00');

-- --------------------------------------------------------

--
-- Structure de la table `bord_plan`
--

CREATE TABLE IF NOT EXISTS `bord_plan` (
  `CODE_BORDEREAU` char(32) NOT NULL,
  `CODE_PLAN` char(32) NOT NULL,
  `INDICE` char(32) NOT NULL,
  PRIMARY KEY (`CODE_BORDEREAU`,`CODE_PLAN`,`INDICE`),
  KEY `I_FK_BORD_PLAN_BORDEREAU_ENVOI` (`CODE_BORDEREAU`),
  KEY `I_FK_BORD_PLAN_PLAN` (`CODE_PLAN`,`INDICE`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Contenu de la table `bord_plan`
--

INSERT INTO `bord_plan` (`CODE_BORDEREAU`, `CODE_PLAN`, `INDICE`) VALUES
('ydays0', 'ydays2', '1'),
('ydays0', 'ydays4', '1');

-- --------------------------------------------------------

--
-- Structure de la table `bord_projet`
--

CREATE TABLE IF NOT EXISTS `bord_projet` (
  `CODE_BORDEREAU` char(32) NOT NULL,
  `CODE_PROJET` char(32) NOT NULL,
  PRIMARY KEY (`CODE_BORDEREAU`,`CODE_PROJET`),
  KEY `I_FK_BORD_PROJET_BORDEREAU_ENVOI` (`CODE_BORDEREAU`),
  KEY `I_FK_BORD_PROJET_PROJET` (`CODE_PROJET`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Contenu de la table `bord_projet`
--

INSERT INTO `bord_projet` (`CODE_BORDEREAU`, `CODE_PROJET`) VALUES
('ydays0', 'ydays');

-- --------------------------------------------------------

--
-- Structure de la table `bureau_controle`
--

CREATE TABLE IF NOT EXISTS `bureau_controle` (
  `ID_BC` int(11) NOT NULL AUTO_INCREMENT,
  `NOM_BC` char(32) DEFAULT NULL,
  `ADRESSE_BC` char(32) DEFAULT NULL,
  `CP_BC` char(32) DEFAULT NULL,
  `VILLE_BC` char(32) DEFAULT NULL,
  PRIMARY KEY (`ID_BC`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Contenu de la table `bureau_controle`
--

INSERT INTO `bureau_controle` (`ID_BC`, `NOM_BC`, `ADRESSE_BC`, `CP_BC`, `VILLE_BC`) VALUES
(1, 'bureau de controle generique', NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `compte_rendu`
--

CREATE TABLE IF NOT EXISTS `compte_rendu` (
  `CODE_CR` char(32) NOT NULL,
  `DESIGNATION` char(32) DEFAULT NULL,
  PRIMARY KEY (`CODE_CR`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `cr_pole`
--

CREATE TABLE IF NOT EXISTS `cr_pole` (
  `CODE_POLE` char(32) NOT NULL,
  `CODE_CR` char(32) NOT NULL,
  PRIMARY KEY (`CODE_POLE`,`CODE_CR`),
  KEY `I_FK_CR_POLE_POLE` (`CODE_POLE`),
  KEY `I_FK_CR_POLE_COMPTE_RENDU` (`CODE_CR`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `cr_projet`
--

CREATE TABLE IF NOT EXISTS `cr_projet` (
  `CODE_PROJET` char(32) NOT NULL,
  `CODE_CR` char(32) NOT NULL,
  PRIMARY KEY (`CODE_PROJET`,`CODE_CR`),
  KEY `I_FK_CR_PROJET_PROJET` (`CODE_PROJET`),
  KEY `I_FK_CR_PROJET_COMPTE_RENDU` (`CODE_CR`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `cr_user`
--

CREATE TABLE IF NOT EXISTS `cr_user` (
  `CODE_CR` char(32) NOT NULL,
  `ID_USER` char(32) NOT NULL,
  PRIMARY KEY (`CODE_CR`,`ID_USER`),
  KEY `I_FK_CR_USER_COMPTE_RENDU` (`CODE_CR`),
  KEY `I_FK_CR_USER_USER` (`ID_USER`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `eventprojet`
--

CREATE TABLE IF NOT EXISTS `eventprojet` (
  `CODE_PROJET` char(32) NOT NULL,
  `ID_EVENT` char(32) NOT NULL,
  PRIMARY KEY (`CODE_PROJET`,`ID_EVENT`),
  KEY `I_FK_EVENTPROJET_PROJET` (`CODE_PROJET`),
  KEY `I_FK_EVENTPROJET_EVENEMENT` (`ID_EVENT`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Contenu de la table `eventprojet`
--

INSERT INTO `eventprojet` (`CODE_PROJET`, `ID_EVENT`) VALUES
('projetTest', 'inf01'),
('projetTest', 'proj0_01'),
('projetTest', 'proj0_02'),
('ydays', 'ydaysACT1'),
('ydays', 'ydaysACT2'),
('ydays', 'ydaysACT3'),
('ydays', 'ydaysACT4'),
('ydays', 'ydaysACT6'),
('ydays', 'ydaysACT7'),
('ydays', 'ydaysINF5');

-- --------------------------------------------------------

--
-- Structure de la table `information`
--

CREATE TABLE IF NOT EXISTS `information` (
  `ID_EVENT` char(32) NOT NULL,
  `DT_EVENT` date DEFAULT NULL,
  `EVENT_CORPS` char(32) DEFAULT NULL,
  `ID_USER` varchar(32) NOT NULL,
  PRIMARY KEY (`ID_EVENT`),
  KEY `ID_USER` (`ID_USER`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Contenu de la table `information`
--

INSERT INTO `information` (`ID_EVENT`, `DT_EVENT`, `EVENT_CORPS`, `ID_USER`) VALUES
('inf01', '2017-03-29', 'information', '2'),
('ydaysINF5', '2017-04-10', 'Aucun retour de l equipe WEB, do', 'RiRo342');

-- --------------------------------------------------------

--
-- Structure de la table `plan`
--

CREATE TABLE IF NOT EXISTS `plan` (
  `CODE_PLAN` char(32) NOT NULL,
  `INDICE` char(32) NOT NULL,
  `CODE_PROJET` char(32) NOT NULL,
  `NUMERO_PLAN` char(32) DEFAULT NULL,
  `LIBELLE_PLAN` char(32) DEFAULT NULL,
  `DESIGNATION` char(32) DEFAULT NULL,
  `DT_PLAN` char(32) DEFAULT NULL,
  PRIMARY KEY (`CODE_PLAN`,`INDICE`),
  KEY `I_FK_PLAN_PROJET` (`CODE_PROJET`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Contenu de la table `plan`
--

INSERT INTO `plan` (`CODE_PLAN`, `INDICE`, `CODE_PROJET`, `NUMERO_PLAN`, `LIBELLE_PLAN`, `DESIGNATION`, `DT_PLAN`) VALUES
('plan1', '1', 'proj0', 'proj0_p1', 'plan 1 test', 'sdkhjldskjlsd', '09/03/2017'),
('plan2', '2', 'proj0', 'proj0_p1', 'plan 1 test indice 2', 'azertyuiop', '11/03/2017'),
('plan3', '1', 'proj0', 'proj0_f1', 'plan 1 plan type f', 'yfugjhkbopkjm', '11/03/2017'),
('ydays2', '1', 'ydays', '2', 'Maquette video', 'maqVid', '12/04/2017 13:07:05'),
('ydays1', '1', 'ydays', '1', 'Maquette présentation', 'maqPres', '11/04/2017 13:05:58'),
('ydays4', '1', 'ydays', '4', 'tests', 'test', '11/04/2017 13:07:25'),
('ydays1', '2', 'ydays', '1', 'Maquette présentation', 'maqPres', '11/04/2017 13:05:58');

-- --------------------------------------------------------

--
-- Structure de la table `pole`
--

CREATE TABLE IF NOT EXISTS `pole` (
  `CODE_POLE` char(32) NOT NULL,
  `NOM_POLE` char(32) DEFAULT NULL,
  PRIMARY KEY (`CODE_POLE`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `projet`
--

CREATE TABLE IF NOT EXISTS `projet` (
  `CODE_PROJET` char(32) NOT NULL,
  `ID_BC` int(11) NOT NULL,
  `ID_ARCHI` int(11) NOT NULL,
  `ID_USER` char(32) NOT NULL,
  `NOM_PROJET` char(32) DEFAULT NULL,
  `NOM_CLIENT` char(32) DEFAULT NULL,
  `ADRESSE_CLIENT` char(32) DEFAULT NULL,
  `VILLE_CLIENT` char(32) DEFAULT NULL,
  `DT_DEB_PROJET` date DEFAULT NULL,
  `DT_OBJ_FIN` date DEFAULT NULL,
  `DT_FIN_REEL` date DEFAULT NULL,
  PRIMARY KEY (`CODE_PROJET`),
  KEY `I_FK_PROJET_BUREAU_CONTROLE` (`ID_BC`),
  KEY `I_FK_PROJET_ARCHITECTE` (`ID_ARCHI`),
  KEY `I_FK_PROJET_USER` (`ID_USER`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Contenu de la table `projet`
--

INSERT INTO `projet` (`CODE_PROJET`, `ID_BC`, `ID_ARCHI`, `ID_USER`, `NOM_PROJET`, `NOM_CLIENT`, `ADRESSE_CLIENT`, `VILLE_CLIENT`, `DT_DEB_PROJET`, `DT_OBJ_FIN`, `DT_FIN_REEL`) VALUES
('test', 0, 0, '0', 'test', 'Janvre Caliste', '13 rue de quelquepart', '91310 Monthlery', '2017-04-10', '2017-04-25', '2017-04-10'),
('projAlpha', 0, 0, '0', 'test 2 creation', 'dsfdsfds', 'azehj', 'erhjk', '2017-03-17', '2017-03-24', '2017-04-10'),
('projetTest', 0, 0, '0', 'jfdkmls', 'hvizjklm', 'jhklm', 'jokdfo^kfd', '2017-03-17', '2017-03-25', NULL),
('testCr', 0, 0, 'RiRo541', 'Test de création', 'Ingésup Paris', '29 rue fontarabie', '75020 Päris', '2017-04-10', '2017-04-30', '2017-04-10'),
('ydays', 0, 0, 'RaRo674', 'Presentation Ydays', 'Ynov Paris', '29 rue Fontarabie', '75020 Paris', '2017-04-10', '2017-04-30', NULL);

-- --------------------------------------------------------

--
-- Structure de la table `type_profil`
--

CREATE TABLE IF NOT EXISTS `type_profil` (
  `CODE_TP_PROFIL` char(32) NOT NULL,
  `LIBELLE_TP_PROFIL` char(32) DEFAULT NULL,
  PRIMARY KEY (`CODE_TP_PROFIL`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Contenu de la table `type_profil`
--

INSERT INTO `type_profil` (`CODE_TP_PROFIL`, `LIBELLE_TP_PROFIL`) VALUES
('adm', 'administrateur'),
('chp', 'chef de projet'),
('sal', 'salarie');

-- --------------------------------------------------------

--
-- Structure de la table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `ID_USER` char(32) NOT NULL,
  `CODE_TP_PROFIL` char(32) NOT NULL,
  `INIT_USER` char(5) DEFAULT NULL,
  `NOM_USER` char(32) DEFAULT NULL,
  `PRENOM_USER` char(32) DEFAULT NULL,
  `MAIL` char(32) DEFAULT NULL,
  `PWD` char(100) DEFAULT NULL,
  PRIMARY KEY (`ID_USER`),
  KEY `I_FK_USER_TYPE_PROFIL` (`CODE_TP_PROFIL`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Contenu de la table `user`
--

INSERT INTO `user` (`ID_USER`, `CODE_TP_PROFIL`, `INIT_USER`, `NOM_USER`, `PRENOM_USER`, `MAIL`, `PWD`) VALUES
('0', 'adm', 'JC', 'Caliste', 'Janvre', 'janvre.caliste@admin.fr', 'CA-29-37-76-1B-43-FE-89-4D-4E-13-5B-0B-CA-FD-2E'),
('RiRo342', 'sal', 'RIR', 'Richard', 'Robert', 'romain.radiguet@ynov.com', '4A-EA-68-EB-73-C3-47-A4-51-F2-A1-0F-79-FA-7E-B2'),
('BeGu952', 'sal', 'GB', 'Beulaygue', 'Guillaume', 'guillaume.beulaygue@ynov.com', '69-4B-8D-0F-FD-07-CA-42-5C-C0-6C-E0-0B-F5-24-88'),
('RaRo674', 'sal', 'RR', 'Radiguet', 'Romain', 'romain.radiguet@ynov.com', '16-FD-70-6F-E8-35-F0-DF-7D-1B-D0-39-B2-F1-35-04');

-- --------------------------------------------------------

--
-- Structure de la table `user_event`
--

CREATE TABLE IF NOT EXISTS `user_event` (
  `ID_EVENT` char(32) NOT NULL,
  `ID_USER` char(32) NOT NULL,
  PRIMARY KEY (`ID_EVENT`,`ID_USER`),
  KEY `I_FK_USER_EVENT_EVENEMENT` (`ID_EVENT`),
  KEY `I_FK_USER_EVENT_USER` (`ID_USER`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `user_pole`
--

CREATE TABLE IF NOT EXISTS `user_pole` (
  `ID_USER` char(32) NOT NULL,
  `CODE_POLE` char(32) NOT NULL,
  PRIMARY KEY (`ID_USER`,`CODE_POLE`),
  KEY `I_FK_USER_POLE_USER` (`ID_USER`),
  KEY `I_FK_USER_POLE_POLE` (`CODE_POLE`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `user_projet`
--

CREATE TABLE IF NOT EXISTS `user_projet` (
  `CODE_PROJET` char(32) NOT NULL,
  `ID_USER` char(32) NOT NULL,
  PRIMARY KEY (`CODE_PROJET`,`ID_USER`),
  KEY `I_FK_USER_PROJET_PROJET` (`CODE_PROJET`),
  KEY `I_FK_USER_PROJET_USER` (`ID_USER`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Contenu de la table `user_projet`
--

INSERT INTO `user_projet` (`CODE_PROJET`, `ID_USER`) VALUES
('Pres', '0'),
('Pres', 'RaRo674'),
('projAlpha', '0'),
('testCr', '0'),
('testCr', 'BeGu952'),
('testCr', 'RaRo674'),
('ydays', '0'),
('ydays', 'BeGu952'),
('ydays', 'RiRo342');

-- --------------------------------------------------------

--
-- Structure de la table `valid_archi`
--

CREATE TABLE IF NOT EXISTS `valid_archi` (
  `CODE_PLAN` char(32) NOT NULL,
  `INDICE` char(32) NOT NULL,
  `ID_ARCHI` int(11) NOT NULL,
  `DT_REP_ARCHI` date DEFAULT NULL,
  `NUM_COUR_ARCHI` char(32) DEFAULT NULL,
  `REP_ARCHI` char(32) DEFAULT NULL,
  PRIMARY KEY (`CODE_PLAN`,`INDICE`,`ID_ARCHI`),
  KEY `I_FK_VALID_ARCHI_PLAN` (`CODE_PLAN`,`INDICE`),
  KEY `I_FK_VALID_ARCHI_ARCHITECTE` (`ID_ARCHI`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `valid_bc`
--

CREATE TABLE IF NOT EXISTS `valid_bc` (
  `ID_BC` int(11) NOT NULL,
  `CODE_PLAN` char(32) NOT NULL,
  `INDICE` char(32) NOT NULL,
  `DT_REP_BC` date DEFAULT NULL,
  `NUM_COURR_BC` char(32) DEFAULT NULL,
  `REP_BC` char(32) DEFAULT NULL,
  PRIMARY KEY (`ID_BC`,`CODE_PLAN`,`INDICE`),
  KEY `I_FK_VALID_BC_BUREAU_CONTROLE` (`ID_BC`),
  KEY `I_FK_VALID_BC_PLAN` (`CODE_PLAN`,`INDICE`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
