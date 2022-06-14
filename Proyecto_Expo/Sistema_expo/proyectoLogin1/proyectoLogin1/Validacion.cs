using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace proyectoLogin1
{
    class Validacion
    {
        public string usuario;
        public string clave;
        public int nivel;

        public static Validacion Login(string user, string pass)
        {
            MySqlConnection conex = conexion.Conectar();

            string comando = "select * from Usuarios where user_name=@user and  contraseña=@pass limit 1;";

            MySqlCommand cmd = new MySqlCommand(comando, conex);

            cmd.Parameters.AddWithValue("@user", string.Format(user));
            cmd.Parameters.AddWithValue("@pass", string.Format(pass));

            MySqlDataReader lector = cmd.ExecuteReader();

            if (lector.Read() == true)
            {
                if (lector.Read() == true)
                {
                    Validacion us = new Validacion();
                    us.usuario = lector[1].ToString();
                }

                if (lector.Read() == true)
                {
                    Validacion us = new Validacion();
                    us.usuario = lector[1].ToString();
                    us.clave = lector[2].ToString();
                    us.nivel = int.Parse(lector[3].ToString());
                    conex.Close();
                    return us;
                }
                
            }
            else
            {
                conex.Close();
                return null;
            }
        }
    }
}
