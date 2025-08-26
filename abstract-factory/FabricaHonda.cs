namespace patterns_gof_abstract_factory
{
    //ConcreteFactory
    public class FabricaHonda : IMontadora
    {
        public ISedan CriarSedan()
        {
            return new HondaCivic();
        }

        public ISuv CriarSuv()
        {
            return new HondaCRV();
        }
    }
}