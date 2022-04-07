using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using RestSharp.Serialization.Json;
using System.Net;
using RestSharp;
using CadClientes.DAO;
using System.Text.Json;
using CadClientes.Interfaces;
namespace CadClientes
{
    public class ServiceCep : ICepService
    {
        
        private readonly ICepRepository _cepRepository;
        public ServiceCep(ICepRepository cepRepository)
        {
            _cepRepository = cepRepository;
        }
        public Cep BuscarCep(string cep)
        {
            try
            {
                return _cepRepository.BuscarCep(cep);
            }
            catch 
            {
                return null;
            }
        }
    }
}
