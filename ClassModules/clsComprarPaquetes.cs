using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FitLine.ClassModules
{
    internal class clsComprarPaquetes
    {
        public void CargarPaquetes(ComboBox CmbPaquetes)
        {
            try
            {
                CmbPaquetes.Items.Clear();
                using (CConexion con = new CConexion())
                {
                    string sql = "SELECT NOMBRE FROM paquetes WHERE ESTADO = 'Activado'";
                    using (MySqlCommand comando = new MySqlCommand(sql, con.establecerConexion()))
                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            CmbPaquetes.Items.Add(lector.GetString("NOMBRE"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception
            }
        }

        public void CargarTiquetes(ComboBox CmbTiquetes)
        {
            try
            {
                CmbTiquetes.Items.Clear();
                string sql = "SELECT CODIGO, NOMBRE FROM tiquetes WHERE ESTADO = 'Activado'";
                using (var con = new CConexion())
                {
                    var cmd = new MySqlCommand(sql, con.establecerConexion());
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CmbTiquetes.Items.Add(reader.GetString("NOMBRE"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception
            }
        }

        public void CargarTabla(DataGridView TABLA)
        {
            try
            {
                DateTime hoy = DateTime.Today;
                string hoyy = hoy.ToString("yyyy-MM-dd");

                string sql = @"SELECT C.ID AS ID, CLI.CEDULA AS CEDULA, CLI.NOMBRE AS NOMBRE, CLI.APELLIDO AS APELLIDO, 
                            P.NOMBRE AS NOMBRE_PAQUETE, T.NOMBRE AS NOMBRE_TIQUETE, C.CLASES AS CLASES, 
                            C.FECHA_COMPRA AS FECHA_COMPRA, C.FECHA_FIN AS FECHA_FIN 
                      FROM compra_paquetes C 
                      JOIN clientes CLI ON CLI.CEDULA = C.CED_CLIENTE 
                      JOIN paquetes P ON P.CODIGO = C.CODIGO_PAQUETE 
                      JOIN tiquetes T ON T.CODIGO = C.CODIGO_TIQUETE 
                      WHERE C.FECHA_FIN >= @hoyy AND C.CLASES > 0";

                using (CConexion con = new CConexion())
                using (MySqlCommand comando = new MySqlCommand(sql, con.establecerConexion()))
                {
                    comando.Parameters.AddWithValue("@hoyy", hoyy);

                    TABLA.DataSource = null;

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        TABLA.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CARGAR LOS CAMPOS EN LA TABLA ", ex.Message);
            }
        }

        public void ComprarPaquetesTiquetes(String Cedula, String Paquete, String Tiquete)
        {

            if (Cedula.Equals(""))
            {
                MessageBox.Show("DEBES ESCRIBIR LA CEDULA DE UN CLIENTE REGISTRADO");
            }
            else
            {
                DateTime D = DateTime.Today;
                String DD = (D.Year.ToString() + "-" + D.Month.ToString() + "-" + D.Day.ToString());
                int variable = 0;
                String sql = "select CEDULA from clientes WHERE CEDULA = '" + Cedula + "'";
                CConexion con = new CConexion();
                MySqlCommand comando = new MySqlCommand(sql, con.establecerConexion());
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    variable = 1;
                }

                if (variable == 0)
                {
                    MessageBox.Show("DEBES ESCRIBIR LA CEDULA DE UN CLIENTE REGISTRADO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    variable = 0;
                    sql = "select CED_CLIENTE from compra_paquetes WHERE CED_CLIENTE = '" + Cedula + "' AND FECHA_FIN >= '" + DD + "' AND CLASES > 0";
                    comando = new MySqlCommand(sql, con.establecerConexion());
                    reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        variable = 1;
                    }
                    if (variable == 0)
                    {
                        if (Paquete.Equals("") && Tiquete.Equals(""))
                        {
                            MessageBox.Show("DEBES SELECCIONAR UN PAQUETE O TIQUETE");
                        }
                        else if (Tiquete.Equals(""))//----inicio condicional realizar compra de paquetes----
                        {

                            sql = "Select CODIGO, TIEMPO, PRECIO FROM paquetes where NOMBRE = '" + Paquete + "'";

                            MySqlCommand comandoo = new MySqlCommand(sql, con.establecerConexion());
                            MySqlDataReader lector = comandoo.ExecuteReader();
                            String tiempo = "";
                            String id = "";
                            String Precio = "";
                            while (lector.Read())
                            {
                                id = Convert.ToString(lector["CODIGO"]);
                                tiempo = Convert.ToString(lector["TIEMPO"]);
                                Precio = Convert.ToString(lector["PRECIO"]);
                            }
                            int asistencia = (int)Math.Ceiling(float.Parse(tiempo) * 2 * 31);
                            DateTime hoy = DateTime.Today;
                            if (float.Parse(tiempo) % 1 != 0)
                            {
                                int valor = 0;
                                if (tiempo == "0,5")
                                {
                                    valor = 15;
                                }
                                else if (tiempo == "0,4")
                                {
                                    valor = 7;
                                }
                                else
                                {
                                    int duracionEnDias = 0;
                                    DateTime fechaActual = DateTime.Now;
                                    DateTime fechaSiguienteMes = fechaActual.AddMonths(1);
                                    TimeSpan duracion = fechaSiguienteMes - fechaActual;
                                    duracionEnDias = Convert.ToInt32(duracion.TotalDays);
                                    valor = (int)Math.Ceiling(float.Parse(tiempo) * duracionEnDias);
                                    valor = valor - 1;

                                }

                                DateTime fin = hoy.AddDays(valor);
                                fin = fin.AddDays(- 1);
                                String hoyy = (hoy.Year.ToString() + "-" + hoy.Month.ToString() + "-" + hoy.Day.ToString());
                                String finn = (fin.Year.ToString() + "-" + fin.Month.ToString() + "-" + fin.Day.ToString());
                                String sql2 = "INSERT INTO compra_paquetes (CODIGO_PAQUETE, CODIGO_TIQUETE ,CED_CLIENTE, FECHA_COMPRA, CLASES, PRECIO, FECHA_FIN )"
                                    + "values ('" + id + "',' 4 ','" + Cedula + "','" + hoyy + "','" + asistencia + "','" + Precio + "','" + finn + "')";

                                MySqlCommand coman = new MySqlCommand(sql2, con.establecerConexion());
                                MySqlDataReader reader1 = coman.ExecuteReader();
                                while (reader1.Read())
                                {

                                }
                                MessageBox.Show("COMPRA EXITOSA");

                                //actualizacion del contador de ganancias dia - semana - mes

                                String Sql2 = "SELECT VALOR FROM fecha_dia WHERE FECHA ='" + hoyy + "'";
                                MySqlCommand comand = new MySqlCommand(Sql2, con.establecerConexion());
                                MySqlDataReader lecto = comand.ExecuteReader();
                                String valu = "0";
                                while (lecto.Read())
                                {

                                    valu = Convert.ToString(lecto["VALOR"]); ;

                                }
                                int valorCompra1 = int.Parse(Precio) + int.Parse(valu);
                                sql = "UPDATE fecha_dia SET VALOR ='" + valorCompra1 + "' WHERE FECHA = '" + hoyy + "'";
                                MySqlCommand com = new MySqlCommand(sql, con.establecerConexion());
                                MySqlDataReader read = com.ExecuteReader();
                                while (read.Read())
                                {

                                }
                                sql = "select ID,VALOR from fecha_semana WHERE FECHA_INICIO <='" + hoyy + "' AND  FECHA_FIN >= '" + hoyy + "'";
                                MySqlCommand coma = new MySqlCommand(sql, con.establecerConexion());
                                MySqlDataReader lect = coma.ExecuteReader();
                                id = "";
                                String Valor = "0";

                                while (lect.Read())
                                {
                                    id = Convert.ToString(lect["ID"]);
                                    Valor = Convert.ToString(lect["VALOR"]);
                                }
                                lect.Close();

                                int valorCompra2 = int.Parse(Precio) + int.Parse(Valor);
                                String sql8 = "UPDATE fecha_semana SET VALOR ='" + valorCompra2 + "' WHERE ID = '" + id + "'";
                                MySqlCommand co = new MySqlCommand(sql8, con.establecerConexion());
                                MySqlDataReader rea = co.ExecuteReader();
                                while (rea.Read()) { }

                                String sql4 = "select ID, VALOR from fecha_mes WHERE FECHA_INICIO <='" + hoyy + "' AND  FECHA_FIN >= '" + hoyy + "'";
                                MySqlCommand comandooo = new MySqlCommand(sql4, con.establecerConexion());
                                MySqlDataReader let = comandooo.ExecuteReader();

                                String idd = "";
                                String valorr = "0";

                                while (let.Read())
                                {
                                    idd = Convert.ToString(let["ID"]);
                                    valorr = Convert.ToString(let["VALOR"]);
                                }
                                int valorCompra3 = int.Parse(Precio) + int.Parse(valorr);
                                sql = "UPDATE fecha_mes SET VALOR ='" + valorCompra3 + "' WHERE ID = '" + idd + "'";
                                MySqlCommand comandoooo = new MySqlCommand(sql, con.establecerConexion());
                                MySqlDataReader re = comandoooo.ExecuteReader();
                                while (re.Read()) { }


                                //AGREGAR LA COMPRA A LA TABLA detalles_compras
                                sql = "Select CODIGO, TIEMPO, PRECIO FROM paquetes where NOMBRE = '" + Paquete + "'";

                                comandoo = new MySqlCommand(sql, con.establecerConexion());
                                lector = comandoo.ExecuteReader();
                                id = "";
                                Precio = "";
                                while (lector.Read())
                                {
                                    id = Convert.ToString(lector["CODIGO"]);
                                    Precio = Convert.ToString(lector["PRECIO"]);
                                }
                                DateTime ya = DateTime.Now;
                                String yaa = (ya.Year.ToString() + "-" + ya.Month.ToString() + "-" + ya.Day + " " + ya.Hour.ToString() + "-" + ya.Minute.ToString() + "-" + ya.Second.ToString());

                                String x = "PAQUETE " + Paquete;

                                int precio = int.Parse(Precio);
                                String SQL = "INSERT INTO detalles_compras(NOMBRE, CANTIDAD, PRECIO, FECHA_COMPRA) "
                                                + "values('" + x + "','1','" + precio + "','" + yaa + "')";
                                coman = new MySqlCommand(SQL, con.establecerConexion());
                                reader1 = coman.ExecuteReader();
                                while (reader1.Read())
                                {

                                }
                            }
                            else
                            {

                                DateTime fin = hoy.AddMonths((int)Math.Ceiling(float.Parse(tiempo)));
                                fin = fin.AddDays(- 1);
                                String hoyy = (hoy.Year.ToString() + "-" + hoy.Month.ToString() + "-" + hoy.Day.ToString());
                                String finn = (fin.Year.ToString() + "-" + fin.Month.ToString() + "-" + fin.Day.ToString());
                                String sql2 = "INSERT INTO compra_paquetes (CODIGO_PAQUETE, CODIGO_TIQUETE ,CED_CLIENTE, FECHA_COMPRA, CLASES, PRECIO, FECHA_FIN )"
                                    + "values ('" + id + "',' 4 ','" + Cedula + "','" + hoyy + "','" + asistencia + "','" + Precio + "','" + finn + "')";

                                MySqlCommand coman = new MySqlCommand(sql2, con.establecerConexion());
                                MySqlDataReader reader1 = coman.ExecuteReader();
                                while (reader1.Read())
                                {

                                }
                                MessageBox.Show("COMPRA EXITOSA");

                                //actualizacion del contador de ganancias dia - semana - mes

                                String Sql2 = "SELECT VALOR FROM fecha_dia WHERE FECHA ='" + hoyy + "'";
                                MySqlCommand comand = new MySqlCommand(Sql2, con.establecerConexion());
                                MySqlDataReader lecto = comand.ExecuteReader();
                                String valu = "0";
                                while (lecto.Read())
                                {

                                    valu = Convert.ToString(lecto["VALOR"]); ;

                                }
                                int valorCompra1 = int.Parse(Precio) + int.Parse(valu);
                                sql = "UPDATE fecha_dia SET VALOR ='" + valorCompra1 + "' WHERE FECHA = '" + hoyy + "'";
                                MySqlCommand com = new MySqlCommand(sql, con.establecerConexion());
                                MySqlDataReader read = com.ExecuteReader();
                                while (read.Read())
                                {

                                }
                                sql = "select ID,VALOR from fecha_semana WHERE FECHA_INICIO <='" + hoyy + "' AND  FECHA_FIN >= '" + hoyy + "'";
                                MySqlCommand coma = new MySqlCommand(sql, con.establecerConexion());
                                MySqlDataReader lect = coma.ExecuteReader();
                                id = "";
                                String Valor = "0";

                                while (lect.Read())
                                {
                                    id = Convert.ToString(lect["ID"]);
                                    Valor = Convert.ToString(lect["VALOR"]);
                                }
                                lect.Close();

                                int valorCompra2 = int.Parse(Precio) + int.Parse(Valor);
                                String sql8 = "UPDATE fecha_semana SET VALOR ='" + valorCompra2 + "' WHERE ID = '" + id + "'";
                                MySqlCommand co = new MySqlCommand(sql8, con.establecerConexion());
                                MySqlDataReader rea = co.ExecuteReader();
                                while (rea.Read()) { }

                                String sql4 = "select ID, VALOR from fecha_mes WHERE FECHA_INICIO <='" + hoyy + "' AND  FECHA_FIN >= '" + hoyy + "'";
                                MySqlCommand comandooo = new MySqlCommand(sql4, con.establecerConexion());
                                MySqlDataReader let = comandooo.ExecuteReader();

                                String idd = "";
                                String valorr = "0";

                                while (let.Read())
                                {
                                    idd = Convert.ToString(let["ID"]);
                                    valorr = Convert.ToString(let["VALOR"]);
                                }
                                int valorCompra3 = int.Parse(Precio) + int.Parse(valorr);
                                sql = "UPDATE fecha_mes SET VALOR ='" + valorCompra3 + "' WHERE ID = '" + idd + "'";
                                MySqlCommand comandoooo = new MySqlCommand(sql, con.establecerConexion());
                                MySqlDataReader re = comandoooo.ExecuteReader();
                                while (re.Read()) { }


                                //AGREGAR LA COMPRA A LA TABLA detalles_compras
                                sql = "Select CODIGO, TIEMPO, PRECIO FROM paquetes where NOMBRE = '" + Paquete + "'";

                                comandoo = new MySqlCommand(sql, con.establecerConexion());
                                lector = comandoo.ExecuteReader();
                                id = "";
                                Precio = "";
                                while (lector.Read())
                                {
                                    id = Convert.ToString(lector["CODIGO"]);
                                    Precio = Convert.ToString(lector["PRECIO"]);
                                }
                                DateTime ya = DateTime.Now;
                                String yaa = (ya.Year.ToString() + "-" + ya.Month.ToString() + "-" + ya.Day + " " + ya.Hour.ToString() + "-" + ya.Minute.ToString() + "-" + ya.Second.ToString());

                                String x = "PAQUETE " + Paquete;

                                int precio = int.Parse(Precio);
                                String SQL = "INSERT INTO detalles_compras(NOMBRE, CANTIDAD, PRECIO, FECHA_COMPRA) "
                                                + "values('" + x + "','1','" + precio + "','" + yaa + "')";
                                coman = new MySqlCommand(SQL, con.establecerConexion());
                                reader1 = coman.ExecuteReader();
                                while (reader1.Read())
                                {

                                }
                            }

                        }//-------inicio condicional realizar compra de  tiquetes--------
                        else if (Paquete.Equals(""))
                        {
                            sql = "SELECT CODIGO, TIEMPO, PRECIO, MESES FROM tiquetes WHERE NOMBRE = '" + Tiquete + "'";
                            MySqlCommand comandoo = new MySqlCommand(sql, con.establecerConexion());
                            MySqlDataReader lector = comandoo.ExecuteReader();
                            String id = "";
                            String tiempo = "";
                            String precio = "";
                            String meses = "";
                            while (lector.Read())
                            {
                                id = Convert.ToString(lector["CODIGO"]);
                                tiempo = Convert.ToString(lector["TIEMPO"]);
                                precio = Convert.ToString(lector["PRECIO"]);
                                meses = Convert.ToString(lector["MESES"]);

                            }
                            DateTime hoy = DateTime.Today;
                            DateTime fin = hoy.AddMonths(int.Parse(meses));
                            //fin = fin.AddDays(- 1);
                            String hoyy = (hoy.Year.ToString() + "-" + hoy.Month.ToString() + "-" + hoy.Day.ToString());
                            String finn = (fin.Year.ToString() + "-" + fin.Month.ToString() + "-" + fin.Day.ToString());

                            String sql2 = "INSERT INTO compra_paquetes (CODIGO_TIQUETE, CODIGO_PAQUETE, CED_CLIENTE, FECHA_COMPRA, CLASES ,PRECIO, FECHA_FIN )"
                                + "values ('" + id + "',' 9 ','" + Cedula + "','" + hoyy + "','" + tiempo + "','" + precio + "','" + finn + "')";

                            MySqlCommand coman = new MySqlCommand(sql2, con.establecerConexion());
                            MySqlDataReader reader1 = coman.ExecuteReader();
                            while (reader1.Read())
                            {

                            }
                            MessageBox.Show("COMPRA EXITOSA");


                            //actualizacion del contador de ganancias dia - semana - mes

                            String Sql2 = "SELECT VALOR FROM fecha_dia WHERE FECHA ='" + hoyy + "'";
                            MySqlCommand comand = new MySqlCommand(Sql2, con.establecerConexion());
                            MySqlDataReader lecto = comand.ExecuteReader();
                            String valu = "0";
                            while (lecto.Read())
                            {

                                valu = Convert.ToString(lecto["VALOR"]); ;

                            }
                            int valorCompra1 = int.Parse(precio) + int.Parse(valu);
                            sql = "UPDATE fecha_dia SET VALOR ='" + valorCompra1 + "' WHERE FECHA = '" + hoyy + "'";
                            MySqlCommand com = new MySqlCommand(sql, con.establecerConexion());
                            MySqlDataReader read = com.ExecuteReader();
                            while (read.Read())
                            {

                            }
                            sql = "select ID,VALOR from fecha_semana WHERE FECHA_INICIO <='" + hoyy + "' AND  FECHA_FIN >= '" + hoyy + "'";
                            MySqlCommand coma = new MySqlCommand(sql, con.establecerConexion());
                            MySqlDataReader lect = coma.ExecuteReader();
                            id = "";
                            String Valor = "0";

                            while (lect.Read())
                            {
                                id = Convert.ToString(lect["ID"]);
                                Valor = Convert.ToString(lect["VALOR"]);
                            }
                            lect.Close();

                            int valorCompra2 = int.Parse(precio) + int.Parse(Valor);
                            String sql8 = "UPDATE fecha_semana SET VALOR ='" + valorCompra2 + "' WHERE ID = '" + id + "'";
                            MySqlCommand co = new MySqlCommand(sql8, con.establecerConexion());
                            MySqlDataReader rea = co.ExecuteReader();
                            while (rea.Read()) { }

                            String sql4 = "select ID, VALOR from fecha_mes WHERE FECHA_INICIO <='" + hoyy + "' AND  FECHA_FIN >= '" + hoyy + "'";
                            MySqlCommand comandooo = new MySqlCommand(sql4, con.establecerConexion());
                            MySqlDataReader let = comandooo.ExecuteReader();

                            String idd = "";
                            String valorr = "0";

                            while (let.Read())
                            {
                                idd = Convert.ToString(let["ID"]);
                                valorr = Convert.ToString(let["VALOR"]);
                            }
                            int valorCompra3 = int.Parse(precio) + int.Parse(valorr);
                            sql = "UPDATE fecha_mes SET VALOR ='" + valorCompra3 + "' WHERE ID = '" + idd + "'";
                            MySqlCommand comandoooo = new MySqlCommand(sql, con.establecerConexion());
                            MySqlDataReader re = comandoooo.ExecuteReader();
                            while (re.Read()) { }

                            //AGREGAR LA COMPRA A LA TABLA detalles_compras
                            sql = "Select CODIGO, PRECIO FROM tiquetes where NOMBRE = '" + Tiquete + "'";

                            comandoo = new MySqlCommand(sql, con.establecerConexion());
                            lector = comandoo.ExecuteReader();
                            id = "";
                            String Precio = "";
                            while (lector.Read())
                            {
                                id = Convert.ToString(lector["CODIGO"]);
                                Precio = Convert.ToString(lector["PRECIO"]);
                            }
                            DateTime ya = DateTime.Now;
                            String yaa = (ya.Year.ToString() + "-" + ya.Month.ToString() + "-" + ya.Day + " " + ya.Hour.ToString() + "-" + ya.Minute.ToString() + "-" + ya.Second.ToString());

                            String x = "TIQUETE " + Tiquete;

                            String SQL = "INSERT INTO detalles_compras(NOMBRE, CANTIDAD, PRECIO, FECHA_COMPRA) "
                                            + "values('" + x + "','1','" + Precio + "','" + yaa + "')";
                            coman = new MySqlCommand(SQL, con.establecerConexion());
                            reader1 = coman.ExecuteReader();
                            while (reader1.Read())
                            {

                            }


                        }
                        else
                            MessageBox.Show("SOLO SE PUEDE COMPRAR O UN PAQUETE O UNA TIQUETERA");
                    }
                    else
                        MessageBox.Show("EL USUARIO YA CUENTA CON PLAN A LA FECHA");

                }
                con.CerrarConexion();
            }
        }
        public void Filtrar(DataGridView TABLA, String Filtro)
        {
            try
            {
                DateTime hoy = DateTime.Today;
                String hoyy = (hoy.Year.ToString() + "-" + hoy.Month.ToString() + "-" + hoy.Day.ToString());
                if (Filtro.Equals(""))
                {
                    String sql = "SELECT C.ID AS ID, CLI.CEDULA AS CEDULA, CLI.NOMBRE AS NOMBRE, CLI.APELLIDO AS APELLIDO, P.NOMBRE AS NOMBRE_PAQUETE, T.NOMBRE AS NOMBRE_TIQUETE, C.CLASES AS CLASES, C.FECHA_COMPRA AS FECHA_COMPRA, C.FECHA_FIN AS FECHA_FIN FROM compra_paquetes C JOIN clientes CLI ON CLI.CEDULA = C.CED_CLIENTE JOIN paquetes P ON P.CODIGO = C.CODIGO_PAQUETE JOIN tiquetes T ON T.CODIGO = C.CODIGO_TIQUETE WHERE C.FECHA_FIN >= '" + hoyy + "' AND C.CLASES > '0'";
                    CConexion con = new CConexion();
                    TABLA.DataSource = null;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con.establecerConexion());
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    TABLA.DataSource = dt;
                    con.CerrarConexion();
                }
                else
                {

                    String sql = "SELECT C.ID AS ID, CLI.CEDULA AS CEDULA, CLI.NOMBRE AS NOMBRE, CLI.APELLIDO AS APELLIDO, P.NOMBRE AS NOMBRE_PAQUETE, T.NOMBRE AS NOMBRE_TIQUETE, C.CLASES AS CLASES, C.FECHA_COMPRA AS FECHA_COMPRA, C.FECHA_FIN AS FECHA_FIN FROM compra_paquetes C JOIN clientes CLI ON CLI.CEDULA = C.CED_CLIENTE JOIN paquetes P ON P.CODIGO = C.CODIGO_PAQUETE JOIN tiquetes T ON T.CODIGO = C.CODIGO_TIQUETE WHERE C.FECHA_FIN >= '" + hoyy + "' AND C.CLASES > '0' AND CLI.CEDULA = '" + Filtro + "'";
                    CConexion con = new CConexion();
                    TABLA.DataSource = null;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con.establecerConexion());
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    TABLA.DataSource = dt;
                    con.CerrarConexion();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CARGAR LOS CAMPOS EN LA TABLA ", ex.Message);
            }
        }
    }
}
