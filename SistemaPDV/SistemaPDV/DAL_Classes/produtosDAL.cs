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
    internal class produtosDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region selecionar
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "Select * from tbl_produtos";
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
        public bool Insert(produtosBLL p)
        {
            bool isSucess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "INSERT INTO tbl_produtos(nome,categoria,descricao,avaliacao,quant,add_data,add_por) VALUES (@nome,@categoria,@descricao,@avaliacao,@quant,@add_data,@add_por)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nome", p.nome);
                cmd.Parameters.AddWithValue("@categoria", p.categoria);
                cmd.Parameters.AddWithValue("@descricao", p.descricao);
                cmd.Parameters.AddWithValue("@avaliacao", p.avaliacao);
                cmd.Parameters.AddWithValue("@quant", p.quant);
                cmd.Parameters.AddWithValue("@add_data", p.add_data);
                cmd.Parameters.AddWithValue("@add_por", p.add_por);

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
        public bool Update(produtosBLL p)
        {
            bool isSucess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "UPDATE tbl_produtos SET nome=@nome,categoria=@categoria,descricao=@descricao,avaliacao=@avaliacao,add_data=@add_data,add_por=@add_por WHERE id=@id";//,quant=@quant
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nome", p.nome);
                cmd.Parameters.AddWithValue("@categoria", p.categoria);
                cmd.Parameters.AddWithValue("@descricao", p.descricao);
                cmd.Parameters.AddWithValue("@avaliacao", p.avaliacao);
                cmd.Parameters.AddWithValue("@quant", p.quant);
                cmd.Parameters.AddWithValue("@add_data", p.add_data);
                cmd.Parameters.AddWithValue("@add_por", p.add_por);
                cmd.Parameters.AddWithValue("@id", p.id);

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
        public bool Delete(produtosBLL p)
        {
            bool isSucess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "DELETE FROM tbl_produtos WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@id", p.id);

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
                String sql = "Select * from tbl_produtos WHERE id LIKE '%" + keywords + "%' or nome LIKE '%" + keywords + "%' or descricao LIKE '%" + keywords + "%'";
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

    }
}
