using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace patterns_gof_simple_factory
{
    public class PizzaMussarela : Pizza
    {
        public PizzaMussarela()
        {
            Nome = "Mussarela";
        }
        public override void Assar(int tempo)
        {
            Console.WriteLine($"Pizza de {Nome} Assando por {tempo} min.");
        }

        public override void Embalar()
        {
            Console.WriteLine($"Embalando Pizza de {Nome}.");
        }

        public override void Preparar()
        {
            Console.WriteLine($"Preparando Pizza de {Nome}.");
        }
    }
}