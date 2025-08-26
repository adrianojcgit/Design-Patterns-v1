using patterns_gof_abstract_factory_v2.Domain.Enums;

namespace patterns_gof_abstract_factory_v2.Domain.Products
{
    //ProductB2
    public sealed class PizzaMussarela : Pizza
    {
        public PizzaMussarela() : base("Pizza Mussarela", TipoMassa.Pizza)
        {
            Ingredientes.Add("Queijo mussarela gratinado e molho de tomate");
        }
    }
}