Console.WriteLine("Hello, World!");

Produit produit = new Produit("P001", "Clavier", 49.99m, 10);

Console.WriteLine("Produit : " + produit.Nom);
Console.WriteLine("Référence : " + produit.Reference);
Console.WriteLine("Prix : " + produit.Prix + " €");
Console.WriteLine("Stock : " + produit.Stock);

produit.Nom = "Clavier mécanique";

produit.AjouterStock(5);

Console.WriteLine();
Console.WriteLine("Après modification :");
Console.WriteLine("Nom : " + produit.Nom);
Console.WriteLine("Stock : " + produit.Stock);

produit.RetirerStock(3);

Console.WriteLine("Stock après retrait : " + produit.Stock);