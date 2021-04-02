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
    public class AtendimentoService : IAtendimentoService
    {
        private readonly IAtendimentoRepositorio _repositorio;

        public AtendimentoService(IAtendimentoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Dispose()
        {
            _repositorio.Dispose();
        }

        public async Task<IEnumerable<AtendimentoDto>> ListarPorCliente(int clienteId)
        {
            try
            {
                var atendimentos = await ListarTodos();

                if (atendimentos.Any())
                {
                    return atendimentos.Where(a => a.ClienteId.Equals(clienteId)).Select(atendimento => new AtendimentoDto
                    {
                        Id = atendimento.Id,
                        Data = atendimento.Data,
                        Hora = atendimento.Hora,
                        ClienteId = atendimento.ClienteId,
                        FuncionarioId = atendimento.FuncionarioId,
                        ServicoId = atendimento.ServicoId,
                        ValorTotal = atendimento.ValorTotal,
                        Desconto = atendimento.Desconto,
                        ValorComDesconto = atendimento.ValorComDesconto,
                        ValorPago = atendimento.ValorPago,
                        Troco = atendimento.Troco,
                        FormaPagamentoId = atendimento.FormaPagamentoId,
                    });
                }
                else
                {
                    throw new Exception("Não existe atendimentos cadastrados.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<AtendimentoDto>> ListarPorData(DateTime data)
        {
            try
            {
                var atendimentos = await ListarTodos();

                if (atendimentos.Any())
                {
                    return atendimentos.Where(a => a.Data.Equals(data)).Select(atendimento => new AtendimentoDto
                    {
                        Id = atendimento.Id,
                        Data = atendimento.Data,
                        Hora = atendimento.Hora,
                        ClienteId = atendimento.ClienteId,
                        FuncionarioId = atendimento.FuncionarioId,
                        ServicoId = atendimento.ServicoId,
                        ValorTotal = atendimento.ValorTotal,
                        Desconto = atendimento.Desconto,
                        ValorComDesconto = atendimento.ValorComDesconto,
                        ValorPago = atendimento.ValorPago,
                        Troco = atendimento.Troco,
                        FormaPagamentoId = atendimento.FormaPagamentoId,
                    });
                }
                else
                {
                    throw new Exception("Não existe atendimentos cadastrados.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<AtendimentoDto>> ListarPorFormaPagamento(int formaPagamentoId)
        {
            try
            {
                var atendimentos = await ListarTodos();

                if (atendimentos.Any())
                {
                    return atendimentos.Where(a => a.FormaPagamentoId.Equals(formaPagamentoId)).Select(atendimento => new AtendimentoDto
                    {
                        Id = atendimento.Id,
                        Data = atendimento.Data,
                        Hora = atendimento.Hora,
                        ClienteId = atendimento.ClienteId,
                        FuncionarioId = atendimento.FuncionarioId,
                        ServicoId = atendimento.ServicoId,
                        ValorTotal = atendimento.ValorTotal,
                        Desconto = atendimento.Desconto,
                        ValorComDesconto = atendimento.ValorComDesconto,
                        ValorPago = atendimento.ValorPago,
                        Troco = atendimento.Troco,
                        FormaPagamentoId = atendimento.FormaPagamentoId,
                    });
                }
                else
                {
                    throw new Exception("Não existe atendimentos cadastrados.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<AtendimentoDto>> ListarPorFuncionario(int funcionarioId)
        {
            try
            {
                var atendimentos = await ListarTodos();

                if (atendimentos.Any())
                {
                    return atendimentos.Where(a => a.FuncionarioId.Equals(funcionarioId)).Select(atendimento => new AtendimentoDto
                    {
                        Id = atendimento.Id,
                        Data = atendimento.Data,
                        Hora = atendimento.Hora,
                        ClienteId = atendimento.ClienteId,
                        FuncionarioId = atendimento.FuncionarioId,
                        ServicoId = atendimento.ServicoId,
                        ValorTotal = atendimento.ValorTotal,
                        Desconto = atendimento.Desconto,
                        ValorComDesconto = atendimento.ValorComDesconto,
                        ValorPago = atendimento.ValorPago,
                        Troco = atendimento.Troco,
                        FormaPagamentoId = atendimento.FormaPagamentoId,
                    });
                }
                else
                {
                    throw new Exception("Não existe atendimentos cadastrados.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<AtendimentoDto>> ListarPorServico(int servicoId)
        {
            try
            {
                var atendimentos = await ListarTodos();

                if (atendimentos.Any())
                {
                    return atendimentos.Where(a => a.ServicoId.Equals(servicoId)).Select(atendimento => new AtendimentoDto
                    {
                        Id = atendimento.Id,
                        Data = atendimento.Data,
                        Hora = atendimento.Hora,
                        ClienteId = atendimento.ClienteId,
                        FuncionarioId = atendimento.FuncionarioId,
                        ServicoId = atendimento.ServicoId,
                        ValorTotal = atendimento.ValorTotal,
                        Desconto = atendimento.Desconto,
                        ValorComDesconto = atendimento.ValorComDesconto,
                        ValorPago = atendimento.ValorPago,
                        Troco = atendimento.Troco,
                        FormaPagamentoId = atendimento.FormaPagamentoId,
                    });
                }
                else
                {
                    throw new Exception("Não existe atendimentos cadastrados.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<AtendimentoDto>> ListarTodos()
        {
            try
            {
                var atendimentos = await _repositorio.ListarTodos();

                if (atendimentos.Any())
                {
                    return atendimentos.Select(atendimento => new AtendimentoDto
                    {
                        Id = atendimento.Id,
                        Data = atendimento.Data,
                        Hora = atendimento.Hora,
                        ClienteId = atendimento.ClienteId,
                        FuncionarioId = atendimento.FuncionarioId,
                        ServicoId = atendimento.ServicoId,
                        ValorTotal = atendimento.ValorTotal,
                        Desconto = atendimento.Desconto,
                        ValorComDesconto = atendimento.ValorComDesconto,
                        ValorPago = atendimento.ValorPago,
                        Troco = atendimento.Troco,
                        FormaPagamentoId = atendimento.FormaPagamentoId,
                    });
                }
                else
                {
                    throw new Exception("Não existe atendimentos cadastrados.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<AtendimentoDto> PegarPorId(int id)
        {
            try
            {
                var atendimento = await _repositorio.BuscarPorId(id);

                if (atendimento is null)
                {
                    throw new Exception("Atendimento não encontrado.");
                }

                return new AtendimentoDto
                {
                    Id = atendimento.Id,
                    Data = atendimento.Data,
                    Hora = atendimento.Hora,
                    ClienteId = atendimento.ClienteId,
                    FuncionarioId = atendimento.FuncionarioId,
                    ServicoId = atendimento.ServicoId,
                    ValorTotal = atendimento.ValorTotal,
                    Desconto = atendimento.Desconto,
                    ValorComDesconto = atendimento.ValorComDesconto,
                    ValorPago = atendimento.ValorPago,
                    Troco = atendimento.Troco,
                    FormaPagamentoId = atendimento.FormaPagamentoId,
                };
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task Remover(int id)
        {
            try
            {
                var atendimento = await _repositorio.BuscarPorId(id);

                if (atendimento is null)
                    throw new Exception("Atednimento não encontrado.");
                else
                    await _repositorio.Remover(atendimento);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<AtendimentoDto> Salvar(AtendimentoDto atendimentoDto)
        {
            try
            {
                Atendimento atendimento = new(atendimentoDto.Id, atendimentoDto.Data, atendimentoDto.Hora, atendimentoDto.ClienteId, atendimentoDto.FuncionarioId, atendimentoDto.ServicoId, atendimentoDto.ValorTotal, atendimentoDto.Desconto, atendimentoDto.ValorComDesconto, atendimentoDto.ValorPago, atendimentoDto.Troco, atendimentoDto.FormaPagamentoId);
                Atendimento resultado;

                if (atendimentoDto.Id.Equals(0))
                {
                    resultado = await _repositorio.Adicionar(atendimento);

                    if (resultado is null)
                        throw new Exception("Erro ao cadastrar, contate o administrador do sistema.");
                    else
                        atendimentoDto.Id = resultado.Id;

                    return atendimentoDto;
                }
                else
                {
                    resultado = await _repositorio.Atualizar(atendimento);

                    if (resultado is null)
                        throw new Exception("Erro ao atualizar, contate o administrador do sistema.");

                    return atendimentoDto;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
