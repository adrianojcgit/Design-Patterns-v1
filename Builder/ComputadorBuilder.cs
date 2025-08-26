namespace patterns_gof_builder
{
    //Builder
    public abstract class ComputadorBuilder
    {
        public abstract void BuildSO();
        public abstract void BuildDispositivos();
        Computador? TipoComputador { get; }
    }
}