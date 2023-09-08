using SistemaPDV.BLL_Classes;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();
        public static string logado_sistema;

        private void button1_Click(object sender, EventArgs e)
        {
            l.nome = txtusuario.Text.Trim();
            l.senha = txtsenha.Text.Trim();
            l.tipo_usuario = cmbtipousuario.Text.Trim();

            bool success = dal.loginChecar(l);

            if (success == true)
            {
                MessageBox.Show("Login com Sucesso!!!");

                switch (l.tipo_usuario)
                {
                    case "Admin":
                        {
                            frmAdminPainel admin = new frmAdminPainel();
                            admin.Show();
                            this.Hide();
                        }
                        break;
                    case "Usuario":
                        {
                            frmUsuarioPainel user = new frmUsuarioPainel();
                            user.Show();
                            this.Hide();
                        }
                        break;
                    default:
                        {
                            MessageBox.Show("Erro ao abrir a aplicação!");
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Não foi possível entrar!");
            }

        }
    }
}
