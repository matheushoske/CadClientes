using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Serialization.Json;
using System.Net;
using RestSharp;

namespace CadClientes
{
    public class ServiceCep
    {
        public Cep BuscaCep(string cep)
        {
            Cep retorno;
            RestClient rc = new RestClient(string.Format("https://viacep.com.br/ws/{0}/json/", cep));
            RestRequest rr = new RestRequest(Method.GET);

            IRestResponse irr = rc.Execute(rr);
            if (irr.StatusCode == HttpStatusCode.BadRequest)
            {
                retorno = null;
            }
            else
            {
                retorno = new JsonDeserializer().Deserialize<Cep>(irr);
            }
            return retorno;
        }
    }
}
