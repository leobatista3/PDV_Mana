using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDV.BLL_Classes
{
    internal class DetalhesCompraVendaBLL
    {
        public int id { get; set; }
        public int produto_id { get; set; }
        public decimal avaliacao { get; set; }
        public decimal quanti { get; set; }
        public decimal total { get; set; }
        public int cliente_id { get; set; }
        public DateTime add_data { get; set; }
        public int add_por { get; set; }
    }
}
