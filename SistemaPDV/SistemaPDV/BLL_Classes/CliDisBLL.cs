using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDV.BLL_Classes
{
    internal class CliDisBLL
    {
        public int id { get; set; }
        public string tipo { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string contato { get; set; }
        public string endereco { get; set; }
        public DateTime add_data { get; set; }
        public int add_por { get; set; }
    }
}
