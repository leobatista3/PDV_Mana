using SistemaPDV.BLL_Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPDV.DAL_Classes
{
    internal class transacaoDAL
    {
        //static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public bool Insert(transacaoBLL t, out int transacaoID)
        {
            bool sucesso = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            transacaoID = -1;

            try
            {
                string sql = "INSERT INTO tbl_transacao(tipo,cliente_id,total_geral,transacao_data,imposto,desconto,add_por) VALUES (@tipo,@cliente_id,@total_geral,@transacao_data,@imposto,@desconto,@add_por)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@tipo", t.tipo);
                cmd.Parameters.AddWithValue("@cliente_id", t.cliente_id);
                cmd.Parameters.AddWithValue("@total_geral", t.total_geral);
                cmd.Parameters.AddWithValue("@transacao_data", t.transacao_data);
                cmd.Parameters.AddWithValue("imposto", t.imposto);
                cmd.Parameters.AddWithValue("@desconto", t.desconto);
                cmd.Parameters.AddWithValue("@add_por", t.add_por);

                conn.Open();
                object o = cmd.ExecuteScalar();

                if (o!=null)
                {
                    transacaoID = int.Parse(o.ToString());
                    sucesso = true;
                }
                else
                {
                    sucesso = false;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally { conn.Close(); }

            return sucesso;
        }

        public DataTable MostrarTransacao()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_transacao";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

            return dt;
        }

        public DataTable MostrarTransacaoPeloTipo(string tipo)
        {
            SqlConnection conn = new SqlConnection (myconnstring);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_transacao WHERE tipo='"+tipo+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

            return dt;
        }


    }
}
