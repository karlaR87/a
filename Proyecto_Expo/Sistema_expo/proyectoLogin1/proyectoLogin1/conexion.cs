using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace proyectoLogin1
{
    class conexion
    {
        public static MySqlConnection Conectar()
        {
            try
            {
                string server = "127.0.0.1";
                string user = "root";
                string databsse = "Mueble_SV";
                string cadena = "server=" + server + ";uid=" + user + ";database=" + databsse;

                MySqlConnection conex = new MySqlConnection(cadena);
                conex.Open();
                return conex;
            }
            catch
            {
                return null;
            }
        }

    }
}
