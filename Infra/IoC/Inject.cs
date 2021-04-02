using Dominio.Interfaces.Repositorios;
using Dominio.Interfaces.Servicos;
using Infra.Repositorios;
using Infra.Servicos;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.IoC
{
    public static class Inject
    {
        public static void InjectService(this IServiceCollection services)
        {
            #region Repositorios

            services.AddScoped<IAtendimentoRepositorio, AtendimentoRepositorio>();
            services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
            services.AddScoped<IEnderecoRepositorio, EnderecoRepositorio>();
            services.AddScoped<IFormaPagamentoRepositorio, FormaPagamentoRepositorio>();
            services.AddScoped<IFuncionarioRepositorio, FuncionarioRepositorio>();
            services.AddScoped<IServicoRepositorio, ServicoRepositorio>();

            #endregion

            #region Servicos

            services.AddScoped<IAtendimentoService, AtendimentoService>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IEnderecoService, EnderecoService>();
            services.AddScoped<IFormaPagamentoService, FormaPagamentoService>();
            services.AddScoped<IFuncionarioService, FuncionarioService>();
            services.AddScoped<IServicoService, ServicoService>();

            #endregion
        }
    }
}
