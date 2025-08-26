using jcm_patterns_fluent_builder;

internal class Program
{
    private static void Main(string[] args)
    {
        var emailBuilder = new EmailBuilder()
                    .To("microsoft@gmail.com")
                    .From("apple@gmail.com")
                    .Subject("Patterns Fluent Builder")
                    .Body("Microsoft build 2025\n\t25 a 27 de Setembro 2025" +
                    "\n\tNovidades Windows, Azure, Office e mais");

        var email = emailBuilder.CriaEmail();
        Console.WriteLine(email.ToString());
        Console.ReadLine();
    }
}