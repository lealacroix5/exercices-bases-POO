public class Compte
{
    public string Numero { get; }
    public string Titulaire { get; }
    public decimal Solde { get; private set; }

    public Compte(string numero, string titulaire, decimal solde = 0m)
    {
        Numero = numero;
        Titulaire = titulaire;
        Solde = solde;
    }

    public void Crediter(decimal montant)
    {
        if (montant <= 0)
        {
            throw new ArgumentException("Le montant doit être positif.");
        }

        Solde += montant;
    }

    public void Debiter(decimal montant)
    {
        if (montant <= 0)
        {
            throw new ArgumentException("Le montant doit être positif.");
        }

        if (montant > Solde)
        {
            throw new InvalidOperationException("Solde insuffisant.");
        }

        Solde -= montant;
    }
}