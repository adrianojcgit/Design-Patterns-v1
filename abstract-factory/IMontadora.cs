namespace patterns_gof_abstract_factory
{
    //AbstractFactory
    public interface IMontadora
    {
        ISuv CriarSuv();
        ISedan CriarSedan();
    }
}