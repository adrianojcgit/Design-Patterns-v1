namespace patterns_gof_simple_factory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("=========Pizzaria==========\n");
            Console.WriteLine("Imporme a Pizza (C)Calabresa  ou (M)Mussarela");
            var pizzaEscolhida = Console.ReadLine().ToUpper();
            try
            {
                Pizza pizza = PizzaSimpleFactory.CriarPizza(pizzaEscolhida.ToUpper());
                pizza.Preparar();
                pizza.Assar(30);
                pizza.Embalar();
                Console.WriteLine($"\nPizza concluida com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}