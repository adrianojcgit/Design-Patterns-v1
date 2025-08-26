using jcm_patterns_prototype_deep_copy;

internal class Program
{
    private static void Main(string[] args)
    {
        //Cria objeto do tipo Soldado
        Soldado soldado = new Soldado();
        soldado.Nome = "Soldado";
        soldado.Arma = "Fuzil";
        soldado.Acessorio = new Acessorio { Nome = "Capacete" };

        Soldado soldado_clone1 = (Soldado)soldado.Clone();
        soldado_clone1.Acessorio.Nome = "Visão Noturna";

        Soldado soldado_clone2 = (Soldado)soldado.Clone();
        soldado_clone2.Acessorio.Nome = "Colete";

        //exibe valores do objeto original
        Console.WriteLine(">> Objeto Original");
        Console.WriteLine($"   {soldado.Nome} - {soldado.Arma}");
        Console.WriteLine($"   {soldado.Acessorio.Nome}");

        //valores do objeto clone1
        Console.WriteLine(">> Objeto Clone1");
        Console.WriteLine($"   {soldado_clone1.Nome} - {soldado_clone1.Arma}");
        Console.WriteLine($"   {soldado_clone1.Acessorio?.Nome}");

        //valores do objeto clone2
        Console.WriteLine(">> Objeto Clone2");
        Console.WriteLine($"   {soldado_clone2.Nome} - {soldado_clone2.Arma}");
        Console.WriteLine($"   {soldado_clone2.Acessorio?.Nome}");

        Console.ReadLine();
    }
}