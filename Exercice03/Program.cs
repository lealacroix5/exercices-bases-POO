Console.WriteLine("Hello, World!");

Compte compte1 = new Compte();

compte1.Numero = "FR001";
compte1.Titulaire = "Alice";
compte1.Solde = 1000m;

Compte compte2 = new Compte();

compte2.Numero = "FR002";
compte2.Titulaire = "Bob";
compte2.Solde = 500m;

Console.WriteLine($"Compte 1 : {compte1.Numero}, {compte1.Titulaire}, {compte1.Solde} €");
Console.WriteLine($"Compte 2 : {compte2.Numero}, {compte2.Titulaire}, {compte2.Solde} €");

compte1.Solde += 200m;

Console.WriteLine();
Console.WriteLine("Après modification :");
Console.WriteLine($"Compte 1 : {compte1.Solde} €");
Console.WriteLine($"Compte 2 : {compte2.Solde} €");