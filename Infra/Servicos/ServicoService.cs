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
    public class ServicoService : IServicoService
    {
        private readonly IServicoRepositorio _repositorio;
        private readonly IFuncionarioService _funcionarioService;

        public ServicoService(IServicoRepositorio repositorio, IFuncionarioService funcionarioService)
        {
            _repositorio = repositorio;
            _funcionarioService = funcionarioService;
        }

        public void Dispose()
        {
            _repositorio.Dispose();
            _funcionarioService.Dispose();
        }

        public async Task<IEnumerable<ServicoDto>> ListarSomenteAtivo()
        {
            var servicos = await ListarTodos();

            return servicos.Where(s => s.Ativo);
        }

        public async Task<IEnumerable<ServicoDto>> ListarTodos()
        {
            var servicos = await _repositorio.ListarTodos();

            if (servicos.Any())
            {
                return servicos.Select(servico => new ServicoDto
                {
                    Id = servico.Id,
                    Codigo = servico.Codigo,
                    Nome = servico.Nome,
                    Descricao = servico.Descricao,
                    Valor = servico.Valor,
                    Alteracao = servico.Alteracao,
                    Ativo = servico.Ativo,
                    //Funcionarios = (IEnumerable<FuncionarioDto>)pegarFuncionariosPorServico(servico.Id),
                });
            }
            else
                throw new Exception("Não existe serviços cadastrados.");
        }

        public async Task<ServicoDto> PegarPorId(int id)
        {
            var servico = await _repositorio.BuscarPorId(id);

            if (servico is null)
                throw new Exception("Serviço não encontrado.");

            return new ServicoDto
            {
                Id = servico.Id,
                Codigo = servico.Codigo,
                Nome = servico.Nome,
                Descricao = servico.Descricao,
                Valor = servico.Valor,
                Alteracao = servico.Alteracao,
                Ativo = servico.Ativo,
                //Funcionarios = (IEnumerable<FuncionarioDto>)pegarFuncionariosPorServico(servico.Id),
            };
        }

        public async Task Remover(int id)
        {
            var servico = await _repositorio.BuscarPorId(id);

            if (servico is null)
                throw new Exception("Serviço não encontrado.");
            else
                await _repositorio.Remover(servico);
        }

        public async Task<ServicoDto> Salvar(ServicoDto servicoDto)
        {
            Servico servico = new(servicoDto.Id, servicoDto.Codigo, servicoDto.Nome, servicoDto.Descricao, servicoDto.Valor, servicoDto.Alteracao, servicoDto.Ativo);
            Servico resultado;

            if (servicoDto.Id.Equals(0))
            {
                resultado = await _repositorio.Adicionar(servico);

                if (resultado is null)
                    throw new Exception("Erro ao cadastrar, contate o administrador do sistema.");

                servicoDto.Id = resultado.Id;
                servicoDto.Codigo = resultado.Codigo;

                return servicoDto;
            }
            else
            {
                resultado = await _repositorio.Atualizar(servico);

                if (resultado is null)
                    throw new Exception("Erro ao atualizar, contate o administrador do sistema.");

                return servicoDto;
            }
        }

        //private async Task<IEnumerable<FuncionarioDto>> pegarFuncionariosPorServico(int id) => await _funcionarioService.ListarPorServico(id);
    }
}
