Console.WriteLine("Hello, World!");

decimal solde = 1000m;
decimal montant = 150m;

if (montant > 0)
{
    solde += montant;
}
else if (montant < 0)
{
    decimal debit = -montant;

    if (debit <= solde)
    {
        solde -= debit;
    }
    else
    {
        Console.WriteLine("Débit refusé : solde insuffisant.");
    }
}

Console.WriteLine($"Nouveau solde : {solde} €");