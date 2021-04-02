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
                        Id = endereco.Id,
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
                        Id = endereco.Id,
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
                        Id = endereco.Id,
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

        public async Task<EnderecoDto> PegarPorId(int id)
        {
            try
            {
                var endereco = await _repositorio.BuscarPorId(id);

                if (endereco is null)
                    throw new Exception("Endereço não encontrado.");

                return new EnderecoDto
                {
                    Id = endereco.Id,
                    Cep = endereco.Cep,
                    Logradouro = endereco.Logradouro,
                    Bairro = endereco.Bairro,
                    Localidade = endereco.Localidade,
                    Uf = endereco.Uf,
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
                var endereco = await _repositorio.BuscarPorId(id);

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
                Endereco endereco = new(enderecoDto.Id, enderecoDto.Cep, enderecoDto.Logradouro, enderecoDto.Bairro, enderecoDto.Localidade, enderecoDto.Uf);
                Endereco resultado;

                if (enderecoDto.Id.Equals(0))
                {
                    resultado = await _repositorio.Adicionar(endereco);

                    if (resultado is null)
                        throw new Exception("Erro ao cadastrar, contate o administrador do sistema.");
                    else
                        enderecoDto.Id = resultado.Id;

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
