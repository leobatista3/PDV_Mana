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
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        categoriasBLL c = new categoriasBLL();
        categoriasDAL dal = new categoriasDAL();
        userDAL_Classes udal = new userDAL_Classes();
        private object keywords;


        private void button1_Click(object sender, EventArgs e)
        {
            c.title = txttitulocategoria.Text;
            c.descricao = txtdescricao.Text;
            c.add_data = DateTime.Now;

            string logado_sistema = frmLogin.logado_sistema;
            userBLL_Class usr = udal.GETIDfromnomeusuario(logado_sistema);
            c.add_por = usr.id;

            bool success = dal.Insert(c);

            if (success == true)
            {
                MessageBox.Show("Categoria Cadastrada com sucesso!!!");
                Limpar();
                DataTable dt = dal.Select();
                //dvgusuario.DataSource = dt;
                dvgcategoria.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Não foi possível cadastrar esta categoria!");
            }
        }

        private void txtid_ReadOnlyChanged(object sender, EventArgs e)
        {

        }
        public void Limpar()
        {
            txtid.Text = "";
            txttitulocategoria.Text = "";
            txtdescricao.Text = "";
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            //dvgusuario.DataSource = dt;
            dvgcategoria.DataSource = dt;
        }

        private void dvgcategoria_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtid.Text = dvgcategoria.Rows[rowIndex].Cells[0].Value.ToString();
            txttitulocategoria.Text = dvgcategoria.Rows[rowIndex].Cells[1].Value.ToString();
            txtdescricao.Text = dvgcategoria.Rows[rowIndex].Cells[2].Value.ToString();

        }

        private void btnatualizarcategoria_Click(object sender, EventArgs e)
        {
            //c.id = int.Parse(txtid.Text);
            c.id = Convert.ToInt32(txtid.Text);

            c.title = txttitulocategoria.Text;
            c.descricao = txtdescricao.Text;
            c.add_data = DateTime.Now;
            string logado_User = frmLogin.logado_sistema;
            userBLL_Class usr = udal.GETIDfromnomeusuario(logado_User);

            c.add_por = usr.id;

            bool sucesso = dal.Update(c);

            if (sucesso == true)
            {
                MessageBox.Show("CADASTRO ATUALIZADO COM SUCESSO!!!");
                Limpar();
                DataTable dt = dal.Select();
                dvgcategoria.DataSource = dt;
            }
            else
            {
                MessageBox.Show("NÃO FOI POSSÍVEL ATUALIZAR ESTE CADASTRO");
            }

        }

        private void btnexcluircategoria_Click(object sender, EventArgs e)
        {
            c.id = Convert.ToInt32(txtid.Text);

            bool sucesso = dal.Delete(c);

            if (sucesso == true)
            {
                MessageBox.Show("EXCLUÍDO COM SUCESSO!!!");
                Limpar();
                DataTable dt = dal.Select();
                dvgcategoria.DataSource = dt;
            }
            else
            {
                MessageBox.Show("NÃO FOI POSSÍVEL EXCLUIR");
            }
        }

        private void txtpesquisarcategoria_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtpesquisarcategoria.Text;

            if (keywords != null)
            {
                DataTable dt = dal.Pesquisar(keywords);
                dvgcategoria.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Pesquisar(keywords);
                dvgcategoria.DataSource = dt;
            }
        }
    }
}
