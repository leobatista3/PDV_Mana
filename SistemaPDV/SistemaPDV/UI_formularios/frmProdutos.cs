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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }
        categoriasDAL cdal = new categoriasDAL();
        //readonly userDAL_Classes cdal = new userDAL_Classes();
        produtosBLL p = new produtosBLL();
        produtosDAL pdal = new produtosDAL();
        //categoriasDAL dal = new categoriasDAL();

        userDAL_Classes udal = new userDAL_Classes();

        

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            
            DataTable categoriasDT = cdal.Select();
            cmbcategoriaProduto.DataSource = categoriasDT;
            cmbcategoriaProduto.DisplayMember = "title";
            cmbcategoriaProduto.ValueMember = "title";

            DataTable dt = pdal.Select();
            dvgProduto.DataSource = dt;


        }

        private void btncadastrarProduto_Click(object sender, EventArgs e)
        {
            p.nome = txtnomeProduto.Text;
            p.categoria = cmbcategoriaProduto.Text;
            p.descricao = txtdescricaoProduto.Text;
            p.avaliacao = decimal.Parse(txtavaliacaoProduto.Text);
            p.quant = 0;
            p.add_data = DateTime.Now;

            string logado_sistema = frmLogin.logado_sistema;
            userBLL_Class usr = udal.GETIDfromnomeusuario(logado_sistema);
            p.add_por = usr.id;

            bool success = pdal.Insert(p);

            if (success == true)
            {
                MessageBox.Show("PRODUTO CADASTRADO COM SUCESSO");
                Limpar();
                DataTable dt = pdal.Select();
                dvgProduto.DataSource= dt;
            }
            else
            {
                MessageBox.Show("ERRO NO CADASTRO DO PRODUTO");
            }
        }

        public void Limpar()
        {
            txtidProduto.Text = "";
            txtnomeProduto.Text = "";
            txtdescricaoProduto.Text = "";
            txtavaliacaoProduto.Text = "";
            txtpesquisarProduto.Text = "";
        }

        private void dvgProduto_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtidProduto.Text = dvgProduto.Rows[rowIndex].Cells[0].Value.ToString();
            txtnomeProduto.Text = dvgProduto.Rows[rowIndex].Cells[1].Value.ToString();
            cmbcategoriaProduto.Text = dvgProduto.Rows[rowIndex].Cells[2].Value.ToString();
            txtavaliacaoProduto.Text = dvgProduto.Rows[rowIndex].Cells[4].Value.ToString();
            txtdescricaoProduto.Text = dvgProduto.Rows[rowIndex].Cells[3].Value.ToString();
            
        }

        private void btnatualizarProduto_Click(object sender, EventArgs e)
        {
            p.id = int.Parse(txtidProduto.Text);
            p.nome = txtnomeProduto.Text;
            p.categoria = cmbcategoriaProduto.Text;            
            p.avaliacao = decimal.Parse(txtavaliacaoProduto.Text);
            p.descricao = txtdescricaoProduto.Text;
            p.add_data = DateTime.Now;

            string logado_User = frmLogin.logado_sistema;
            userBLL_Class usr = udal.GETIDfromnomeusuario(logado_User);

            p.add_por = usr.id;

            bool sucesso = pdal.Update(p);

            if (sucesso == true)
            {
                MessageBox.Show("CADASTRO ATUALIZADO COM SUCESSO!!!");
                Limpar();
                DataTable dt = pdal.Select();
                dvgProduto.DataSource = dt;
            }
            else
            {
                MessageBox.Show("NÃO FOI POSSÍVEL ATUALIZAR ESTE CADASTRO");
            }
        }

        private void btnexcluirProduto_Click(object sender, EventArgs e)
        {
            p.id = Convert.ToInt32(txtidProduto.Text);

            bool sucesso = pdal.Delete(p);

            if (sucesso == true)
            {
                MessageBox.Show("EXCLUÍDO COM SUCESSO!!!");
                Limpar();
                DataTable dt = pdal.Select();
                dvgProduto.DataSource = dt;
            }
            else
            {
                MessageBox.Show("NÃO FOI POSSÍVEL EXCLUIR");
            }
        }

        private void txtpesquisarProduto_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtpesquisarProduto.Text;

            if (keywords != null)
            {
                DataTable dt = pdal.Pesquisar(keywords);
                dvgProduto.DataSource = dt;
            }
            else
            {
                DataTable dt = pdal.Pesquisar(keywords);
                dvgProduto.DataSource = dt;
            }
        }

        private void txtidProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dvgProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cmbcategoriaProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
