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
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        categoriasDAL cdal = new categoriasDAL();
        produtosDAL pdal = new produtosDAL();

        private void frmInventario_Load(object sender, EventArgs e)
        {
            DataTable cdt = cdal.Select();
            cmbTipoInventario.DataSource = cdt;

            cmbTipoInventario.DisplayMember = "title";
            cmbTipoInventario.ValueMember = "title";

            DataTable pdt = pdal.Select();
            dvgInventario.DataSource = pdt;
        }

        private void cmbTipoInventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoria = cmbTipoInventario.Text;

            DataTable dt = pdal.MostrarProdutoPorCat(categoria);

            dvgInventario.DataSource = dt;
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            DataTable dt = pdal.Select();
            dvgInventario.DataSource= dt;
        }
    }
}
