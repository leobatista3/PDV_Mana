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

        private void frmUsuarioPainel_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void frmUsuarioPainel_Load(object sender, EventArgs e)
        {

        }
    }
}
