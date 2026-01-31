-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : sam. 31 jan. 2026 à 01:56
-- Version du serveur : 10.4.32-MariaDB
-- Version de PHP : 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek86`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

CREATE TABLE `absence` (
  `idpersonnel` int(11) NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(1, '2024-01-10 08:00:00', '2024-01-10 17:00:00', 1),
(1, '2024-03-01 08:00:00', '2024-03-01 12:00:00', 3),
(1, '2024-07-10 08:00:00', '2024-07-20 17:00:00', 3),
(1, '2024-10-01 08:00:00', '2024-10-01 12:00:00', 1),
(2, '2024-01-12 09:00:00', '2024-01-12 18:00:00', 2),
(2, '2024-03-05 09:00:00', '2024-03-05 17:00:00', 4),
(2, '2024-05-05 08:00:00', '2024-05-10 18:00:00', 2),
(2, '2024-07-25 09:00:00', '2024-07-25 18:00:00', 4),
(2, '2024-11-08 08:00:00', '2024-11-10 17:00:00', 2),
(3, '2024-01-15 08:00:00', '2024-01-19 17:00:00', 4),
(3, '2024-03-10 08:00:00', '2024-03-14 17:00:00', 1),
(3, '2024-05-12 09:00:00', '2024-05-12 17:00:00', 3),
(3, '2024-08-01 08:00:00', '2024-08-01 17:00:00', 1),
(3, '2024-10-05 08:00:00', '2024-10-10 17:00:00', 2),
(4, '2024-01-20 14:00:00', '2024-01-20 18:00:00', 3),
(4, '2024-03-15 08:00:00', '2024-03-15 17:00:00', 2),
(4, '2024-05-20 08:00:00', '2024-05-20 12:00:00', 4),
(4, '2024-08-05 08:00:00', '2024-08-05 12:00:00', 2),
(4, '2024-11-10 08:00:00', '2024-11-15 17:00:00', 3),
(5, '2024-02-01 08:00:00', '2024-02-02 17:00:00', 1),
(5, '2024-03-20 13:00:00', '2024-03-20 17:00:00', 3),
(5, '2024-06-01 08:00:00', '2024-06-15 17:00:00', 1),
(5, '2024-08-10 08:00:00', '2024-08-10 17:00:00', 3),
(5, '2024-10-12 09:00:00', '2024-10-12 18:00:00', 3),
(6, '2024-02-05 09:00:00', '2024-02-05 12:00:00', 2),
(6, '2024-03-25 08:00:00', '2024-03-25 18:00:00', 4),
(6, '2024-06-10 08:00:00', '2024-06-10 17:00:00', 2),
(6, '2024-08-15 08:00:00', '2024-08-30 18:00:00', 4),
(6, '2024-11-20 09:00:00', '2024-11-20 18:00:00', 4),
(7, '2024-02-10 08:00:00', '2024-02-15 17:00:00', 3),
(7, '2024-04-01 08:00:00', '2024-04-05 17:00:00', 1),
(7, '2024-06-15 14:00:00', '2024-06-15 18:00:00', 3),
(7, '2024-09-01 09:00:00', '2024-09-01 17:00:00', 1),
(7, '2024-10-20 08:00:00', '2024-10-20 17:00:00', 4),
(8, '2024-02-12 08:00:00', '2024-02-12 17:00:00', 4),
(8, '2024-04-08 09:00:00', '2024-04-08 17:00:00', 2),
(8, '2024-06-20 08:00:00', '2024-06-20 17:00:00', 4),
(8, '2024-09-05 08:00:00', '2024-09-05 17:00:00', 2),
(8, '2024-12-01 08:00:00', '2024-12-05 17:00:00', 1),
(9, '2024-02-18 10:00:00', '2024-02-18 16:00:00', 1),
(9, '2024-04-12 08:00:00', '2024-04-12 12:00:00', 3),
(9, '2024-07-01 08:00:00', '2024-07-01 12:00:00', 1),
(9, '2024-09-10 13:00:00', '2024-09-10 17:00:00', 3),
(9, '2024-11-01 08:00:00', '2024-11-01 12:00:00', 1),
(10, '2024-02-20 08:00:00', '2024-02-22 18:00:00', 2),
(10, '2024-04-15 08:00:00', '2024-04-15 17:00:00', 4),
(10, '2024-07-05 08:00:00', '2024-07-05 17:00:00', 2),
(10, '2024-09-15 08:00:00', '2024-09-15 17:00:00', 4),
(10, '2024-12-10 08:00:00', '2024-12-10 17:00:00', 2);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

CREATE TABLE `motif` (
  `idmotif` int(11) NOT NULL,
  `libelle` varchar(128) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

CREATE TABLE `personnel` (
  `idpersonnel` int(11) NOT NULL,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `tel` varchar(15) DEFAULT NULL,
  `mail` varchar(128) DEFAULT NULL,
  `idservice` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'Martin', 'Thomas', '06 12 34 56 78', 'thomas.martin@email.com', 1),
(2, 'Bernard', 'Sophie', '06 98 76 54 32', 'sophie.bernard@email.com', 3),
(3, 'Dubois', 'Julie', '07 11 22 33 44', 'julie.dubois@email.com', 3),
(4, 'Petit', 'Nicolas', '06 55 44 33 22', 'nicolas.petit@email.com', 1),
(5, 'Durand', 'Emma', '07 88 99 00 11', 'emma.durand@email.com', 2),
(6, 'Leroy', 'Lucas', '06 01 02 03 04', 'lucas.leroy@email.com', 3),
(7, 'Moreau', 'Alice', '07 50 60 70 80', 'alice.moreau@email.com', 1),
(8, 'Simon', 'Chloé', '06 22 33 44 55', 'chloe.simon@email.com', 2),
(9, 'Laurent', 'Gabriel', '07 99 88 77 66', 'gabriel.laurent@email.com', 3),
(10, 'Michel', 'Hugo', '06 10 20 30 40', 'hugo.michel@email.com', 1);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

CREATE TABLE `responsable` (
  `idresponsable` int(11) NOT NULL,
  `login` varchar(64) NOT NULL,
  `pwd` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`idresponsable`, `login`, `pwd`) VALUES
(1, 'test', 'ecd71870d1963316a97e3ac3408c9835ad8cf0f3c1bc703527c30265534f75ae');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

CREATE TABLE `service` (
  `idservice` int(11) NOT NULL,
  `nom` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `absence`
--
ALTER TABLE `absence`
  ADD PRIMARY KEY (`idpersonnel`,`datedebut`),
  ADD KEY `idmotif` (`idmotif`);

--
-- Index pour la table `motif`
--
ALTER TABLE `motif`
  ADD PRIMARY KEY (`idmotif`);

--
-- Index pour la table `personnel`
--
ALTER TABLE `personnel`
  ADD PRIMARY KEY (`idpersonnel`),
  ADD KEY `idservice` (`idservice`);

--
-- Index pour la table `responsable`
--
ALTER TABLE `responsable`
  ADD PRIMARY KEY (`idresponsable`);

--
-- Index pour la table `service`
--
ALTER TABLE `service`
  ADD PRIMARY KEY (`idservice`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `motif`
--
ALTER TABLE `motif`
  MODIFY `idmotif` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `personnel`
--
ALTER TABLE `personnel`
  MODIFY `idpersonnel` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT pour la table `responsable`
--
ALTER TABLE `responsable`
  MODIFY `idresponsable` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT pour la table `service`
--
ALTER TABLE `service`
  MODIFY `idservice` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `absence`
--
ALTER TABLE `absence`
  ADD CONSTRAINT `absence_ibfk_1` FOREIGN KEY (`idpersonnel`) REFERENCES `personnel` (`idpersonnel`),
  ADD CONSTRAINT `absence_ibfk_2` FOREIGN KEY (`idmotif`) REFERENCES `motif` (`idmotif`);

--
-- Contraintes pour la table `personnel`
--
ALTER TABLE `personnel`
  ADD CONSTRAINT `personnel_ibfk_1` FOREIGN KEY (`idservice`) REFERENCES `service` (`idservice`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
