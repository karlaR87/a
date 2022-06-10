using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace proyectoLogin1
{
    class Login
    {
        private string usuario;
        private string contra;
        conexion c = new conexion();

        public Login(string usuer, string password)
        {
            usuario = usuer;
            contra = password;
        }

        
        public bool VerificacionDeUsuario()
        {
            string comando = "select user_name from Usuarios where user_name ='"+usuario+"';";
            MySqlConnection con = c.conectar();

            try
            {
                MySqlCommand cmd = new MySqlCommand(comando, con);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public bool VerificacionDeContra()
        {
            string comando = "select contraseña from Usuarios where contraseña ='" + contra + "';";

            MySqlConnection con = c.conectar();

            try
            {
                MySqlCommand cmd = new MySqlCommand(comando, con);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
