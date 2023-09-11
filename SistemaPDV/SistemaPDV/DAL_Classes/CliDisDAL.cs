using SistemaPDV.BLL_Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace SistemaPDV.DAL_Classes
{
    internal class CliDisDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region selecionar
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "Select * from tbl_clientes";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

            return dt;

        }
        #endregion

        #region inserir
        public bool Insert(CliDisBLL cd)
        {
            bool isSucess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "INSERT INTO tbl_clientes(tipo,nome,email,contato,endereco,add_data,add_por) VALUES (@tipo,@nome,@email,@contato,@endereco,@add_data,@add_por)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@tipo", cd.tipo);
                cmd.Parameters.AddWithValue("@nome", cd.nome);
                cmd.Parameters.AddWithValue("@email", cd.email);
                cmd.Parameters.AddWithValue("@contato", cd.contato);
                cmd.Parameters.AddWithValue("@endereco", cd.endereco);
                cmd.Parameters.AddWithValue("@add_data", cd.add_data);
                cmd.Parameters.AddWithValue("@add_por", cd.add_por);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSucess = true;
                }
                else
                {
                    isSucess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSucess;

        }
        #endregion

        #region atualizar
        public bool Update(CliDisBLL cd)
        {
            bool isSucess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "UPDATE tbl_clientes SET tipo=@tipo,nome=@nome,email=@email,contato=@contato,endereco=@endereco,add_data=@add_data,add_por=@add_por WHERE id=@id";//,quant=@quant
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@tipo", cd.tipo);
                cmd.Parameters.AddWithValue("@nome", cd.nome);
                cmd.Parameters.AddWithValue("@email", cd.email);
                cmd.Parameters.AddWithValue("@contato", cd.contato);
                cmd.Parameters.AddWithValue("@endereco", cd.endereco);
                cmd.Parameters.AddWithValue("@add_data", cd.add_data);
                cmd.Parameters.AddWithValue("@add_por", cd.add_por);
                cmd.Parameters.AddWithValue("@id", cd.id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSucess = true;
                }
                else
                {
                    isSucess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSucess;
        }
        #endregion

        #region deletar
        public bool Delete(CliDisBLL cd)
        {
            bool isSucess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "DELETE FROM tbl_clientes WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@id", cd.id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSucess = true;
                }
                else
                {
                    isSucess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSucess;
        }
        #endregion

        #region pesquisar
        public DataTable Pesquisar(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "Select * from tbl_clientes WHERE id LIKE '%" + keywords + "%' or nome LIKE '%" + keywords + "%' "; //or tipo LIKE '%" + keywords + "%'
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        #endregion

        #region pesquisar para usar para compra e venda
        public CliDisBLL PesquisarCliDisTransacao(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            CliDisBLL dc = new CliDisBLL();
            DataTable dt = new DataTable();
            try
            {
                String sql = "Select nome,email,contato,endereco from tbl_clientes WHERE id LIKE '%" + keywords + "%' or nome LIKE '%" + keywords + "%' or email LIKE '%" + keywords + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    dc.nome = dt.Rows[0]["nome"].ToString();
                    dc.email = dt.Rows[0]["email"].ToString();
                    dc.contato = dt.Rows[0]["contato"].ToString();
                    dc.endereco = dt.Rows[0]["endereco"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dc;
        }
        #endregion

        #region pegar id clidis e usar no compra e venda cadastro verde

        public CliDisBLL pegarDistClienteIDnome(string nome)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            CliDisBLL dc = new CliDisBLL();
            DataTable dt = new DataTable();
            try
            {
                string sql = "select id from tbl_clientes where nome='"+nome+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dc.id = int.Parse(dt.Rows[0]["id"].ToString());
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dc;
        }

        #endregion

    }
}
