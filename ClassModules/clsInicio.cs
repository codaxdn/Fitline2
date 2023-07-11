using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitLine.ClassModules
{
    internal class clsInicio
    {
        public void ingresos(Label label4)
        {
            try
            {

                DateTime hoy = DateTime.Today;
                DateTime ultimoDiaMes = hoy.AddMonths(1).AddDays(-1);
                string hoyy = hoy.ToString("yyyy-MM-dd");
                string ultimoDiaMess = ultimoDiaMes.ToString("yyyy-MM-dd");

                string existeSql = "SELECT COUNT(*) FROM fecha_mes WHERE FECHA_INICIO <= @hoy AND FECHA_FIN >= @hoy";
                string selectSql = "SELECT VALOR FROM fecha_mes WHERE FECHA_INICIO <= @hoy AND FECHA_FIN >= @hoy";
                string insertSql = "INSERT INTO fecha_mes (FECHA_INICIO, FECHA_FIN ,VALOR) VALUES (@hoy, @ultimoDiaMes, '0')";

                int existe = 0;

                using (CConexion con = new CConexion())
                {
                    try
                    {
                        MySqlCommand existeCmd = new MySqlCommand(existeSql, con.establecerConexion());
                        existeCmd.Parameters.AddWithValue("@hoy", hoyy);
                        existe = Convert.ToInt32(existeCmd.ExecuteScalar());

                        if (existe > 0)
                        {
                            MySqlCommand selectCmd = new MySqlCommand(selectSql, con.establecerConexion());
                            selectCmd.Parameters.AddWithValue("@hoy", hoyy);
                            using (MySqlDataReader lector = selectCmd.ExecuteReader())
                            {
                                while (lector.Read())
                                {
                                    label4.Text = Convert.ToString(lector["VALOR"]);
                                }
                            }
                        }
                        else
                        {
                            MySqlCommand insertCmd = new MySqlCommand(insertSql, con.establecerConexion());
                            insertCmd.Parameters.AddWithValue("@hoy", hoyy);
                            insertCmd.Parameters.AddWithValue("@ultimoDiaMes", ultimoDiaMess);
                            insertCmd.ExecuteNonQuery();
                            label4.Text = "0";
                        }
                    }
                    catch (MySqlException ex)
                    {
                        // Handle the exception
                    }
                }
            }
            catch(Exception ex)
            {

            }




        }
        public void ingresos2(Label label5)
        {
            try
            {
                DateTime hoy = DateTime.Today;
                DateTime otroDia = hoy.AddDays(6);

                string hoyStr = hoy.ToString("yyyy-MM-dd");
                string otroDiaStr = otroDia.ToString("yyyy-MM-dd");

                string sql = "SELECT COALESCE(VALOR, 0) AS VALOR FROM fecha_semana WHERE FECHA_INICIO <= @hoy AND FECHA_FIN >= @hoy";
                using (CConexion con = new CConexion())
                {
                    using (MySqlCommand comando = new MySqlCommand(sql, con.establecerConexion()))
                    {
                        comando.Parameters.AddWithValue("@hoy", hoyStr);
                        object result = comando.ExecuteScalar();

                        if (result != null)
                        {
                            label5.Text = result.ToString();
                        }
                        else
                        {
                            sql = "INSERT INTO fecha_semana (FECHA_INICIO, FECHA_FIN, VALOR) VALUES (@hoy, @otroDia, '0')";
                            using (MySqlCommand coman = new MySqlCommand(sql, con.establecerConexion()))
                            {
                                coman.Parameters.AddWithValue("@hoy", hoyStr);
                                coman.Parameters.AddWithValue("@otroDia", otroDiaStr);
                                coman.ExecuteNonQuery();
                            }
                            label5.Text = "0";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
            }


        }
        public void dia(Label label6)
        {

            try
            {
                DateTime hoy = DateTime.Today;
                string hoyy = hoy.ToString("yyyy-MM-dd");

                string sql = "SELECT COALESCE(VALOR, 0) AS VALOR FROM fecha_dia WHERE FECHA = @hoyy";
                CConexion con = new CConexion();
                MySqlCommand comando = new MySqlCommand(sql, con.establecerConexion());
                comando.Parameters.AddWithValue("@hoyy", hoyy);
                object result = comando.ExecuteScalar();

                if (result != null)
                {
                    label6.Text = result.ToString();
                }
                else
                {
                    sql = "INSERT INTO fecha_dia (FECHA, VALOR) VALUES (@hoyy, '0')";
                    comando = new MySqlCommand(sql, con.establecerConexion());
                    comando.Parameters.AddWithValue("@hoyy", hoyy);
                    comando.ExecuteNonQuery();
                    label6.Text = "0";
                }

                con.CerrarConexion();
            }
            catch (Exception ex)
            {
                // Handle the exception
            }

        }

        public void ingresar(String CEDULA)
        {
            try
            {
                if (CEDULA.Equals(""))
                {
                    MessageBox.Show("DEBES LLENAR EL CAMPO DE CEDULA");
                }
                else
                {
                    DateTime hoy = DateTime.Now;
                    String hoyy = (hoy.Year.ToString() + "-" + hoy.Month.ToString() + "-" + hoy.Day.ToString());
                    byte[] b = new byte[2048];
                    String sql = "select * from clientes WHERE CEDULA = '" + CEDULA +"'";
                    CConexion con = new CConexion();
                    MySqlCommand comando = new MySqlCommand(sql, con.establecerConexion());
                    MySqlDataReader reader1 = comando.ExecuteReader();
                    int ret;
                    String nombre = "";
                    String Cedula = "";
                    if (reader1.Read())
                    {
                        nombre = Convert.ToString(reader1["NOMBRE"]);
                        Cedula = Convert.ToString(reader1["CEDULA"]);
                    }
                    String CantClases = "";
                    String idPersona = "";
                    sql = "SELECT * FROM compra_paquetes WHere CED_CLIENTE = '" + Cedula + "' AND FECHA_FIN >= '" + hoyy + "' AND CLASES > '0'";
                    comando = new MySqlCommand(sql, con.establecerConexion());
                    reader1 = comando.ExecuteReader();
                    int count = 0;
                    if (reader1.Read())
                    {
                        count = 1;
                        idPersona = Convert.ToString(reader1["ID"]);
                        CantClases = Convert.ToString(reader1["CLASES"]);
                    }

                    sql = "SELECT COUNT(CEDULA_CLIENTE) FROM asistencia WHERE Date(ASISTENCIA) = '" + hoyy + "' AND CEDULA_CLIENTE = '" + Cedula + "'";
                    comando = new MySqlCommand(sql, con.establecerConexion());
                    reader1 = comando.ExecuteReader();
                    String num = "";
                    while (reader1.Read())
                    {
                        num = Convert.ToString(reader1["COUNT(CEDULA_CLIENTE)"]);
                    }

                    sql = "SELECT COUNT(CEDULA_CLIENTE) FROM salida WHERE Date(SALIDA) = '" + hoyy + "' AND CEDULA_CLIENTE = '" + Cedula + "'";
                    comando = new MySqlCommand(sql, con.establecerConexion());
                    reader1 = comando.ExecuteReader();
                    String NUM2 = "";
                    while (reader1.Read())
                    {
                        NUM2 = Convert.ToString(reader1["COUNT(CEDULA_CLIENTE)"]);
                    }
                    int evalaluar = int.Parse(num) - int.Parse(NUM2);

                    if (evalaluar == 0)
                    {
                        if (count == 0)
                        {
                            MessageBox.Show("EL USUARIO NO ESTA REGISTRADO O NO CUENTA CON CLASES DISPONIBLES");
                            con.CerrarConexion();
                        }
                        else
                        {
                            DateTime z = DateTime.Now;
                            String zz = (z.Year.ToString() + "-" + z.Month.ToString() + "-" + z.Day.ToString() + " " + z.Hour.ToString() + "-" + z.Minute.ToString() + "-" + z.Second.ToString());
                            int ClasesFinales = int.Parse(CantClases) - 1;
                            sql = "UPDATE compra_paquetes SET CLASES = '" + ClasesFinales + "' WHERE ID = '" + idPersona + "'";
                            comando = new MySqlCommand(sql, con.establecerConexion());
                            reader1 = comando.ExecuteReader();
                            while (reader1.Read()) { }
                            sql = "INSERT INTO asistencia(CEDULA_CLIENTE, ASISTENCIA)"
                                 + "VALUES('" + Cedula + "','" + zz + "')";
                            comando = new MySqlCommand(sql, con.establecerConexion());
                            reader1 = comando.ExecuteReader();
                            while (reader1.Read()) { }

                            System.IO.Ports.SerialPort Arduino;
                            Arduino = new System.IO.Ports.SerialPort();
                            Arduino.PortName = "COM5";
                            Arduino.BaudRate = 9600;
                            Arduino.Open();
                            Arduino.Write("E");
                            MessageBox.Show("PUEDES INGRESAR " + nombre + " Te quedan " + ClasesFinales + " Clases");
                            var stopwatch = Stopwatch.StartNew();
                            Thread.Sleep(4000); //tiempo de pausa
                            stopwatch.Stop();
                            Arduino.Write("F");
                            Arduino.Close();
                            con.CerrarConexion();

                        }
                    }
                    else
                    {
                        DateTime z = DateTime.Now;
                        String zz = (z.Year.ToString() + "-" + z.Month.ToString() + "-" + z.Day.ToString() + " " + z.Hour.ToString() + "-" + z.Minute.ToString() + "-" + z.Second.ToString());
                        int ClasesFinales = int.Parse(CantClases) - 1;
                        sql = "UPDATE compra_paquetes SET CLASES = '" + ClasesFinales + "' WHERE ID = '" + idPersona + "'";
                        comando = new MySqlCommand(sql, con.establecerConexion());
                        reader1 = comando.ExecuteReader();
                        while (reader1.Read()) { }
                        sql = "INSERT INTO salida(CEDULA_CLIENTE, SALIDA)"
                                 + "VALUES('" + Cedula + "','" + zz + "')";
                        comando = new MySqlCommand(sql, con.establecerConexion());
                        reader1 = comando.ExecuteReader();
                        while (reader1.Read()) { }

                        System.IO.Ports.SerialPort Arduino;
                        Arduino = new System.IO.Ports.SerialPort();
                        Arduino.PortName = "COM5";
                        Arduino.BaudRate = 9600;
                        Arduino.Open();
                        Arduino.Write("E");
                        MessageBox.Show("HASTA LUEGO " + nombre);

                        var stopwatch = Stopwatch.StartNew();
                        Thread.Sleep(4000); //tiempo de pausa
                        stopwatch.Stop();

                        Arduino.Write("F");
                        Arduino.Close();
                        con.CerrarConexion();
                    }



                }
            }
            catch(Exception ex) { }
        }

        public int entrada(String Cedula, String hoyy)
        {


            String sql = "";
            CConexion con = new CConexion();
            MySqlCommand comando = new MySqlCommand(sql, con.establecerConexion());
            MySqlDataReader reader1 = comando.ExecuteReader();

            sql = "SELECT COUNT(*) FROM asistencia WHERE Date(ASISTENCIA) = '" + hoyy + "' AND CEDULA_CLIENTE = '" + Cedula + "'";
            comando = new MySqlCommand(sql, con.establecerConexion());
            reader1 = comando.ExecuteReader();
            String num = "";
            while (reader1.Read())
            {
                num = Convert.ToString(reader1["COUNT(*)"]);
            }

            sql = "SELECT COUNT(*) FROM salida WHERE Date(SALIDA) = '" + hoyy + "' AND CEDULA_CLIENTE = '" + Cedula + "'";
            comando = new MySqlCommand(sql, con.establecerConexion());
            reader1 = comando.ExecuteReader();
            String NUM2 = "";
            while (reader1.Read())
            {
                NUM2 = Convert.ToString(reader1["COUNT(*)"]);
            }
            int evalaluar = int.Parse(num) - int.Parse(NUM2);

            con.CerrarConexion();

            return evalaluar;
        }

        public void arduino()
        {
            System.IO.Ports.SerialPort Arduino;
            Arduino = new System.IO.Ports.SerialPort();
            Arduino.PortName = "COM5";
            Arduino.BaudRate = 9600;
            Arduino.Open();
            Arduino.Write("E");
            var stopwatch = Stopwatch.StartNew();
            Thread.Sleep(2000); //tiempo de pausa
            stopwatch.Stop();

            Arduino.Write("F");
            Arduino.Close();
        }
    }
}
