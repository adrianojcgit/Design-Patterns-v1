namespace patterns_gof_simple_factory
{
    public static class PizzaSimpleFactory
    {
        public static Pizza CriarPizza(string nomePizza)
        {
            Pizza pizza;
            switch (nomePizza)
            {
                case "C":
                    pizza = new PizzaCalabresa();
                    break;
                case "M":
                    pizza = new PizzaMussarela();
                    break;
                default:
                    throw new ApplicationException($"A Pizza {nomePizza} não foi criada.");
            }
            return pizza;
        }
    }
}