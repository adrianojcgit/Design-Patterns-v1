namespace patterns_gof_abstract_factory
{
    //Product
    public class HondaCRV : ISuv
    {
        public string ExibeDetalhes()
        {
            return "Honda CR-V Turbo 190cv\nAno 2020";
        }
    }
}