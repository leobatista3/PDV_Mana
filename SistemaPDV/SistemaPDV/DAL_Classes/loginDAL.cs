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
    internal class loginDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public bool loginChecar(loginBLL l)
        {
            bool isSucess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                String sql = "Select * from tbl_usuarios WHERE nome=@nome AND senha=@senha AND tipo_usuario=@tipo_usuario";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nome",l.nome);
                cmd.Parameters.AddWithValue("@senha", l.senha);
                cmd.Parameters.AddWithValue("@tipo_usuario", l.tipo_usuario);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                if(dt.Rows.Count > 0 )
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
            }finally { conn.Close(); }

            return isSucess;
        }

        
    }
}
