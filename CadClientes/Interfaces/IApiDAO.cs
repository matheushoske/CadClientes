using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CadClientes.Interfaces
{
    public interface IApiDAO
    {
        Task<string> Get(string uri);
        void Post();
        bool Test(string uri);
    }
}
