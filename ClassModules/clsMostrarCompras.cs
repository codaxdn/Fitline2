using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FitLine.ClassModules
{
    internal class clsMostrarCompras
    {

        public void Tabla(DataGridView TABLA)
        {
            using (var con = new CConexion())
            {
                var sql = "SELECT * FROM detalles_compras";
                var adapter = new MySqlDataAdapter(sql, con.establecerConexion());
                var dt = new DataTable();
                adapter.Fill(dt);
                TABLA.DataSource = dt;
            }

        }

        public void Cargar(String valor, DataGridView TABLA)
        {
            using (CConexion con = new CConexion())
            {
                if (valor.Equals(""))
                {
                    MessageBox.Show("DEBES SELECCIONAR UN VALOR");
                }
                else if (valor == "Dia")
                {
                    DateTime hoy = DateTime.Now;
                    String hoyy = (hoy.Year.ToString() + "-" + hoy.Month.ToString() + "-" + hoy.Day.ToString());
                    TABLA.DataSource = null;
                    String sql = "SELECT * FROM detalles_compras WHERE DATE(FECHA_COMPRA) = @hoyy";
                    MySqlCommand comando = new MySqlCommand(sql, con.establecerConexion());
                    comando.Parameters.AddWithValue("@hoyy", hoyy);
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    adapter.Fill(dt);
                    TABLA.DataSource = dt;
                }
                else if (valor == "Semana")
                {
                    DateTime hoy = DateTime.Now;
                    String hoyy = (hoy.Year.ToString() + "-" + hoy.Month.ToString() + "-" + hoy.Day.ToString());
                    String sql = "select FECHA_INICIO, FECHA_FIN from fecha_semana WHERE FECHA_INICIO <= @hoyy AND FECHA_FIN >= @hoyy";
                    MySqlCommand coman = new MySqlCommand(sql, con.establecerConexion());
                    coman.Parameters.AddWithValue("@hoyy", hoyy);
                    MySqlDataReader lect = coman.ExecuteReader();
                    String inicio = "";
                    String fin = "";
                    while (lect.Read())
                    {
                        DateTime x = Convert.ToDateTime(lect["FECHA_INICIO"]);
                        DateTime Y = Convert.ToDateTime(lect["FECHA_FIN"]);
                        inicio = (x.Year.ToString() + "-" + x.Month.ToString() + "-" + x.Day.ToString());
                        fin = (Y.Year.ToString() + "-" + Y.Month.ToString() + "-" + Y.Day.ToString());
                    }

                    sql = "SELECT * FROM detalles_Compras WHERE DATE(FECHA_COMPRA) <= @fin AND DATE(FECHA_COMPRA) >= @inicio";
                    MySqlCommand comando = new MySqlCommand(sql, con.establecerConexion());
                    comando.Parameters.AddWithValue("@fin", fin);
                    comando.Parameters.AddWithValue("@inicio", inicio);
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    adapter.Fill(dt);
                    TABLA.DataSource = dt;

                }
                else
                {
                    DateTime hoy = DateTime.Now;
                    String hoyy = (hoy.Year.ToString() + "-" + hoy.Month.ToString() + "-" + hoy.Day.ToString());
                    String sql = "select FECHA_INICIO, FECHA_FIN from fecha_mes WHERE FECHA_INICIO <='" + hoyy + "' AND  FECHA_FIN >= '" + hoyy + "'";
                    using (MySqlCommand coman = new MySqlCommand(sql, con.establecerConexion()))
                    {
                        using (MySqlDataReader lect = coman.ExecuteReader())
                        {
                            String inicio = "";
                            String fin = "";
                            while (lect.Read())
                            {
                                DateTime x = Convert.ToDateTime(lect["FECHA_INICIO"]);
                                DateTime Y = Convert.ToDateTime(lect["FECHA_FIN"]);
                                inicio = (x.Year.ToString() + "-" + x.Month.ToString() + "-" + x.Day.ToString());
                                fin = (Y.Year.ToString() + "-" + Y.Month.ToString() + "-" + Y.Day.ToString());
                            }
                            sql = "SELECT * FROM detalles_Compras WHERE DATE(FECHA_COMPRA) <= '" + fin + "' AND DATE(FECHA_COMPRA) >= '" + inicio + "'";
                            using (MySqlDataAdapter comando = new MySqlDataAdapter(sql, con.establecerConexion()))
                            {
                                DataTable dt = new DataTable();
                                comando.Fill(dt);
                                TABLA.DataSource = dt;
                            }
                        }
                    }
                    con.CerrarConexion();
                }
            }
        }

        public void NuevoFiltro(string fecha, DataGridView tabla)
        {
            using (var con = new CConexion())
            {
                string sql = "SELECT * FROM detalles_compras WHERE DATE(FECHA_COMPRA) = @fecha";
                using (var comando = new MySqlDataAdapter(sql, con.establecerConexion()))
                {
                    comando.SelectCommand.Parameters.AddWithValue("@fecha", fecha);
                    var dt = new DataTable();
                    comando.Fill(dt);
                    tabla.DataSource = dt;
                }
            }
        }


    }
}
