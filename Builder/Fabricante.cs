namespace patterns_gof_builder
{    
    public class Fabricante
    {
        //Director        
        public void Build(ComputadorBuilder computadorBuilder)
        {
            computadorBuilder.BuildDispositivos();
            computadorBuilder.BuildSO();
        }
    }
}