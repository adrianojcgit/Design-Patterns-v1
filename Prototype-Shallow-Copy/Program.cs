using jcm_patterns_prototype_shallow_copy;

internal class Program
{
    private static void Main(string[] args)
    {
        //Cria objeto do tipo Soldado
        Soldado soldado = new Soldado();
        soldado.Nome = "Silva";
        soldado.Arma = "Fuzil";

        Soldado soldado_clone1 = (Soldado)soldado.Clone();
        Soldado soldado_clone2 = (Soldado)soldado.Clone();

        //exibe valores do objeto original
        Console.WriteLine(">> Objeto Original");
        Console.WriteLine($"   {soldado.Nome} - {soldado.Arma}");

        //valores do objeto clone1
        Console.WriteLine(">> Objeto Clone1");
        Console.WriteLine($"   {soldado_clone1.Nome} - {soldado_clone1.Arma}");

        //valores do objeto clone2
        Console.WriteLine(">> Objeto Clone2");
        Console.WriteLine($"   {soldado_clone2.Nome} - {soldado_clone2.Arma}");

        Console.ReadLine();
    }
}