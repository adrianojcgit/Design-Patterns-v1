namespace FactoryMethod
{
    public class RJPizzaMussarela : Pizza
    {
        public RJPizzaMussarela()
        {
            Nome = "Pizza de mussarela Carioca";
            massa = "Massa tradicional carioca";
            molho = "Molho de tomate italiano carioca";
            ingredientes.Add("Queijo parmessão ralado");
            ingredientes.Add("Azeitonas pretas");
        }
    }
}