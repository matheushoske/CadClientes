using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadClientes.Model;
namespace CadClientes.Interfaces
{
    public interface IClienteRepository
    {
        void AdicionarCliente(Cliente cli);
        Cliente BuscarCliente(int id);

        Cliente BuscarUltimoCliente();

        bool TestarApi();
    }
}
