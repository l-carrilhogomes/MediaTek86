# Application MediaTek86

Application C# écrite sous Visual Studio 2022 Entreprise et exploitant une BDD MySQL.

## Présentation de l'application

### Présentation du contexte

MediaTek86 est une médiathèque qui emploie du personnel réparti dans différents services (administratif, médiation culturelle, prêt). La gestion des absences du personnel est essentielle pour assurer la continuité du service et organiser les plannings. Suivant les responsabilités des employés, les absences peuvent avoir des motifs différents (vacances, maladie, motif familial, congé parental). L'accès à l'application doit être sécurisé et réservé aux responsables authentifiés.

### But de l'application

Le responsable souhaite avoir un utilitaire pour gérer le personnel et leurs absences.
L'application MediaTek86 représente cet utilitaire.
L'application doit permettre de :

- présenter la liste du personnel (nom, prénom, tel, mail, service) ;
- permettre d'ajouter un membre du personnel ;
- permettre de modifier ou supprimer un membre du personnel ;
- gérer les absences de chaque personnel (visualiser, ajouter, modifier, supprimer).

La liste des services et des motifs d'absence est fixe et non modifiable via cette application.

### Structure de la BDD

Voici le schéma conceptuel de données présentant la structure de la BDD qui est au format MySQL :

| Table | Champs |
|-------|--------|
| `service` | idservice, nom |
| `personnel` | idpersonnel, nom, prenom, tel, mail, idservice |
| `motif` | idmotif, libelle |
| `absence` | idpersonnel, datedebut, datefin, idmotif |
| `responsable` | idresponsable, login, pwd |

### Interface

L'application comprend les fenêtres suivantes :
- Fenêtre d'authentification (Auth)
- Fenêtre principale de gestion du personnel (Personnel)
- Fenêtre d'ajout de personnel (AddPersonnel)
- Fenêtre de modification de personnel (ModifyPersonnel)
- Fenêtre de gestion des absences (Absence)
- Fenêtre d'ajout d'absence (AddAbsence)
- Fenêtre de modification d'absence (ModifyAbsence)

### Diagramme de paquetage

L'application est structurée dans le respect du pattern MVC.

```
MediaTek86
├── bddmanager/
│   └── BddManager.cs
├── controller/
│   ├── AuthController.cs
│   ├── PersonnelController.cs
│   └── AbsenceController.cs
├── dal/
│   ├── Access.cs
│   ├── ResponsableAccess.cs
│   ├── PersonnelAccess.cs
│   └── AbsenceAccess.cs
├── model/
│   ├── Personnel.cs
│   ├── Service.cs
│   ├── Absence.cs
│   ├── Motif.cs
│   └── Responsable.cs
└── view/
    ├── Auth.cs
    ├── Personnel.cs
    ├── AddPersonnel.cs
    ├── ModifyPersonnel.cs
    ├── Absence.cs
    ├── AddAbsence.cs
    └── ModifyAbsence.cs
```

### Explications sur les couches supplémentaires

L'application contient 2 paquetages supplémentaires par rapport au MVC classique :

- **bddmanager** : contient la classe qui permet d'accéder à la base de données MySQL et d'exécuter les requêtes (classe indépendante et réutilisable).
- **dal** (Data Access Layer) : répond aux demandes du paquetage 'controller' et exploite 'bddmanager' en lui demandant d'exécuter des requêtes.

L'avantage de cette architecture est l'isolement de la connexion (bddmanager) par rapport au reste de l'application. Le contrôleur ne sait pas d'où viennent les données (cela pourrait être un autre SGBDR, voire un autre type de fichier, comme XML). Le paquetage 'dal' fait l'intermédiaire en préparant des requêtes SQL. Donc on sait dans les classes de ce paquetage, qu'il est question d'une base de données relationnelle, mais ne sait pas non plus quel est le SGBDR utilisé.

Changer de SGBDR reviendrait à juste changer la classe BddManager (son contenu), donc ne travailler que sur le paquetage 'bddmanager'.
Changer de type de fichier reviendrait à changer aussi les classes du paquetage 'dal', sans toucher au reste de l'application.

### Présentation du cheminement

L'application démarre sur une vue d'authentification : c'est la structure classique des applications C# de bureau, mais il serait aussi possible de démarrer sur un contrôleur principal.

La vue crée une instance du contrôleur qui lui est dédié (chaque vue a son propre contrôleur). Quand elle a besoin d'accéder aux données (affichage ou demande de modifications), elle fait appel à son contrôleur.

Le contrôleur fait appel aux classes de la couche 'dal' pour exécuter les demandes de la vue.

Les classes de la couche 'dal' contiennent les requêtes qui doivent être exécutées et sollicitent la couche 'bddmanager' pour exécuter les requêtes.

Chaque classe de la couche 'dal' est liée à une classe métier contenu dans 'model'. Ces classes correspondent aux tables de la base de données (avec une approche objet, donc pas de clés étrangères mais des références d'objets) et ne contiennent que la structure des données (propriétés, getters, setters). Excepté 'bddmanager' qui est indépendant de l'application (réutilisable dans n'importe quelle application), toutes les couches exploitent le 'model' (pour le formatage des données).

## Etapes de construction

Les différents commits montrent la création de l'application étape par étape.

### Commit "Phase 1 : Création des paquetages et classes, début de code de bddmanager"

La structure de l'application est créée (les paquetages et classes), dans le respect du diagramme de paquetage.
La classe BddManager (dans le paquetage bddmanager) commence à être construite. C'est un singleton qui permet de se connecter à une BDD et d'exécuter des requêtes SQL.
L'application n'est pas encore opérationnelle.

### Commit "Phase 2 : application opérationnelle (sans authentification)"

Toutes les fonctionnalités de gestion du personnel sont codées.

### Commit "Phase 3 : Authentification"

Ajout d'une fenêtre d'authentification pour limiter l'accès aux responsables authentifiés.

### Commit "Phase 4 : Gestion des absences"

Ajout des fonctionnalités de gestion des absences pour chaque personnel (visualisation, ajout, modification, suppression).

## Installation

Il est possible de tester l'application étape par étape (commit par commit) ou de tester directement la version finale.

Pour tester une version dans un environnement de développement, il faut d'abord installer les outils suivants :
- SGBDR MySQL (par exemple en installant WAMP ou un logiciel similaire)
- De préférence un IDE pour manipuler le code (cette application a été réalisée sous Visual Studio 2022)

Il faut ensuite :
1. Dans MySQL, exécuter le script contenu dans `mediatek86.sql` (présent en racine du dépôt) pour créer et remplir la BDD.
2. Récupérer le code du commit voulu, l'ouvrir dans l'IDE et l'exécuter.

### Identifiants par défaut

- **Login** : `test`
- **Mot de passe** : `test`
