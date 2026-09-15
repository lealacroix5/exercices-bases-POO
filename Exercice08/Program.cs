Console.WriteLine("Hello, World!");

// ==================================================
// EXERCICE 8 - Références d'objets
// ==================================================

// Code demandé dans l'exercice :

Compte compte1 = new Compte("FR001", "Alice", 1000m);

// compte2 reçoit la même référence que compte1.
Compte compte2 = compte1;

// On crédite 500 € sur compte2.
compte2.Crediter(500m);

// ==================================================
// Question 1
// ==================================================

// Quelle valeur affiche compte1.Solde ?

Console.WriteLine($"Solde de compte1 : {compte1.Solde} €");

// Réponse : 1500 €


// ==================================================
// Question 2
// ==================================================

// Pourquoi compte1 a-t-il changé alors qu'on a appelé
// Crediter sur compte2 ?

// Réponse : compte1 et compte2 font référence au même objet
// Compte en mémoire.
// Quand on modifie l'objet avec compte2, on modifie donc
// également ce que compte1 désigne.


// ==================================================
// Question 3
// ==================================================

// Schéma des références :

// compte1 ────────┐
//                 ↓
//              [ Compte ]
//              Solde = 1500 €
//                 ↑
// compte2 ────────┘

// compte1 et compte2 pointent vers le même objet.


// ==================================================
// Vérification
// ==================================================

Console.WriteLine();
Console.WriteLine("Vérification :");
Console.WriteLine($"compte1 : {compte1.Numero}, {compte1.Titulaire}, {compte1.Solde} €");
Console.WriteLine($"compte2 : {compte2.Numero}, {compte2.Titulaire}, {compte2.Solde} €");