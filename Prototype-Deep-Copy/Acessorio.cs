namespace jcm_patterns_prototype_deep_copy
{
    public class Acessorio
    {
        public string? Nome { get; set; }

        public object Clone()
        {
            return (Acessorio)this.MemberwiseClone();
        }
    }
}