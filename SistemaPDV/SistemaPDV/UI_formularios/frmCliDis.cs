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
    public partial class frmCliDis : Form
    {
        public frmCliDis()
        {
            InitializeComponent();
        }

        CliDisDAL cdal = new CliDisDAL();
        CliDisBLL cd = new CliDisBLL();
        userDAL_Classes udal = new userDAL_Classes();
        //produtosBLL p = new produtosBLL();
        //produtosDAL pdal = new produtosDAL();     
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            cd.tipo = cmbTipoCliDis.Text;
            cd.nome = txtNomeCliDis.Text;
            cd.email = txtEmailCliDis.Text;
            cd.contato = txtContatoCliDis.Text;
            cd.endereco = txtEnderecoCliDis.Text;
            cd.add_data = DateTime.Now;

            string logado_sistema = frmLogin.logado_sistema;
            userBLL_Class usr = udal.GETIDfromnomeusuario(logado_sistema);

            cd.add_por = usr.id;

            bool success = cdal.Insert(cd);

            if (success == true)
            {
                MessageBox.Show("PRODUTO CADASTRADO COM SUCESSO");
                Limpar();
                DataTable dt = cdal.Select();
                dvgCliDis.DataSource = dt;
            }
            else
            {
                MessageBox.Show("ERRO NO CADASTRO DO PRODUTO");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cd.id = int.Parse(txtidCliDis.Text);
            cd.tipo = cmbTipoCliDis.Text;
            cd.nome = txtNomeCliDis.Text;
            cd.email = txtEmailCliDis.Text;
            cd.contato = txtContatoCliDis.Text;
            cd.endereco = txtEnderecoCliDis.Text;
            
            cd.add_data = DateTime.Now;

            string logado_User = frmLogin.logado_sistema;
            userBLL_Class usr = udal.GETIDfromnomeusuario(logado_User);

            cd.add_por = usr.id;

            bool sucesso = cdal.Update(cd);

            if (sucesso == true)
            {
                MessageBox.Show("CADASTRO ATUALIZADO COM SUCESSO!!!");
                Limpar();
                DataTable dt = cdal.Select();
                dvgCliDis.DataSource = dt;
            }
            else
            {
                MessageBox.Show("NÃO FOI POSSÍVEL ATUALIZAR ESTE CADASTRO");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cd.id = Convert.ToInt32(txtidCliDis.Text);

            bool sucesso = cdal.Delete(cd);

            if (sucesso == true)
            {
                MessageBox.Show("EXCLUÍDO COM SUCESSO!!!");
                Limpar();
                DataTable dt = cdal.Select();
                dvgCliDis.DataSource = dt;
            }
            else
            {
                MessageBox.Show("NÃO FOI POSSÍVEL EXCLUIR");
            }
        }

        private void txtPesquisaCliDis_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtPesquisaCliDis.Text;

            if (keywords != null)
            {
                DataTable dt = cdal.Pesquisar(keywords);
                dvgCliDis.DataSource = dt;
            }
            else
            {
                DataTable dt = cdal.Pesquisar(keywords);
                dvgCliDis.DataSource = dt;
            }
        }

        private void dvgCliDis_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtidCliDis.Text = dvgCliDis.Rows[rowIndex].Cells[0].Value.ToString();
            cmbTipoCliDis.Text = dvgCliDis.Rows[rowIndex].Cells[1].Value.ToString();
            txtNomeCliDis.Text = dvgCliDis.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmailCliDis.Text = dvgCliDis.Rows[rowIndex].Cells[3].Value.ToString();
            txtContatoCliDis.Text = dvgCliDis.Rows[rowIndex].Cells[4].Value.ToString();
            txtEnderecoCliDis.Text = dvgCliDis.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void frmCliDis_Load(object sender, EventArgs e)
        {

            DataTable dt = cdal.Select();
            dvgCliDis.DataSource = dt;
        }

        public void Limpar()
        {
            //cmbTipoCliDis.Text = "";
            txtNomeCliDis.Text = "";
            txtEmailCliDis.Text = "";
            txtContatoCliDis.Text = "";
            txtEnderecoCliDis.Text = "";
            txtPesquisaCliDis.Text = "";
        }

        private void dvgCliDis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
