public class Produit
{
    public string Reference { get; }
    public string Nom { get; set; }
    public decimal Prix { get; private set; }
    public int Stock { get; private set; }

    public Produit(string reference, string nom, decimal prix, int stock)
    {
        if (string.IsNullOrWhiteSpace(reference))
        {
            throw new ArgumentException("La référence est obligatoire.");
        }

        if (prix < 0)
        {
            throw new ArgumentException("Le prix ne peut pas être négatif.");
        }

        if (stock < 0)
        {
            throw new ArgumentException("Le stock ne peut pas être négatif.");
        }

        Reference = reference;
        Nom = nom;
        Prix = prix;
        Stock = stock;
    }

    public void AjouterStock(int quantite)
    {
        if (quantite <= 0)
        {
            throw new ArgumentException("La quantité doit être positive.");
        }

        Stock += quantite;
    }

    public void RetirerStock(int quantite)
    {
        if (quantite <= 0)
        {
            throw new ArgumentException("La quantité doit être positive.");
        }

        if (quantite > Stock)
        {
            throw new InvalidOperationException("Stock insuffisant.");
        }

        Stock -= quantite;
    }
}