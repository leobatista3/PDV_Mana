using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDV.BLL_Classes
{
    internal class categoriasBLL
    {
        public int id { get; set; }
        public string title { get; set; }
        public string descricao { get; set; }
        public DateTime add_data { get; set; }
        public int add_por { get; set; }
    }
}
