Console.WriteLine("Hello, World!");

var compte1 = new Compte("FR001", "Alice");
var compte2 = new Compte("FR002", "Bob", 500m);

Console.WriteLine($"{compte1.Titulaire} : {compte1.Solde} €");
Console.WriteLine($"{compte2.Titulaire} : {compte2.Solde} €");