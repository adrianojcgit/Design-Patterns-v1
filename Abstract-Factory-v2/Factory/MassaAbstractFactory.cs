using patterns_gof_abstract_factory_v2.Domain.Enums;
using patterns_gof_abstract_factory_v2.Domain.Products;

namespace patterns_gof_abstract_factory_v2.Factory
{
    //AbstractFactory
    public abstract class MassaAbstractFactory
    {
        public abstract MassaBase CriaMassa(TipoMassa tipoMassa);
        public static MassaAbstractFactory CriaFabricaMassas(TipoMassa tipoMassa)
        {
            switch (tipoMassa)
            {
                case TipoMassa.Pizza:
                {
                    return new PizzaFactory();
                }
                case TipoMassa.Bolo:
                {
                    return new BoloFactory();
                }
                default:
                    throw new ArgumentOutOfRangeException(nameof(tipoMassa));
            }
            
        }
    }
}