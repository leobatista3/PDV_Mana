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
    class userDAL_Classes
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        #region Selecionar os dados do banco de dados
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "Select * from tbl_usuarios";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch(Exception ex)
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

        #region inserindo dados no banco de dados
        public bool Insert(userBLL_Class u)
        {
            bool isSucesso = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "INSERT INTO tbl_usuarios(nome,sobrenome,email,usuario,senha,contato,endereco,sexo,tipo_usuario,add_data,add_por) VALUES (@nome,@sobrenome,@email,@usuario,@senha,@contato,@endereco,@sexo,@tipo_usuario,@add_data,@add_por)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nome",u.nome);
                cmd.Parameters.AddWithValue("@sobrenome",u.sobrenome);
                cmd.Parameters.AddWithValue("@email",u.email);
                cmd.Parameters.AddWithValue("@usuario",u.usuario);
                cmd.Parameters.AddWithValue("@senha",u.senha);
                cmd.Parameters.AddWithValue("@contato",u.contato);
                cmd.Parameters.AddWithValue("@endereco",u.endereco);
                cmd.Parameters.AddWithValue("@sexo",u.sexo);
                cmd.Parameters.AddWithValue("@tipo_usuario",u.tipo_usuario);
                cmd.Parameters.AddWithValue("@add_data",u.add_data);
                cmd.Parameters.AddWithValue("@add_por",u.add_por);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSucesso=true;
                }
                else
                {
                    isSucesso=false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSucesso;
        }
        #endregion

        #region atualizar os dados no banco de dados
        public bool Update(userBLL_Class u)
        {
            bool isSucesso = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "UPDATE tbl_usuarios SET nome=@nome,sobrenome=@sobrenome,email=@email,usuario=@usuario,senha=@senha,contato=@contato,endereco=@endereco,sexo=@sexo,tipo_usuario=@tipo_usuario,add_data=@add_data,add_por=@add_por WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@sobrenome", u.sobrenome);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@usuario", u.usuario);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@contato", u.contato);
                cmd.Parameters.AddWithValue("@endereco", u.endereco);
                cmd.Parameters.AddWithValue("@sexo", u.sexo);
                cmd.Parameters.AddWithValue("@tipo_usuario", u.tipo_usuario);
                cmd.Parameters.AddWithValue("@add_data", u.add_data);
                cmd.Parameters.AddWithValue("@add_por", u.add_por);
                cmd.Parameters.AddWithValue("@id", u.id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSucesso = true;
                }
                else
                {
                    isSucesso = false;
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
            return isSucesso;
        }
        #endregion

        #region deletar dados no banco de dados
        public bool Delete(userBLL_Class u)
        {
            bool isSucesso = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "DELETE FROM tbl_usuarios WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                
                cmd.Parameters.AddWithValue("@id", u.id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSucesso = true;
                }
                else
                {
                    isSucesso = false;
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
            return isSucesso;
        }
        #endregion

        #region Pesquisar cadastro no banco 
        public DataTable Pesquisar(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "Select * from tbl_usuarios WHERE id LIKE '%"+keywords+"%' or nome LIKE '%"+keywords+"%' or sobrenome LIKE '%"+keywords+"%'";
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

        #region GET ID FROM NOME USUARIO

        public userBLL_Class GETIDfromnomeusuario(string nome)
        {
            userBLL_Class u = new userBLL_Class();
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                String sql = "SELECT id FROM tbl_usuarios WHERE nome = '"+nome+"'";
                //String sql = "SELECT id FROM tbl_usuarios WHERE nome = @nome";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("@nome", nome); // Use parâmetros para evitar injeção de SQL.
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0) //de certeza até aqui - pelo vídeo
                {
                    u.id = Convert.ToInt32(dt.Rows[0]["id"]);
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally { conn.Close();}
            return u;

        }
        
        #endregion
    }
}
