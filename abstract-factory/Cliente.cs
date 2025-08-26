using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace patterns_gof_abstract_factory
{
    public class Cliente
    {
        ISuv suv;
        ISedan sedan;
        public Cliente(IMontadora factory)
        {
            suv = factory.CriarSuv();
            sedan = factory.CriarSedan();
        }

        public string GetSuvDetalhes()
        {
            return suv.ExibeDetalhes();
        }

        public string GetSedanDetalhes()
        {
            return sedan.ExibeDetalhes();
        }
    }
}