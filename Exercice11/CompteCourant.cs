public class CompteCourant : Compte
{
    public CompteCourant(
        string numero,
        string titulaire,
        decimal solde = 0m)
        : base(numero, titulaire, solde)
    {
    }
}