using Atendimento.Desktop.Models;
using Dominio.Interfaces.Servicos;
using Infra.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento.Desktop.BLL
{
    public class FormaPagamentoBLL
    {
        private readonly IFormaPagamentoService _service;

        public FormaPagamentoBLL(IFormaPagamentoService service)
        {
            _service = service;
        }

        public async Task<IEnumerable<FormaPagamento>> getAll()
        {
            var formasPagamento = await _service.ListarTodos();

            return formasPagamento.Select(formaPagamento => new FormaPagamento
            {
                Codigo = formaPagamento.Codigo,
                Nome = formaPagamento.Nome,
                Ativo = formaPagamento.Ativo
            });
        }
    }
}
