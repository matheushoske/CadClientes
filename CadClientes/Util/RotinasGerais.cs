using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadClientes.Util
{
   public static class RotinasGerais
    {
        public static bool TestarApi()
        {
            Service.ServiceCliente servCliente = new Service.ServiceCliente();
            if (servCliente.RetornaUltimoClienteid(1) != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
