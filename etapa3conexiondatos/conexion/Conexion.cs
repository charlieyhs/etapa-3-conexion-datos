using etapa3conexiondatos.DTO;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etapa3conexiondatos.conexion
{
    internal class Conexion
    {
        MySqlConnection conn = new MySqlConnection();

        private static string server = "localhost";
        private static string port = "3306";
        private static string bd = "etapa3conexiondatos";
        private static string user = "root";
        private static string pass = "Elmundodeplaton2*";

        private string conexion = "server=" + server + ";port=" + port + ";user id=" + user 
                          + ";password=" + pass + ";database=" + bd + ";";


        private MySqlConnection establecerConexion()
        {
            try
            {
                conn.ConnectionString = conexion;
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.ToString());
                return null;
            }
            return conn;
        }
        public List<EmpleadoDTO> getEmpleados()
        {
            return getEmpleados(false, null);
        }
        
        public List<EmpleadoDTO> getEmpleados(Boolean where, String nroId)
        {
            List<EmpleadoDTO> datos = new List<EmpleadoDTO>();
            using (MySqlConnection conexion = establecerConexion())
            {
                if (conexion == null)
                {
                    return datos;
                }
                string query = "select * from empleado emp ";
                try
                {
                    MySqlCommand comando = new MySqlCommand(query, conexion);
                    if (where)
                    {
                        query += " where nrodocidentidad = @nrodocidentidad";
                        comando = new MySqlCommand(query, conexion);
                        comando.Parameters.AddWithValue("@nrodocidentidad", nroId);
                    }
                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        EmpleadoDTO empleado = new EmpleadoDTO();
                        empleado.nrodocidentidad = reader.GetString(0);
                        empleado.nombres = reader["nombres"] != DBNull.Value ? (string)reader["nombres"] : null;
                        empleado.apellidos = reader["apellidos"] != DBNull.Value ? (string)reader["apellidos"] : null;
                        empleado.cargo = reader["cargo"] != DBNull.Value ? (string)reader["cargo"] : null;
                        empleado.foto = reader["foto"] != DBNull.Value ? (string)reader["foto"] : null;
                        empleado.oficina = reader["oficina"] != DBNull.Value ? (string)reader["oficina"] : null;
                        empleado.numerotel = reader["numerotel"] != DBNull.Value ? (string)reader["numerotel"] : null;
                        empleado.datosfoto = reader["datosfoto"] != DBNull.Value ? (byte[])reader["datosfoto"] : null;
                        datos.Add(empleado);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión: " + ex.ToString());
                }
                conexion.Close();
            }
            return datos;
        }
        public void insertar(EmpleadoDTO empleado)
        {
            string query = "INSERT INTO empleado " +
                            "(nrodocidentidad, nombres, apellidos, numerotel, cargo, oficina, foto, datosfoto) " +
                            "VALUES (@nrodocidentidad, @nombres, @apellidos, @numerotel, @cargo, @oficina, @foto, @datosfoto)";

            try
            {
                ejecutarQuerys(query, empleado);
                MessageBox.Show("Registro insertado correctamente.", "Información Adicional");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Insertando: " + ex.ToString());
            }
        }
        public void actualizar(EmpleadoDTO empleado)
        {
            string query = "update empleado set " +
                            "nombres = @nombres, apellidos = @apellidos, " +
                            "cargo = @cargo, foto = @foto, datosfoto = @datosfoto, " +
                            "numerotel = @numerotel, oficina = @oficina " +
                            "where nrodocidentidad = @nrodocidentidad";

            try
            {
                ejecutarQuerys(query, empleado);
                MessageBox.Show("Registro actualizado correctamente.", "Información Adicional");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error actualizando: " + ex.ToString());
            }

        }
        public void eliminar(EmpleadoDTO empleado)
        {
            string query = "delete from empleado " +
                            "where nrodocidentidad = @nrodocidentidad";

            try
            {
                ejecutarQuerys(query, empleado);
                MessageBox.Show("Registro eliminado correctamente.", "Información Adicional");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error eliminando: " + ex.ToString());
            }

        }
        private void ejecutarQuerys(string query,
                                    EmpleadoDTO empleado)
        {
            using (MySqlConnection conexion = establecerConexion())
            {
                if (conexion == null)
                {
                    return;
                }


                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nrodocidentidad", empleado.nrodocidentidad);
                agregarParametro("@nombres", empleado.nombres, comando);
                agregarParametro("@apellidos", empleado.apellidos, comando);
                agregarParametro("@cargo", empleado.cargo, comando);
                agregarParametro("@foto", empleado.foto, comando);
                agregarParametro("@numerotel", empleado.numerotel, comando);
                agregarParametro("@oficina", empleado.oficina, comando);
                comando.Parameters.AddWithValue("@datosfoto", empleado.datosfoto);
                comando.ExecuteNonQuery();
                conexion.Close();
            }
        }
        private void agregarParametro(String parametro, String valor, MySqlCommand comando)
        {
            if(valor == null || valor.Trim() == "")
            {
                return;
            }
            comando.Parameters.AddWithValue(parametro, valor);
        }

    }
    
}
