Console.WriteLine("Hello, World!");

decimal Crediter(decimal solde, decimal montant)
{
    if (montant <= 0)
    {
        Console.WriteLine("Le montant du crédit doit être positif.");
        return solde;
    }

    return solde + montant;
}

decimal Debiter(decimal solde, decimal montant)
{
    if (montant <= 0)
    {
        Console.WriteLine("Le montant du débit doit être positif.");
        return solde;
    }

    if (montant > solde)
    {
        Console.WriteLine("Débit refusé : solde insuffisant.");
        return solde;
    }

    return solde - montant;
}

decimal solde = 1000m;

solde = Crediter(solde, 200m);
solde = Debiter(solde, 50m);

Console.WriteLine($"Nouveau solde : {solde} €");