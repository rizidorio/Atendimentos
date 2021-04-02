namespace Dominio.Entidades
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }

        private Endereco()
        { }

        public Endereco(int id, string cep, string logradouro, string bairro, string localidade, string uf)
        {
            Id = id;
            Cep = cep;
            Logradouro = logradouro;
            Bairro = bairro;
            Localidade = localidade;
            Uf = uf;
        }
    }
}