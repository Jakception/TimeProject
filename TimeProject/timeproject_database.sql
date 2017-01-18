-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Mer 18 Janvier 2017 à 14:59
-- Version du serveur :  5.6.15-log
-- Version de PHP :  5.5.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
CREATE DATABASE IF NOT EXISTS timeproject;
USE TimeProject;

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
  `DT_EVENT` char(32) DEFAULT NULL,
  `EVENT_CORPS` char(32) DEFAULT NULL,
  `importance` int(11) NOT NULL,
  PRIMARY KEY (`ID_EVENT`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

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
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

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
  PRIMARY KEY (`CODE_BORDEREAU`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

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
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

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
-- Structure de la table `evenement`
--

CREATE TABLE IF NOT EXISTS `evenement` (
  `ID_EVENT` char(32) NOT NULL,
  `ID_USER` char(32) NOT NULL,
  `DT_EVENT` char(32) DEFAULT NULL,
  `EVENT_CORPS` char(32) DEFAULT NULL,
  PRIMARY KEY (`ID_EVENT`),
  KEY `I_FK_EVENEMENT_USER` (`ID_USER`)
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

-- --------------------------------------------------------

--
-- Structure de la table `information`
--

CREATE TABLE IF NOT EXISTS `information` (
  `ID_EVENT` char(32) NOT NULL,
  `DT_EVENT` char(32) DEFAULT NULL,
  `EVENT_CORPS` char(32) DEFAULT NULL,
  PRIMARY KEY (`ID_EVENT`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

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

-- --------------------------------------------------------

--
-- Structure de la table `type_profil`
--

CREATE TABLE IF NOT EXISTS `type_profil` (
  `CODE_TP_PROFIL` char(32) NOT NULL,
  `LIBELLE_TP_PROFIL` char(32) DEFAULT NULL,
  PRIMARY KEY (`CODE_TP_PROFIL`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

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
  `PWD` char(32) DEFAULT NULL,
  PRIMARY KEY (`ID_USER`),
  KEY `I_FK_USER_TYPE_PROFIL` (`CODE_TP_PROFIL`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

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
