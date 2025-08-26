using System.Collections;
using patterns_gof_abstract_factory_v2.Domain.Enums;

namespace patterns_gof_abstract_factory_v2.Domain.Products
{
    public abstract class MassaBase
    {
        public TipoMassa TipoMassa { get; set; }
        public string Nome { get; set; }
        public ArrayList Ingredientes = new ArrayList();

        public MassaBase(string nome, TipoMassa tipo)
        {
            Nome = nome;
            TipoMassa = tipo;            
        }
    }
}