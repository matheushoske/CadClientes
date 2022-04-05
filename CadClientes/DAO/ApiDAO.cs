using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using CadClientes.Interfaces;
namespace CadClientes.DAO
{
   
    public class ApiDAO : IApiDAO
    {
        
        public async Task<string> Get(string uri) 
        {

            using HttpClient client = new();
            HttpResponseMessage response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                var TaskContent = response.Content.ReadAsStringAsync();

                var cont = await TaskContent;

                return cont;
            }
            else
            {
                throw new Exception("Erro ao obter o cliente: Retorno API" + response.ReasonPhrase);
            }
        }
        public void Post()
        {

        }
        public bool Test(string uri) 
        {
            try
            {
                Task.Run(async () => {
                  string r = await this.Get(uri);
                }).Wait();
                return true;
            }
            catch (Exception)
            {
                return false; 
            }
        }
    }
}
