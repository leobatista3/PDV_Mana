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
    public partial class frmusuarios : Form
    {
        public frmusuarios()
        {
            InitializeComponent();
        }
        userBLL_Class u = new userBLL_Class();
        userDAL_Classes dal = new userDAL_Classes();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            u.nome = txtnome.Text;
            u.sobrenome = txtsobrenome.Text;
            u.email = txtemail.Text;
            u.usuario = txtusuario.Text;
            u.senha = txtsenha.Text;
            u.contato = txtcontato.Text;
            u.endereco = txtendereco.Text;
            u.sexo = cmbsexo.Text;
            u.tipo_usuario = cmbtipousuario.Text;
            u.add_data = DateTime.Now;
            u.add_por = 1;

            bool sucess = dal.Insert(u);
            if(sucess == true)
            {
                MessageBox.Show("CADASTRO REALIZADO COM SUCESSO");
                Limpar();
            }
            else
            {
                MessageBox.Show("ERRO NO CADASTRO");
            }
            DataTable dt = dal.Select();
            dvgusuario.DataSource = dt;

        }

        private void frmusuarios_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dvgusuario.DataSource = dt;
        }

        private void Limpar()
        {
            txtid.Text = "";
            txtnome.Text = "";
            txtsobrenome.Text = "";
            txtemail.Text = "";
            txtusuario.Text = "";
            txtsenha.Text = "";
            txtcontato.Text = "";
            txtendereco.Text = "";
            cmbsexo.Text = "";
            cmbtipousuario.Text = "";
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dvgusuario_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtid.Text = dvgusuario.Rows[rowIndex].Cells[0].Value.ToString();
            txtnome.Text = dvgusuario.Rows[rowIndex].Cells[1].Value.ToString();
            txtsobrenome.Text = dvgusuario.Rows[rowIndex].Cells[2].Value.ToString();
            txtemail.Text = dvgusuario.Rows[rowIndex].Cells[3].Value.ToString();
            txtusuario.Text = dvgusuario.Rows[rowIndex].Cells[4].Value.ToString();
            txtsenha.Text = dvgusuario.Rows[rowIndex].Cells[5].Value.ToString();
            txtcontato.Text = dvgusuario.Rows[rowIndex].Cells[6].Value.ToString();
            txtendereco.Text = dvgusuario.Rows[rowIndex].Cells[7].Value.ToString();
            cmbsexo.Text = dvgusuario.Rows[rowIndex].Cells[8].Value.ToString();
            cmbtipousuario.Text = dvgusuario.Rows[rowIndex].Cells[9].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            u.id = Convert.ToInt32(txtid.Text);

            u.nome = txtnome.Text;
            u.sobrenome = txtsobrenome.Text;
            u.email = txtemail.Text;
            u.usuario = txtusuario.Text;
            u.senha = txtsenha.Text;
            u.contato = txtcontato.Text;
            u.endereco = txtendereco.Text;
            u.sexo = cmbsexo.Text;
            u.tipo_usuario = cmbtipousuario.Text;
            u.add_data = DateTime.Now;
            u.add_por = 1;

            bool sucesso = dal.Update(u);

            if (sucesso == true)
            {
                MessageBox.Show("ATUALIZADO!!!");
                Limpar();
            }
            else
            {
                MessageBox.Show("NÃO FOI POSSÍVEL ATUALIZAR ESTE CADASTRO");
            }
            DataTable dt = dal.Select();
            dvgusuario.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            u.id = Convert.ToInt32(txtid.Text);

            bool sucesso = dal.Delete(u);

            if (sucesso == true)
            {
                MessageBox.Show("EXCLUÍDO COM SUCESSO!!!");
                Limpar();
            }
            else
            {
                MessageBox.Show("NÃO FOI POSSÍVEL EXCLUIR");
            }
            DataTable dt = dal.Select();
            dvgusuario.DataSource = dt;
        }

        private void txtpesquisar_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtpesquisar.Text;

            if (keywords != null)
            {
                DataTable dt = dal.Pesquisar(keywords);
                dvgusuario.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Pesquisar(keywords);
                dvgusuario.DataSource = dt;
            }
        }

        private void dvgusuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
