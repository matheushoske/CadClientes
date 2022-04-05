using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CadClientes.Model
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime dt_nasc { get; set; }
        public long cep { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string logradouro { get; set; }
    }
}
