using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadClientes.Model;
namespace CadClientes.Interfaces
{
    public interface IClienteService
    {
        public bool AdicionarCliente(Cliente cli);
        public Cliente BuscarCliente(int id);
        public int RetornaUltimoClienteid(int id);
        public bool TestarComunicacao();
    }
}
