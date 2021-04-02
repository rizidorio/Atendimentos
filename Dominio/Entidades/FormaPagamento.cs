namespace Dominio.Entidades
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public bool Apagado { get; set; }

        private FormaPagamento()
        { }

        public FormaPagamento(string codigo, string nome, bool ativo = true, bool apagado = false)
        {
            Codigo = codigo;
            Nome = nome;
            Ativo = ativo;
            Apagado = apagado;
        }
    }
}