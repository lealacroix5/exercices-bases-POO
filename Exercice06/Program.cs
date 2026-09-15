Console.WriteLine("Hello, World!");

var compte = new Compte("FR001", "Alice");

compte.Crediter(500m);

Console.WriteLine($"Compte : {compte.Numero}");
Console.WriteLine($"Titulaire : {compte.Titulaire}");
Console.WriteLine($"Solde : {compte.Solde} €");