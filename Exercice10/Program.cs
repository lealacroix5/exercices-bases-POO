Console.WriteLine("Hello, World!");

CompteCourant compteCourant =
    new CompteCourant("CC001", "Alice", 1000m);

CompteEpargne compteEpargne =
    new CompteEpargne("CE001", "Bob", 2.5m, 2000m);

compteCourant.Crediter(200m);
compteCourant.Debiter(100m);

compteEpargne.Crediter(500m);

Console.WriteLine("COMPTE COURANT");
Console.WriteLine("Numéro : " + compteCourant.Numero);
Console.WriteLine("Titulaire : " + compteCourant.Titulaire);
Console.WriteLine("Solde : " + compteCourant.Solde + " €");

Console.WriteLine();

Console.WriteLine("COMPTE ÉPARGNE");
Console.WriteLine("Numéro : " + compteEpargne.Numero);
Console.WriteLine("Titulaire : " + compteEpargne.Titulaire);
Console.WriteLine("Solde : " + compteEpargne.Solde + " €");
Console.WriteLine("Taux d'intérêt : " + compteEpargne.TauxInteret + " %");