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
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepositorio _repositorio;

        public ClienteService(IClienteRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Dispose()
        {
            _repositorio.Dispose();
        }

        public async Task<IEnumerable<ClienteDto>> ListarPorNascimento(DateTime dataNascimento)
        {
            var clientes = await ListarTodos();

            return clientes.Where(c => c.Nascimento.Equals(dataNascimento));
        }

        public async Task<IEnumerable<ClienteDto>> ListarTodos()
        {
            var clientes = await _repositorio.ListarTodos();

            if (clientes.Any())
            {
                return clientes.Select(cliente => new ClienteDto
                {
                    Id = cliente.Id,
                    Codigo = cliente.Codigo,
                    Nome = cliente.Nome,
                    Cpf = cliente.Cpf,
                    Rg = cliente.Rg,
                    Sexo = cliente.Sexo,
                    EstadoCivil = cliente.EstadoCivil,
                    Nascimento = cliente.Nascimento,
                    Email = cliente.Email,
                    Telefone1 = cliente.Telefone1,
                    TipoTelefone1 = cliente.TipoTelefone1,
                    Telefone2 = cliente.Telefone2,
                    TipoTelefone2 = cliente.TipoTelefone2,
                    EnderecoId = cliente.EnderecoId,
                    Cadastro = cliente.Cadastro,
                    Alteracao = cliente.Alteracao,
                    UltimoAtendimento = cliente.UltimoAtendimento,
                });
            }
            else
                throw new Exception("Não existe clientes cadastrados.");
        }

        public async Task<ClienteDto> PegarPorId(int id)
        {
            var cliente = await _repositorio.BuscarPorId(id);

            if (cliente is null)
                throw new Exception("Cliente não encontrado.");

            return new ClienteDto
            {
                Id = cliente.Id,
                Codigo = cliente.Codigo,
                Nome = cliente.Nome,
                Cpf = cliente.Cpf,
                Rg = cliente.Rg,
                Sexo = cliente.Sexo,
                EstadoCivil = cliente.EstadoCivil,
                Nascimento = cliente.Nascimento,
                Email = cliente.Email,
                Telefone1 = cliente.Telefone1,
                TipoTelefone1 = cliente.TipoTelefone1,
                Telefone2 = cliente.Telefone2,
                TipoTelefone2 = cliente.TipoTelefone2,
                EnderecoId = cliente.EnderecoId,
                Cadastro = cliente.Cadastro,
                Alteracao = cliente.Alteracao,
                UltimoAtendimento = cliente.UltimoAtendimento,
            };
        }

        public async Task Remover(int id)
        {
            var cliente = await _repositorio.BuscarPorId(id);

            if (cliente is null)
                throw new Exception("Cliente não encontrado.");

            await _repositorio.Remover(cliente);
        }

        public async Task<ClienteDto> Salvar(ClienteDto clienteDto)
        {
            Cliente cliente = new(clienteDto.Id, clienteDto.Codigo, clienteDto.Nome, clienteDto.Cpf, clienteDto.Rg, clienteDto.Sexo, clienteDto.EstadoCivil, clienteDto.Email, clienteDto.Telefone1, clienteDto.TipoTelefone1, clienteDto.Telefone2, clienteDto.TipoTelefone2, clienteDto.Nascimento, clienteDto.Cadastro, clienteDto.Alteracao, clienteDto.UltimoAtendimento, clienteDto.EnderecoId);
            Cliente resultado;

            if (clienteDto.Id.Equals(0))
            {
                resultado = await _repositorio.Adicionar(cliente);

                if (resultado is null)
                    throw new Exception("Erro ao cadastrar, contate o administrador do sistema.");

                clienteDto.Id = resultado.Id;
                clienteDto.Codigo = resultado.Codigo;

                return clienteDto;
            }
            else
            {
                resultado = await _repositorio.Atualizar(cliente);

                if (resultado is null)
                    throw new Exception("Erro ao atualizar, contate o administrador do sistema.");

                clienteDto.Alteracao = resultado.Alteracao;
                clienteDto.UltimoAtendimento = resultado.UltimoAtendimento;

                return clienteDto;
            }
        }
    }
}
