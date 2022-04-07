using System;
using System.Collections.Generic;
using System.Text;
using CadClientes.Model;
using System.Net.Http;
using System.Text.Json;
//using Newtonsoft.Json;
using RestSharp;
using System.Net;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;
using CadClientes.Interfaces;
//using RestSharp.Serialization.Json;
//using Newtonsoft.Json.Serialization;

namespace CadClientes.Service
{
    class ClienteService : IClienteService
    {

        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public bool AdicionarCliente(Cliente cli)
        {
            try
            {
                _clienteRepository.AdicionarCliente(cli);
                return true;
            }
            catch
            {
                throw;
            }

        }


        public Cliente BuscarCliente(int id)
        {
            Cliente retorno = null;
            try
            {
                retorno = _clienteRepository.BuscarCliente(id);
                return retorno;
            }
            catch (Exception)
            {
                throw;
            }

        }


        public int RetornaUltimoClienteid(int somar = 0)
        {
            try
            {
                Cliente cli = _clienteRepository.BuscarUltimoCliente();
                return cli.id + somar;
            }
            catch (Exception)
            {

                return -1;
            }
            
           
        }
        public bool TestarComunicacao() 
        {
            if (_clienteRepository.TestarApi())
                return true;
            else
                return false;
        }
            
    }

    }
    

