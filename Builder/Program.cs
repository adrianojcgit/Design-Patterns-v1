using patterns_gof_builder;

internal class Program
{
    private static void Main(string[] args)
    {
        //Instancia de Director
        Fabricante fabricante = new Fabricante();

        //Instancia de concreteBuilder
        NotebookBuilder notebookBuilder = new NotebookBuilder();
        DesktopBuilder desktopBuilder = new DesktopBuilder();

        //Cria objetos conforme o builder
        fabricante.Build(notebookBuilder);
        fabricante.Build(desktopBuilder);

        Console.ReadLine();
    }
}