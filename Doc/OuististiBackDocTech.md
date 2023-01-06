# Documentation technique

## Technologies utilisées
Projet .NET avec architecture DDD
	Framework utilisés : 
		.NET Core
		Entity Framework
	Base de données : 
		SQLite
		
		
## Sépration des couches :

Une couche "Application" qui contient :
	Les APIs (controllers)
	Les DTOs d'entrée et de sortie des APIs
	
	

Une couche "Domaine" qui contient :
	Les objets métier
		AbstractCalcul
			CalculAddition
			CalculSoustraction
			...
		...
	Leur repository (interface uniquement)
	Leur manager
	
	
	
Une couche "Infrastructure" (EntityFramework) qui contient :
	L'implémentation des repositories
	La définition de la base de données (code-first)
	Les migrations de la base de données
	
	
	
Une couche (implicite) base de données



Un projet de tests unitaires qui teste :
	Les objets et opérations métier
	La conversion et transfert de ceux-ci en DTOs avec la couche application (et vice-versa)
	Manquant : tests de communication avec la base de données
	

## Design patterns et techniques utilisées :

	Injection de dépendances (CalculManager et ICalculRepository)
	Factory (CalculFactory), à améliorer avec une chaîne de responsabilité
	Serialization et Deserialization via .NET Core