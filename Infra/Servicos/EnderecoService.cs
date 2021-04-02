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
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepositorio _repositorio;

        public EnderecoService(IEnderecoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Dispose()
        {
            _repositorio.Dispose();
        }

        public async Task<IEnumerable<EnderecoDto>> ListarPorBairro(string bairro)
        {
            try
            {
                var enderecos = await ListarTodos();

                if (enderecos.Any())
                {
                    return enderecos.Where(e => e.Bairro.Equals(bairro)).Select(endereco => new EnderecoDto
                    {
                        Cep = endereco.Cep,
                        Logradouro = endereco.Logradouro,
                        Bairro = endereco.Bairro,
                        Localidade = endereco.Localidade,
                        Uf = endereco.Uf,
                    });
                }
                else
                    throw new Exception("Não existem endereços cadastrados.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<EnderecoDto>> ListarPorCidade(string Cidade)
        {
            try
            {
                var enderecos = await ListarTodos();

                if (enderecos.Any())
                {
                    return enderecos.Where(e => e.Localidade.Equals(Cidade)).Select(endereco => new EnderecoDto
                    {
                        Cep = endereco.Cep,
                        Logradouro = endereco.Logradouro,
                        Bairro = endereco.Bairro,
                        Localidade = endereco.Localidade,
                        Uf = endereco.Uf,
                    });
                }
                else
                    throw new Exception("Não existem endereços cadastrados.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<EnderecoDto>> ListarTodos()
        {
            try
            {
                var enderecos = await _repositorio.ListarTodos();

                if (enderecos.Any())
                {
                    return enderecos.Select(endereco => new EnderecoDto
                    {
                        Cep = endereco.Cep,
                        Logradouro = endereco.Logradouro,
                        Bairro = endereco.Bairro,
                        Localidade = endereco.Localidade,
                        Uf = endereco.Uf,
                    });
                }
                else
                    throw new Exception("Não existem endereços cadastrados.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<EnderecoDto> PegarPorCep(string cep)
        {
            try
            {
                var enderecos = await ListarTodos();

                return enderecos.FirstOrDefault(e => e.Cep.Equals(cep));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task Remover(string cep)
        {
            try
            {
                var endereco = await _repositorio.PegarPorCep(cep);

                if (endereco is null)
                    throw new Exception("Endereco não encontrado.");
                else
                    await _repositorio.Remover(endereco);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<EnderecoDto> Salvar(EnderecoDto enderecoDto)
        {
            try
            {
                Endereco endereco = await _repositorio.PegarPorCep(enderecoDto.Cep);
                Endereco resultado;

                if (endereco is null)
                {
                    endereco = new(enderecoDto.Cep, enderecoDto.Logradouro, enderecoDto.Bairro, enderecoDto.Localidade, enderecoDto.Uf);

                    resultado = await _repositorio.Adicionar(endereco);

                    if (resultado is null)
                        throw new Exception("Erro ao cadastrar, contate o administrador do sistema.");

                    return enderecoDto;
                }
                else
                {
                    resultado = await _repositorio.Atualizar(endereco);

                    if (resultado is null)
                        throw new Exception("Erro ao atualizar, contate o administrador do sistema.");

                    return enderecoDto;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
