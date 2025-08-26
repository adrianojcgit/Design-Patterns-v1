namespace jcm_patterns_prototype_shallow_copy
{
    public class Soldado : ICloneable
    {
        public string? Nome { get; set; }
        public string? Arma { get; set; }
        public Soldado() { }
        public Soldado(Soldado s)
        {
            this.Nome = s.Nome;
            this.Arma = s.Arma;
        }

        public object Clone()
        {
            return new Soldado(this);
        }
        
    }
}