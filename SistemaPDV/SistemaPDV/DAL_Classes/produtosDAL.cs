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

        #region pesquisar para usar no compra e venda
        public produtosBLL PesquisarProdutosTransacao(string keywords)
        {
            produtosBLL p = new produtosBLL();
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "Select nome,avaliacao,quant from tbl_produtos WHERE id LIKE '%" + keywords + "%' or nome LIKE '%" + keywords + "%' or descricao LIKE '%" + keywords + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    p.nome = dt.Rows[0]["nome"].ToString();
                    p.avaliacao = decimal.Parse(dt.Rows[0]["avaliacao"].ToString());
                    p.quant = decimal.Parse(dt.Rows[0]["quant"].ToString());
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

            return p;
        }
        #endregion

        #region pegar produto id nome
        public produtosBLL pegarProdutoIDnome(string produtoNome)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            produtosBLL p = new produtosBLL();
            DataTable dt = new DataTable();
            try
            {
                string sql = "select id from tbl_produtos where nome = '" + produtoNome + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    p.id = int.Parse(dt.Rows[0]["id"].ToString());
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally { conn.Close(); }

            return p;
        }
        #endregion

        #region baixa nos produtos
        public decimal getproduto(int ProdutoID)
        {
            
            SqlConnection conn = new SqlConnection(myconnstring);
            
            decimal quanti = 0;
            DataTable dt = new DataTable();

            try
            {
                String sql = "select quant FROM tbl_produtos WHERE id="+ ProdutoID;
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    quanti = decimal.Parse(dt.Rows[0]["quant"].ToString());
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
            return quanti;
        }
        #endregion

        #region baixa no estoque
        public bool updateQuanti(int ProdutoID, decimal Qty)
        {
            bool sucesso = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                String sql = "update tbl_produtos set quant=@quant WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@quant", Qty);
                cmd.Parameters.AddWithValue("@id", ProdutoID);

                SqlDataAdapter adapter = new SqlDataAdapter();

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    sucesso = true;
                }
                else
                {
                    sucesso = false;
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
            return sucesso;
        }
        #endregion

        #region inserir no banco
        public bool IncProduto(int ProdutoID, decimal IncQty)
        {
            bool sucesso = false;

            SqlConnection con = new SqlConnection(myconnstring);

            try
            {
                decimal correnteQty = getproduto(ProdutoID);
                decimal NovaQty = correnteQty + IncQty;

                sucesso = updateQuanti(ProdutoID, NovaQty);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally { con.Close(); }

            return sucesso;
        }
        #endregion

        #region tirar do estoque
        public bool DescProduto(int ProdutoID, decimal Qty)
        {
            bool sucesso = false;

            SqlConnection con = new SqlConnection(myconnstring);

            try
            {
                decimal correnteQty = getproduto(ProdutoID);
                decimal NovaQty = correnteQty - Qty;

                sucesso = updateQuanti(ProdutoID, NovaQty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }

            return sucesso;
        }
        #endregion

        #region mostrar produto por categoria no inventario
        public DataTable MostrarProdutoPorCat(string categoria)
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_produtos WHERE categoria='" + categoria + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }finally { conn.Close(); }

            return dt;
        }
        #endregion
    }
}
