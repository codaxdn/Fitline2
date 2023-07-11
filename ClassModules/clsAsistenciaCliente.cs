using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitLine.ClassModules
{
    internal class clsAsistenciaCliente
    {
        public void Tabla(DataGridView TABLA)
        {
            
                try
                {

                
                    using (var con = new CConexion().establecerConexion())
                    {
                        var sql = "SELECT * FROM asistencia";
                        using (var comando = new MySqlDataAdapter(sql, con))
                        {
                            var dt = new DataTable();
                            comando.Fill(dt);
                            TABLA.DataSource = dt;
                        }
                    }
                }
                catch(Exception ex)
{
                    // Manejo de excepciones
                }
        }
        public void filtrar(DataGridView tabla, string cedula)
        {
            if (string.IsNullOrEmpty(cedula))
            {
                MessageBox.Show("DEBES ESCRIBIR LA CEDULA DEL CLIENTE");
                return;
            }

            try
            {
                using (var con = new CConexion())
                {
                    var sql = "SELECT * FROM asistencia WHERE CEDULA_CLIENTE = @cedula";
                    var comando = new MySqlDataAdapter(sql, con.establecerConexion());
                    comando.SelectCommand.Parameters.AddWithValue("@cedula", cedula);
                    var dt = new DataTable();
                    comando.Fill(dt);
                    tabla.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or rethrow it.
            }
        }



        public void TablaSalida(DataGridView TABLA)
        {
            try
            {
                using (CConexion con = new CConexion())
                {
                    String sql = "SELECT * FROM salida";
                    using (MySqlDataAdapter comando = new MySqlDataAdapter(sql, con.establecerConexion()))
                    {
                        DataTable dt = new DataTable();
                        comando.Fill(dt);
                        TABLA.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                // handle exception here
            }
        }

        public void filtrarSalida(DataGridView TABLA, String cedula)
        {
            if (string.IsNullOrEmpty(cedula))
            {
                MessageBox.Show("DEBES ESCRIBIR LA CEDULA DEL CLIENTE");
                return;
            }

            try
            {
                CConexion con = new CConexion();
                String sql = "SELECT * FROM salida WHERE CEDULA_CLIENTE = @cedula";
                MySqlCommand comando = new MySqlCommand(sql, con.establecerConexion());
                comando.Parameters.AddWithValue("@cedula", cedula);
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                adapter.Fill(dt);
                TABLA.DataSource = dt;
                con.CerrarConexion();
            }
            catch (Exception ex)
            {
                // Handle the exception here, e.g. log it or display an error message
            }
        }
    
    }
}
