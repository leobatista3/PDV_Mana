using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDV.BLL_Classes
{
    internal class CompraVendaBLL
    {
        public int id { get; set; }
        public string tipo { get; set; }
        public int cliente_id { get; set; }
        public decimal total_geral { get; set; }
        public DateTime transacao_data { get; set; }
        public decimal imposto { get; set; }
        public decimal desconto { get; set; }
        public int add_por { get; set; }
        public DataTable transacaoDetalhes { get; set; }
    }
}
