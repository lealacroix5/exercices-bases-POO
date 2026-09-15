public class Compte
{
    public string Numero { get; private set; }
    public string Titulaire { get; private set; }
    public decimal Solde { get; private set; }

    public Compte(string numero, string titulaire)
        : this(numero, titulaire, 0m)
    {
    }

    public Compte(string numero, string titulaire, decimal solde)
    {
        Numero = numero;
        Titulaire = titulaire;
        Solde = solde;
    }

    public void Crediter(decimal montant)
    {
        if (montant > 0)
        {
            Solde += montant;
        }
    }

    public void Debiter(decimal montant)
    {
        if (montant > 0 && montant <= Solde)
        {
            Solde -= montant;
        }
    }
}