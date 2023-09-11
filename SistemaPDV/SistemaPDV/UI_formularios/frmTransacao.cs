using SistemaPDV.DAL_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPDV.UI_formularios
{
    public partial class frmTransacao : Form
    {
        public frmTransacao()
        {
            InitializeComponent();
        }

        transacaoDAL tdal = new transacaoDAL();

        private void frmTransacao_Load(object sender, EventArgs e)
        {
            DataTable dt = tdal.MostrarTransacao();
            dvgTransacao.DataSource = dt;
        }

        private void cmbTipoTransacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cmbTipoTransacao.Text;
            DataTable dt = tdal.MostrarTransacaoPeloTipo(tipo);
            dvgTransacao.DataSource = dt;
        }

        private void btnTransacao_Click(object sender, EventArgs e)
        {
            DataTable dt = tdal.MostrarTransacao();
            dvgTransacao.DataSource = dt;
        }
    }
}
