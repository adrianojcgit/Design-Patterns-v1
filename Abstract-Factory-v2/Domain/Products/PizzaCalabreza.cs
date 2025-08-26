using patterns_gof_abstract_factory_v2.Domain.Enums;

namespace patterns_gof_abstract_factory_v2.Domain.Products
{
    //ProductB1
    public sealed class PizzaCalabreza : Pizza
    {
        public PizzaCalabreza() : base("Pizza calabreza", TipoMassa.Pizza)
        {
            Ingredientes.Add("Calabreza em cubos e tomtes em cubos");
        }
    }
}