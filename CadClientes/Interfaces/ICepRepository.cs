using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadClientes.Interfaces
{
    public interface ICepRepository
    {
        Cep BuscarCep(string cep);
    }
}
