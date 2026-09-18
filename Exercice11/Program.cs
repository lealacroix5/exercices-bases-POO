Console.WriteLine("Hello, World!");

Client client1 = new Client("Alice");

CompteCourant compteCourant =
    new CompteCourant("CC001", "Alice", 1000m);

CompteEpargne compteEpargne =
    new CompteEpargne("CE001", "Alice", 2.5m, 5000m);

client1.AjouterCompte(compteCourant);
client1.AjouterCompte(compteEpargne);

compteCourant.Crediter(500m);
compteCourant.Debiter(200m);

compteEpargne.Crediter(1000m);
compteEpargne.Debiter(500m);

Console.WriteLine("===== BANQUE =====");
Console.WriteLine();

Console.WriteLine("Client : " + client1.Nom);
Console.WriteLine();

Console.WriteLine("Comptes :");

foreach (Compte compte in client1.Comptes)
{
    compte.Afficher();
}