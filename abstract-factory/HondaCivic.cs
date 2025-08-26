namespace patterns_gof_abstract_factory
{
    //Product
    public class HondaCivic : ISedan
    {
        public string ExibeDetalhes()
        {
            return "Honda Civic 1.5 173cv\nAno 2020";
        }
    }
}