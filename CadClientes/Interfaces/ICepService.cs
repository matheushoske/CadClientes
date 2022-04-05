using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadClientes.Model;
namespace CadClientes.Interfaces
{
    public interface ICepService
    {
        Cep BuscarCep(string Cep);
    }
}
