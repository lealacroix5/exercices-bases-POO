public class Compte
{
    public string Numero { get; private set; } ="";
    public string Titulaire { get; set; } ="";
    public decimal Solde { get; private set; }

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