using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CadClientes.Interfaces;
using CadClientes.Model;
namespace CadClientes.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        IApiDAO _apiDAO;
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _serializerOptions;
        private readonly string _requestUri = "api/Clientes";
        public ClienteRepository(IApiDAO apiDAO, HttpClient httpClient, JsonSerializerOptions serializerOptions)
        {
            _apiDAO = apiDAO;
            _httpClient = httpClient;
            _serializerOptions = serializerOptions;
        }
        public async void AdicionarCliente(Cliente cliente) 
        {
            var serializedProduto = JsonSerializer.Serialize(cliente);
            var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
            var result = await _httpClient.PostAsync(_requestUri, content);
            if (!result.IsSuccessStatusCode) throw new ArgumentException("Erro ao adicionar cliente. Retorno API:"+ result.ReasonPhrase);
            
        }
        public Cliente BuscarCliente(int id) 
        {
            string uriGet = string.Format(String.Concat(_httpClient.BaseAddress.AbsoluteUri,_requestUri,"/{0}"), id);
            return GetCliente(uriGet)[0];
        }

        public Cliente BuscarUltimoCliente() 
        {
            var uriGet = String.Concat(_httpClient.BaseAddress.AbsoluteUri, _requestUri, "/Ultimo");
            return  GetCliente(uriGet)[0];
        }

        private List<Cliente> GetCliente(string uri) 
        {
            List<Cliente> cliente = null;
            Task.Run(async () => { 
              var cont = await _apiDAO.Get(uri);
              cliente = JsonSerializer.Deserialize<List<Cliente>>(cont, _serializerOptions);
            }).Wait();
            return cliente;
        }
        public bool TestarApi() 
        {
            _apiDAO.Test(String.Concat(_httpClient.BaseAddress.AbsoluteUri, _requestUri, "/Ultimo"));
            return true;
        }
    }
}
