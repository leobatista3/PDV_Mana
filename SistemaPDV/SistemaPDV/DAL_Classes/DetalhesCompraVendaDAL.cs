using SistemaPDV.BLL_Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPDV.DAL_Classes
{
    internal class DetalhesCompraVendaDAL    
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region inserir
        public bool Insert(DetalhesCompraVendaBLL t)
        {
            bool isSucess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            //transacaoID = -1;

            try
            {
                String sql = "INSERT INTO tbl_transacao_detalhes(produto_id,avaliacao,quanti,total,cliente_id,add_data,add_por) VALUES (@produto_id,@avaliacao,@quanti,@total,@cliente_id,@add_data,@add_por)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@produto_id", t.produto_id);
                cmd.Parameters.AddWithValue("@avaliacao", t.avaliacao);
                cmd.Parameters.AddWithValue("@quanti", t.quanti);
                cmd.Parameters.AddWithValue("@total", t.total);
                cmd.Parameters.AddWithValue("cliente_id", t.cliente_id);
                cmd.Parameters.AddWithValue("@add_data", t.add_data);
                cmd.Parameters.AddWithValue("@add_por", t.add_por);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //object o = cmd.ExecuteScalar();

                if (rows > 0)
                {
                    //transacaoID = int.Parse(o.ToString());
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

    }
}
