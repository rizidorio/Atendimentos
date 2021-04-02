using Dominio.Dtos;
using Dominio.Interfaces.Servicos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/FormaPagamento")]
    public class FormaPagamentoController : ControllerBase
    {
        private readonly IFormaPagamentoService _service;

        public FormaPagamentoController(IFormaPagamentoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var formasPagamento = await _service.ListarTodos();

                return Ok(formasPagamento);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("ativos")]
        public async Task<IActionResult> ListarAtivo()
        {
            try
            {
                var formasPagamento = await _service.ListarSomenteAtivo();

                return Ok(formasPagamento);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{codigo}")]
        public async Task<IActionResult> GetByCodigo(string codigo)
        {
            try
            {
                var formaPagamento = await _service.PegarPorCodigo(codigo);

                return Ok(formaPagamento);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] FormaPagamentoDto formaPagamentoDto)
        {
            try
            {
                var resultado = await _service.Salvar(formaPagamentoDto);
                return CreatedAtAction(nameof(GetByCodigo), new { codigo = resultado.Codigo }, formaPagamentoDto);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] FormaPagamentoDto formaPagamentoDto)
        {
            try
            {
                var formaPagamento = await _service.PegarPorCodigo(formaPagamentoDto.Codigo);

                if (formaPagamento is null)
                    return NotFound();

                formaPagamento.Nome = formaPagamentoDto.Nome;
                formaPagamento.Ativo = formaPagamentoDto.Ativo;

                await _service.Salvar(formaPagamento);

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
