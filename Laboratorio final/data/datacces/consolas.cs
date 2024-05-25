using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_final.data.datacces
{
    internal class consolas
    {
        internal class ConexionMySql
        {
            string connectionString = "server=localhost;database=db_universidad;user=root;password=BryanJRH0801";
            MySqlConnection connection;
            public ConexionMySql()
            {
                connection = new MySqlConnection(connectionString);
            }
            public void Insertar(string nombre_consola, string compania, DateTime Lanzamiento, int generacion)
            {
                try
                {
                    string query = "INSERT INTO catalogo_consolas (nombre_consola, compania, anio_lanzamiento, generacion) VALUES (@nombre_consola, @compania, @Lanzamiento, @generacion)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nombre_consola", nombre_consola);
                    cmd.Parameters.AddWithValue("@compania", compania);
                    cmd.Parameters.AddWithValue("@Lanzamiento", Lanzamiento);
                    cmd.Parameters.AddWithValue("@generacion", generacion);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el registro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            public DataTable LeerTodos()
            {
                DataTable dt = new DataTable();
                try
                {
                    string query = "SELECT * FROM catalogo_consolas";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    connection.Open();
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer los registros: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return dt;
            }
            public void Insertar(model mdl)
            {
                try
                {
                    string query = "INSERT INTO Usuarios (nombre_consola, compania, anio_lanzamiento, generacion,) VALUES (@nombre_consola, @compania, @Lanzamiento, @generacion)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nombre_consola", mdl.nombre_consola);
                    cmd.Parameters.AddWithValue("@compania", mdl.compania);
                    cmd.Parameters.AddWithValue("@Lanzamiento", mdl.fecha_lanzamiento);
                    cmd.Parameters.AddWithValue("@generacion", mdl.generacion);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el registro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }





















            public List<model> ObtenerTodosLosUsuarios()
            {
                List<model> catalogo_consolas = new List<model>();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Usuarios";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    try
                    {
                        connection.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            model modelo = new model
                            (
                            id_consola: reader.GetInt32("id_consola"),
                            nombre_Consola: reader.GetString("nombre_consola"),
                            Compania: reader.GetString("compania"),
                            Fecha_lanzamiento: reader.GetDateTime("Lanzamiento"),
                            Generacion: reader.GetInt32("generacion")
                            );
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }

                return catalogo_consolas;
            }
        }
    }
}
