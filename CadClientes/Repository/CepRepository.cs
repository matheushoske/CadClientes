using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CadClientes.Interfaces;

namespace CadClientes.Repository
{
    
    public class CepRepository : ICepRepository
    {
        private readonly string url = "https://viacep.com.br/ws/{0}/json/";
        private readonly IApiDAO _apiDAO;
        private readonly JsonSerializerOptions _serializerOptions;
        public CepRepository(IApiDAO apiDAO, JsonSerializerOptions serializerOptions)
        {
            _serializerOptions = serializerOptions;
            _apiDAO = apiDAO;
        }

        public Cep BuscarCep(string cep) 
        {
            Cep retorno = null;
            Task.Run(async () =>
            {
                string cont = await _apiDAO.Get(string.Format(url, cep));
                retorno = JsonSerializer.Deserialize<Cep>(cont, _serializerOptions);
            }).Wait();
            return retorno;
        }
    }
}
