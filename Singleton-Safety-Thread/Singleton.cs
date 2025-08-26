namespace jcm_patterns_singleton_thread_safety
{
    public class Singleton
    {
        private static Singleton? instance = null;
        private static readonly object lockObject = new object();
        private int numeroDeInstancias = 0;
        private Singleton()
        {
            Console.WriteLine("Instanciando dentro do construtor privado");
            numeroDeInstancias++;
            Console.WriteLine($"Numero de instâncias = {numeroDeInstancias}");
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            Console.WriteLine("Criando a primeira instância");
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }
    }
}