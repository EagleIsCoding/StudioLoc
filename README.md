# 🏠 StudioLoc - Système de Gestion de Locations de Studios

**StudioLoc** est une application de bureau développée en C# (Windows Forms) permettant de gérer efficacement la location de studios de vacances. 

## 🚀 Fonctionnalités

L'application offre une interface complète pour :
* **Gestion des Studios** : Ajout, modification et consultation des détails des studios disponibles.
* **Gestion des Réservations** : Visualisation et édition des réservations des clients.
* **Système d'Authentification** : Accès sécurisé via un formulaire de connexion (Login).
* **Interface Intuitive** : Navigation facilitée via un tableau de bord principal (MainForm).

## 🛠️ Technologies utilisées

* **Langage** : C#
* **Framework** : .NET (Windows Forms)
* **Architecture** : Modèle orienté objet avec séparation des dossiers (`Models`, `Services`).
* **Gestionnaire de dépendances** : NuGet

## 📂 Structure du Projet

* `Models/` : Contient les classes de données (ex: Studio, Client, Reservation).
* `Services/` : Logique métier et accès aux données.
* `Properties/` : Fichiers de configuration du projet.
* `Forms` (Vue) : Contient tous les formulaires utilisateur (Login, Main, Add/Edit).
