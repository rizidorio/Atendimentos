using Dominio.Dtos;
using Dominio.Interfaces.Servicos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/enderecos")]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoService _service;

        public EnderecoController(IEnderecoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var enderecos = await _service.ListarTodos();

                return Ok(enderecos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{cep}")]
        public async Task<IActionResult> GetByCep(string cep)
        {
            try
            {
                var endereco = await _service.PegarPorCep(cep);

                return Ok(endereco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] EnderecoDto enderecoDto)
        {
            try
            {
                var resultado = await _service.Salvar(enderecoDto);
                return CreatedAtAction(nameof(GetByCep), new { cep = resultado.Cep }, enderecoDto);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] EnderecoDto enderecoDto)
        {
            try
            {
                var endereco = await _service.PegarPorCep(enderecoDto.Cep);

                if (endereco is null)
                    return NotFound();

                endereco.Logradouro = enderecoDto.Logradouro;
                endereco.Bairro = enderecoDto.Bairro;
                endereco.Localidade = enderecoDto.Localidade;
                endereco.Uf = enderecoDto.Uf;

                await _service.Salvar(endereco);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{codigo}")]
        public async Task<IActionResult> Deletar(string codigo)
        {
            try
            {
                await _service.Remover(codigo);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
