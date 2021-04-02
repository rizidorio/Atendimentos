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
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IFuncionarioRepositorio _repositorio;
        

        public FuncionarioService(IFuncionarioRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Dispose()
        {
            _repositorio.Dispose();
        }

        public async Task<IEnumerable<FuncionarioDto>> ListarPorFuncao(string funcao)
        {
            var funcionarios = await ListarTodos();

            return funcionarios.Where(f => f.Funcao.Equals(funcao));
        }

        public async Task<IEnumerable<FuncionarioDto>> ListarPorNascimento(DateTime dataNascimento)
        {
            var funcionarios = await ListarTodos();

            return funcionarios.Where(f => f.Nascimento.Equals(dataNascimento));
        }

        public async Task<IEnumerable<FuncionarioDto>> ListarPorServico(int servicoId)
        {
            var funcionarios = await ListarTodos();

            return funcionarios.Where(f => f.Servicos.Any(s => s.Id.Equals(servicoId)));
        }

        public async Task<IEnumerable<FuncionarioDto>> ListarTodos()
        {
            var funcionarios = await _repositorio.ListarTodos();

            if (funcionarios.Any())
            {
                return funcionarios.Select(funcionario => new FuncionarioDto
                {
                    Id = funcionario.Id,
                    Codigo = funcionario.Codigo,
                    Nome = funcionario.Nome,
                    Cpf = funcionario.Cpf,
                    Rg = funcionario.Rg,
                    Sexo = funcionario.Sexo,
                    EstadoCivil = funcionario.EstadoCivil,
                    Telefone1 = funcionario.Telefone1,
                    TipoTelefone1 = funcionario.TipoTelefone1,
                    Telefone2 = funcionario.Telefone2,
                    TipoTelefone2 = funcionario.TipoTelefone2,
                    Email = funcionario.Email,
                    Funcao = funcionario.Funcao,
                    EnderecoId = funcionario.EnderecoId,
                    Nascimento = funcionario.Nascimento,
                    Cadastro = funcionario.Cadastro,
                    Alteracao = funcionario.Alteracao,
                    Ativo = funcionario.Ativo,
                });
            }
            else
                throw new Exception("Não existe funcionários cadastrados.");
        }

        public async Task<FuncionarioDto> PegarPorId(int id)
        {
            var funcionario = await _repositorio.BuscarPorId(id);

            if (funcionario is null)
                throw new Exception("Funcionário não encontrado.");
            else
            {
                return new FuncionarioDto
                {
                    Id = funcionario.Id,
                    Codigo = funcionario.Codigo,
                    Nome = funcionario.Nome,
                    Cpf = funcionario.Cpf,
                    Rg = funcionario.Rg,
                    Sexo = funcionario.Sexo,
                    EstadoCivil = funcionario.EstadoCivil,
                    Telefone1 = funcionario.Telefone1,
                    TipoTelefone1 = funcionario.TipoTelefone1,
                    Telefone2 = funcionario.Telefone2,
                    TipoTelefone2 = funcionario.TipoTelefone2,
                    Email = funcionario.Email,
                    Funcao = funcionario.Funcao,
                    EnderecoId = funcionario.EnderecoId,
                    Nascimento = funcionario.Nascimento,
                    Cadastro = funcionario.Cadastro,
                    Alteracao = funcionario.Alteracao,
                    Ativo = funcionario.Ativo,
                };
            }
        }

        public async Task Remover(int id)
        {
            var funcionario = await _repositorio.BuscarPorId(id);

            if (funcionario is null)
                throw new Exception("Funcionário não encontrado.");

            await _repositorio.Remover(funcionario);
        }

        public async Task<FuncionarioDto> Salvar(FuncionarioDto funcionarioDto)
        {
            Funcionario funcionario = new(funcionarioDto.Id, funcionarioDto.Codigo, funcionarioDto.Nome, funcionarioDto.Cpf, funcionarioDto.Rg, funcionarioDto.Sexo, funcionarioDto.EstadoCivil, funcionarioDto.Email, funcionarioDto.Telefone1, funcionarioDto.TipoTelefone1, funcionarioDto.Telefone2, funcionarioDto.TipoTelefone2, funcionarioDto.Nascimento, funcionarioDto.Cadastro, funcionarioDto.Alteracao, funcionarioDto.EnderecoId, funcionarioDto.Funcao, funcionarioDto.Ativo);
            Funcionario resultado;

            if (funcionarioDto.Id.Equals(0))
            {
                resultado = await _repositorio.Adicionar(funcionario);

                if (resultado is null)
                    throw new Exception("Erro ao cadastrar, contate o administrador do sistema.");

                funcionarioDto.Id = resultado.Id;
                funcionarioDto.Codigo = resultado.Codigo;

                return funcionarioDto;
            }
            else
            {
                resultado = await _repositorio.Atualizar(funcionario);

                if (resultado is null)
                    throw new Exception("Erro ao atualizar, contate o administrador do sistema.");

                funcionarioDto.Alteracao = resultado.Alteracao;

                return funcionarioDto;
            }
        }
    }
}
