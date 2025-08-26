namespace patterns_gof_simple_factory
{
    public class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa()
        {
            Nome = "Calabresa";
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