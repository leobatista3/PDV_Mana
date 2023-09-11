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
    public partial class frmAdminPainel : Form
    {
        public frmAdminPainel()
        {
            InitializeComponent();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmusuarios user = new frmusuarios();
            user.Show();
        }

        private void frmAdminPainel_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void frmAdminPainel_Load(object sender, EventArgs e)
        {

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias categoria = new frmCategorias();
            categoria.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutos produtos = new frmProdutos();
            produtos.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliDis clidis = new frmCliDis();
            clidis.Show();
        }

        private void compraVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompraVenda compra = new frmCompraVenda();
            compra.Show();
        }

        private void transaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransacao transacao = new frmTransacao();
            transacao.Show();
        }

        private void inventárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventario inventario = new frmInventario();
            inventario.Show();
        }
    }
}
