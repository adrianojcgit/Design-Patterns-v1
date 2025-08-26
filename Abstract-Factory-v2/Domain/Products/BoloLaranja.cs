using patterns_gof_abstract_factory_v2.Domain.Enums;

namespace patterns_gof_abstract_factory_v2.Domain.Products
{
    //ProductA2
    public sealed class BoloLaranja : Bolo
    {
        public BoloLaranja() : base("Bolo de Laranja", TipoMassa.Bolo)
        {
            Ingredientes.Add("Com cobertura de calda de laranja");
        }
    }
}