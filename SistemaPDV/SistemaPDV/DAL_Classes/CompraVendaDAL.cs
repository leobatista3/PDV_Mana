using SistemaPDV.BLL_Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPDV.DAL_Classes
{
    internal class CompraVendaDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        
        #region inserir
        public bool Insert(CompraVendaBLL t, out int transacaoID)
        {
            bool isSucess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            transacaoID = -1;
            try
            {
                String sql = "INSERT INTO tbl_transacao(cliente_id,total_geral,transacao_data,imposto,desconto,add_por) VALUES (@cliente_id,@total_geral,@transacao_data,@imposto,@desconto,@add_por);SELECT @@IDENTITY";
                SqlCommand cmd = new SqlCommand(sql, conn);

                //cmd.Parameters.AddWithValue("@tipo", t.tipo);
                cmd.Parameters.AddWithValue("@cliente_id", t.cliente_id);
                cmd.Parameters.AddWithValue("@total_geral", t.total_geral);
                cmd.Parameters.AddWithValue("@transacao_data", t.transacao_data);
                cmd.Parameters.AddWithValue("@imposto", t.imposto);
                cmd.Parameters.AddWithValue("@desconto", t.desconto);
                cmd.Parameters.AddWithValue("@add_por", t.add_por);

                conn.Open();
                //int rows = cmd.ExecuteNonQuery();
                object o = cmd.ExecuteScalar();

                if (o != null)
                {
                    transacaoID = int.Parse(o.ToString());
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
