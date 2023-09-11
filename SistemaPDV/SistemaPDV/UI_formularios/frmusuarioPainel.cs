using SistemaPDV.UI_formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPDV
{
    public partial class frmUsuarioPainel : Form
    {
        public frmUsuarioPainel()
        {
            InitializeComponent();
        }

        //public static string transacaoTipo;

        private void frmUsuarioPainel_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void frmUsuarioPainel_Load(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliDis clidis = new frmCliDis();
            clidis.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompraVenda compra = new frmCompraVenda();
            compra.Show();
            //transacaoTipo = "Compras";
        }

        private void inventárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventario inventario = new frmInventario();
            inventario.Show();
        }
    }
}
