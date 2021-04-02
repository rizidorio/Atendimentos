using System;
using System.Collections.Generic;

namespace Dominio.Dtos
{
    public class ServicoDto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Alteracao { get; set; }
        public bool Ativo { get; set; }

        public IEnumerable<FuncionarioDto> Funcionarios { get; set; }
    }
}
