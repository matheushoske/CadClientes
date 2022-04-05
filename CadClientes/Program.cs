using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadClientes.Interfaces;
using CadClientes.Service;
using CadClientes.Repository;
using CadClientes.DAO;
using System.Net.Http;
using System.Net;
using System.Text.Json;

namespace CadClientes
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();
            ConfigureServices(services,args.Length > 0 ? args[0] : "https://localhost:44382/");
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form = serviceProvider.GetRequiredService<CadastroClientes>();
                Application.Run(form);
            }
               
        }

        private static void ConfigureServices(IServiceCollection services, string url)
        {
            #region Instâncias dos Singletons
            HttpClient httpClient = new()
            {
                BaseAddress = new(url),
            };
            JsonSerializerOptions jsonoptions = new()
            {
                IncludeFields = true,
                PropertyNameCaseInsensitive = true
            };
            #endregion
            ServicePointManager.FindServicePoint(httpClient.BaseAddress).ConnectionLeaseTimeout = 15000; // 15 segundos

            services.AddSingleton<JsonSerializerOptions>(jsonoptions);
            services.AddSingleton<HttpClient>(httpClient);
            services.AddScoped<IFormConfig, Config>();
            services.AddScoped<ICepService, ServiceCep>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IApiDAO, ApiDAO>();
            services.AddScoped<CadastroClientes>();
        }
    }
}
