using patterns_gof_abstract_factory_v2.Domain.Enums;
using patterns_gof_abstract_factory_v2.Domain.Products;

namespace patterns_gof_abstract_factory_v2.Factory
{
    //ConcreteFactory2
    public sealed class PizzaFactory : MassaAbstractFactory
    {
        public override MassaBase CriaMassa(TipoMassa tipoMassa)
        {
            var tipoPizza = (TipoPizza)tipoMassa;
            switch (tipoPizza)
            {
                case TipoPizza.Mussarela:
                    {
                        return new PizzaMussarela();
                    }
                case TipoPizza.Calabreza:
                    {
                        return new PizzaCalabreza();
                    }
                default:
                    throw new ArgumentOutOfRangeException("Tipo não implementado");
            }
        }
    }
}