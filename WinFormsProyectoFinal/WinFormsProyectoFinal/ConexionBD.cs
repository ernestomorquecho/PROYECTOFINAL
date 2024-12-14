using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Security.Cryptography.X509Certificates;
using ZstdSharp.Unsafe;

namespace WinFormsProyectoFinal
{
    public class ConexionBD
    {
        private MySqlConnection conexion;

        public ConexionBD()
        {
            this.Connect();
        }
        public MySqlConnection ObtenerConexion()
        {
            if (conexion == null || conexion.State != System.Data.ConnectionState.Open)
            {
                Connect(); // Assegurandonos de que la conexión esté abierta
            }
            return conexion;
        }

        public void Disconnect()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                //Si la conexion con la base de datos esta abierta esta funcion la cierra
                conexion.Close();
                MessageBox.Show("Conexion cerrada correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Connect()
        {
            //Esta funcion ingresa a la base de datos que tengamos y realiza la conexion con Open();
            string cadenaConexion = "Server=localhost; Database=tienda; User=root; Password=; SslMode=none;";
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                MessageBox.Show("Conexion establecida", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string validarUsuario(string usuario, string contrasena)
        {
            try
            {
                // Consulta para seleccionar rol y nombre del usuario
                string consulta = "SELECT rol, nombre FROM cuentas WHERE usuario = @usuario AND contrasena = @contrasena";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@usuario", usuario); // Asigna el valor de 'usuario' al parámetro @usuario
                comando.Parameters.AddWithValue("@contrasena", contrasena); // Asigna el valor de 'contrasena' al parámetro @contrasena

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read()) // Si hay un registro que coincide
                    {
                        string rol = reader["rol"].ToString(); // Obtiene el valor del campo 'rol'
                        string nombre = reader["nombre"].ToString(); // Obtiene el valor del campo 'nombre'
                        return $"{rol};{nombre}"; // Retorna rol y nombre concatenados separados por ';'
                    }
                }
                return string.Empty; // Si no se encuentran coincidencias
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al validar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty; // En caso de error, retorna un string vacío
            }
        }


    }
}
