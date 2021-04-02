using Dominio.Dtos;
using Dominio.Entidades;
using Dominio.Interfaces.Repositorios;
using Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Servicos
{
    public class FormaPagamentoService : IFormaPagamentoService
    {
        private readonly IFormaPagamentoRepositorio _repositorio;

        public FormaPagamentoService(IFormaPagamentoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Dispose()
        {
            _repositorio.Dispose();
        }

        public async Task<bool> JaExiste(string codigo, string nome)
        {
            try
            {
                var formasPagamento = await ListarTodos();

                foreach (var formaPagamento in formasPagamento)
                {
                    if (formaPagamento.Codigo.Equals(codigo, StringComparison.CurrentCultureIgnoreCase))
                        throw new Exception("Código informado já utilizado.");
                    if (formaPagamento.Nome.Equals(nome, StringComparison.CurrentCultureIgnoreCase))
                        throw new Exception("Forma de pagamento já cadastrada.");
                }

                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<FormaPagamentoDto>> ListarTodos()
        {
            var formasPagamento = await _repositorio.ListarTodos();

            if (formasPagamento.Any())
            {
                return formasPagamento.Select(formaPagamento => new FormaPagamentoDto
                {
                    Codigo = formaPagamento.Codigo,
                    Nome = formaPagamento.Nome,
                    Ativo = formaPagamento.Ativo,
                });
            }
            else
                throw new Exception("Não existe formas de pagamento cadastradas.");
        }

        public async Task<FormaPagamentoDto> PegarPorCodigo(string codgio)
        {
            var formasPagamento = await ListarTodos();

            return formasPagamento.FirstOrDefault(fp => fp.Codigo.Equals(codgio, StringComparison.CurrentCultureIgnoreCase));
        }

        public async Task Remover(string codigo)
        {
            var formaPagamento = await _repositorio.PegarPorCodigo(codigo);

            if (formaPagamento is null)
                throw new Exception("Forma de pagamento não encontrada");

            await _repositorio.Remover(formaPagamento);
        }

        public async Task<FormaPagamentoDto> Salvar(FormaPagamentoDto formaPagamentoDto)
        {
            FormaPagamento formaPagamento = await _repositorio.PegarPorCodigo(formaPagamentoDto.Codigo);
            FormaPagamento resultado;
            try
            {
                if (formaPagamento is null)
                {
                    await JaExiste(formaPagamentoDto.Codigo, formaPagamentoDto.Nome);

                    formaPagamento = new(formaPagamentoDto.Codigo, formaPagamentoDto.Nome, formaPagamentoDto.Ativo);

                    resultado = await _repositorio.Adicionar(formaPagamento);

                    if (resultado is null)
                        throw new Exception("Erro ao cadastrar, contate o administrador do sistema.");

                    return formaPagamentoDto;
                }
                else
                {
                    

                    if (formaPagamento is null)
                        throw new Exception("Forma de pagamento não encontrada");

                    formaPagamento.Nome = formaPagamentoDto.Nome;
                    formaPagamento.Ativo = formaPagamentoDto.Ativo;

                    resultado = await _repositorio.Atualizar(formaPagamento);

                    if (resultado is null)
                        throw new Exception("Erro ao atualizar, contate o administrador do sistema.");

                    return formaPagamentoDto;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
