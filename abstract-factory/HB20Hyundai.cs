namespace patterns_gof_abstract_factory
{
    //Product
    public class HB20Hyundai : ISedan
    {
        public string ExibeDetalhes()
        {
            return "HB20 Hyundai 1.6\nAno 2020";
        }
    }
}