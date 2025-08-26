namespace jcm_patterns_singleton_eager_loading
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        private static int contador = 0;
        private Singleton()
        {
            contador++;
            Console.WriteLine($"Instancia: {contador}");
        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}