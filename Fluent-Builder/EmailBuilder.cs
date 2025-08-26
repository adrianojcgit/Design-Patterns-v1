namespace jcm_patterns_fluent_builder
{
    public class EmailBuilder
    {
        private readonly Email _email;
        public EmailBuilder()
        {
            _email = new Email();
        }

        public EmailBuilder To(string destino)
        {
            _email.To = destino;
            return this;
        }

        public EmailBuilder From(string origim)
        {
            _email.From = origim;
            return this;
        }

        public EmailBuilder Subject(string titulo)
        {
            _email.Subject = titulo;
            return this;
        }

        public EmailBuilder Body(string conteudo)
        {
            _email.Body = conteudo;
            return this;
        }
        public Email CriaEmail()
        {
            return _email;
        }
    }
}