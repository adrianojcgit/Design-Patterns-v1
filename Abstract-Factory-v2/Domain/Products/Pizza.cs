using patterns_gof_abstract_factory_v2.Domain.Enums;

namespace patterns_gof_abstract_factory_v2.Domain.Products
{
    //AbstractProductB
    public abstract class Pizza : MassaBase
    {
        public Pizza(string nome, TipoMassa tipo) : base(nome, tipo)
        {
        }
    }
}