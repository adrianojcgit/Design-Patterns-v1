using patterns_gof_abstract_factory_v2.Domain.Enums;
using patterns_gof_abstract_factory_v2.Domain.Products;

namespace patterns_gof_abstract_factory_v2.Factory
{
    //ConcreteFactory1
    public sealed class BoloFactory : MassaAbstractFactory
    {
        public override MassaBase CriaMassa(TipoMassa tipoMassa)
        {
            var tipoBolo = (TipoBolo)tipoMassa;
            switch (tipoBolo)
            {
                case TipoBolo.Chocolate:
                    {
                        return new BoloChocolate();
                    }
                case TipoBolo.Laranja:
                    {
                        return new BoloLaranja();
                    }
                default:
                    throw new ArgumentOutOfRangeException("Tipo não implementado");
            }
        }
    }
}