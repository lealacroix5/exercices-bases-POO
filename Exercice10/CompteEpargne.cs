public class CompteEpargne : Compte
{
    public decimal TauxInteret { get; }

    public CompteEpargne(
        string numero,
        string titulaire,
        decimal tauxInteret,
        decimal solde = 0m)
        : base(numero, titulaire, solde)
    {
        TauxInteret = tauxInteret;
    }
}