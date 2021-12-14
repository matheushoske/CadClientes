using System;
using System.Collections.Generic;
using System.Text;
using CadClientes.Model;
using System.Net.Http;
using Newtonsoft.Json;
using RestSharp;
using System.Net;
using CadClientes.Util;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;
using RestSharp.Serialization.Json;
using Newtonsoft.Json.Serialization;


namespace CadClientes.Service
{
    class ServiceCliente
    {
        //string URI = "https://localhost:44382/api/Clientes";
        public async void InsereCliente(Cliente cli)
        {
            using (var client = new HttpClient())
            {
                var serializedProduto = JsonConvert.SerializeObject(cli);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(Variaveis.URI, content);
            }
        }
    

        public Cliente BuscaCliente(int id)
        {
            Cliente retorno;
            List<Cliente> list = new List<Cliente>();
            RestClient rc = new RestClient(string.Format(Variaveis.URI + "/{0}", id));
            RestRequest rr = new RestRequest(Method.GET);

            IRestResponse irr = rc.Execute(rr);
            if (irr.StatusCode == HttpStatusCode.BadRequest)
            {
                return null;
            }   
            else
            {
                list = JsonConvert.DeserializeObject<List<Cliente>>(irr.Content);
                try
                {
                    retorno = list[0];
                    return retorno;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        public int RetornaUltimoClienteid(int somar = 0)
        {
            Cliente request;
            List<Cliente> list = new List<Cliente>();
            RestClient rc = new RestClient(Variaveis.URI + "/Ultimo");
            RestRequest rr = new RestRequest(Method.GET);
            IRestResponse irr = rc.Execute(rr);
            if (irr.StatusCode == HttpStatusCode.BadRequest || irr.StatusCode == 0)
            {
                return -1;
            }
            else
            {
               list = JsonConvert.DeserializeObject<List<Cliente>>(irr.Content);
                request = list[0];
                return request.id + somar;
            }
            
        }

        


    }
    
}
