using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDV.BLL_Classes
{
    internal class produtosBLL
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string categoria { get; set; }
        public string descricao { get; set; }
        public decimal avaliacao { get; set; }
        public decimal quant { get; set; }
        public DateTime add_data { get; set; }
        public int add_por { get; set; }
    }
}
