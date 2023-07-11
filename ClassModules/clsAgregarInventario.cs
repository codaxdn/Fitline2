using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitLine.ClassModules
{
    internal class clsAgregarInventario
    {
        public void MostrarInventario(DataGridView TABLA)
        {
            try
            {
                CConexion con = new CConexion();
                string sql = "select * from inventario";
                TABLA.DataSource = null;
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con.establecerConexion()))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    TABLA.DataSource = dt;
                }
                con.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CARGAR LOS CAMPOS EN LA TABLA", ex.Message);
            }
        }

        public void GUARDAR(string Nom, string Cantidad, string Descripcion, string Precio)
        {
            try
            {
                using (CConexion con = new CConexion())
                {
                    string sql = "SELECT NOMBRE FROM inventario WHERE NOMBRE = @Nom";
                    MySqlCommand comando = new MySqlCommand(sql, con.establecerConexion());
                    comando.Parameters.AddWithValue("@Nom", Nom);
                    MySqlDataReader reader = comando.ExecuteReader();
                    int variable = reader.HasRows ? 1 : 0;
                    reader.Close();

                    if (Nom.Equals("") || Cantidad.Equals("") || Descripcion.Equals("") || Precio.Equals(""))
                    {
                        MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS");
                    }
                    else
                    {
                        if (variable == 0)
                        {
                            sql = "INSERT INTO inventario (NOMBRE, CANTIDAD, DESCRIPCION, PRECIO) "
                                + "VALUES (@Nom, @Cantidad, @Descripcion, @Precio)";
                            MySqlCommand coman = new MySqlCommand(sql, con.establecerConexion());
                            coman.Parameters.AddWithValue("@Nom", Nom);
                            coman.Parameters.AddWithValue("@Cantidad", Cantidad);
                            coman.Parameters.AddWithValue("@Descripcion", Descripcion);
                            coman.Parameters.AddWithValue("@Precio", Precio);
                            coman.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("EL REGISTRO " + Nom + " YA SE REGISTRO PREVIAMENTE");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO GUARDAR EL REGISTRO CON EXITO", ex.Message);
            }
        }


        public void SelectRow(DataGridView table, TextBox code, TextBox name, TextBox quantity, TextBox description, TextBox price)
        {
            try
            {
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("No hay registros para seleccionar.");
                    return;
                }

                DataGridViewRow row = table.CurrentRow;

                if (row == null)
                {
                    MessageBox.Show("Debes seleccionar un registro.");
                    return;
                }

                code.Text = row.Cells[0].Value.ToString();
                name.Text = row.Cells[1].Value.ToString();
                quantity.Text = row.Cells[2].Value.ToString();
                description.Text = row.Cells[3].Value.ToString();
                price.Text = row.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                // Display a user-friendly error message
                MessageBox.Show("Ocurrió un error al seleccionar el registro. Por favor, intenta de nuevo más tarde.");
            }
        }


        public void editar(string codigo, string nombre, string cantidad, string descripcion, string precio)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(cantidad) ||
                    string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(precio))
                {
                    MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS");
                    return;
                }

                using (var con = new CConexion())
                {
                    var cmd = new MySqlCommand("SELECT COUNT(*) FROM inventario WHERE CODIGO = @codigo", con.establecerConexion());
                    cmd.Parameters.AddWithValue("@codigo", codigo);

                    if ((int)cmd.ExecuteScalar() == 0)
                    {
                        MessageBox.Show($"EL REGISTRO CON CODIGO {codigo} NO EXISTE");
                        return;
                    }

                    cmd = new MySqlCommand("UPDATE inventario SET NOMBRE = @nombre, CANTIDAD = @cantidad, DESCRIPCION = @descripcion, PRECIO = @precio WHERE CODIGO = @codigo", con.establecerConexion());
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@codigo", codigo);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("EL ARTICULO SE ACTUALIZO CON EXITO");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"NO SE PUDO ACTUALIZAR EL REGISTRO CON EXITO: {ex.Message}");
            }
        }


        public void borrar(string codigo)
        {
            try
            {
                if (string.IsNullOrEmpty(codigo))
                {
                    MessageBox.Show("DEBE SELECCIONAR UN REGISTRO");
                    return;
                }

                using (CConexion con = new CConexion())
                {
                    MySqlCommand comando = new MySqlCommand("SELECT CODIGO FROM inventario WHERE CODIGO = @codigo", con.establecerConexion());
                    comando.Parameters.AddWithValue("@codigo", codigo);
                    object result = comando.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("EL REGISTRO NO EXISTE");
                        return;
                    }

                    MySqlCommand coman = new MySqlCommand("DELETE FROM inventario WHERE CODIGO = @codigo", con.establecerConexion());
                    coman.Parameters.AddWithValue("@codigo", codigo);
                    coman.ExecuteNonQuery();

                    MessageBox.Show("EL REGISTRO SE ELIMINÓ CON ÉXITO");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO ELIMINAR EL REGISTRO CON ÉXITO", ex.Message);
            }
        }

        public void SUMAR(string codigo, string agregar, string antes)
        {
            try
            {
                if (string.IsNullOrEmpty(codigo))
                {
                    MessageBox.Show("DEBE SELECCIONAR UN REGISTRO");
                    return;
                }

                int cantidad = int.Parse(agregar) + int.Parse(antes);
                string sql = $"UPDATE inventario SET CANTIDAD = '{cantidad}' WHERE CODIGO = '{codigo}'";

                using (CConexion con = new CConexion())
                {
                    MySqlCommand comando = new MySqlCommand(sql, con.establecerConexion());
                    MySqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        // Do nothing
                    }
                }

                MessageBox.Show("EL REGISTRO SE ACTUALIZÓ CON ÉXITO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO ACTUALIZAR EL REGISTRO CON ÉXITO", ex.Message);
            }
        }

        public void vender(String Codigo, String Cantidad, String CantidadAnterior, String Precio)
        {
            try
            {
                int variable = 0;
                String sql = "select CODIGO from inventario WHERE CODIGO = '" + Codigo + "'";
                CConexion con = new CConexion();
                MySqlCommand comando = new MySqlCommand(sql, con.establecerConexion());
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    variable = 1;
                }
                if (Codigo.Equals(""))
                {
                    MessageBox.Show("DEBE SELECCIONAR UN REGISTRO");
                }
                else
                {
                    if (variable == 1)
                    {
                        int x = int.Parse(CantidadAnterior);
                        int y = int.Parse(Cantidad);
                        int variablee = x - y;

                        if (variablee < 0)
                        {
                            MessageBox.Show("NO CUENTA CON SUFICIENTE PRODUCTO");
                        }
                        else
                        {
                            if (variablee == 0)
                            {
                                int a = int.Parse(Cantidad);
                                int b = int.Parse(Precio);
                                int valorCompra = a * b;
                                sql = "UPDATE inventario SET CANTIDAD = '" + variablee + "'  where CODIGO = " + Codigo;
                                MySqlCommand coman = new MySqlCommand(sql, con.establecerConexion());
                                MySqlDataReader reader1 = coman.ExecuteReader();
                                while (reader1.Read())
                                {

                                }
                                DateTime date = DateTime.Today;
                                String hoy = (date.Year.ToString() + "-" + date.Month.ToString() + "-" + date.Day.ToString());
                                String Sql2 = "SELECT VALOR FROM fecha_dia WHERE FECHA ='" + hoy + "'";
                                MySqlCommand comand = new MySqlCommand(Sql2, con.establecerConexion());
                                MySqlDataReader lector = comand.ExecuteReader();
                                String valu = "0";
                                while (lector.Read())
                                {

                                    valu = Convert.ToString(lector["VALOR"]); ;

                                }
                                int valorCompra1 = valorCompra + int.Parse(valu);
                                sql = "UPDATE fecha_dia SET VALOR ='" + valorCompra1 + "' WHERE FECHA = '" + hoy + "'";
                                MySqlCommand com = new MySqlCommand(sql, con.establecerConexion());
                                MySqlDataReader read = com.ExecuteReader();
                                while (read.Read())
                                {

                                }
                                sql = "select ID,VALOR from fecha_semana WHERE FECHA_INICIO <='" + hoy + "' AND  FECHA_FIN >= '" + hoy + "'";
                                MySqlCommand coma = new MySqlCommand(sql, con.establecerConexion());
                                MySqlDataReader lect = coma.ExecuteReader();
                                String id = "";
                                String Valor = "0";

                                while (lect.Read())
                                {
                                    id = Convert.ToString(lect["ID"]);
                                    Valor = Convert.ToString(lect["VALOR"]);
                                }
                                lect.Close();

                                int valorCompra2 = valorCompra + int.Parse(Valor);
                                String sql8 = "UPDATE fecha_semana SET VALOR ='" + valorCompra2 + "' WHERE ID = '" + id + "'";
                                MySqlCommand co = new MySqlCommand(sql8, con.establecerConexion());
                                MySqlDataReader rea = co.ExecuteReader();

                                while (rea.Read()) { }

                                String sql4 = "select ID, VALOR from fecha_mes WHERE FECHA_INICIO <='" + hoy + "' AND  FECHA_FIN >= '" + hoy + "'";
                                MySqlCommand comandoo = new MySqlCommand(sql4, con.establecerConexion());
                                MySqlDataReader let = comandoo.ExecuteReader();

                                String idd = "";
                                String valorr = string.Empty;

                                while (let.Read())
                                {
                                    idd = Convert.ToString(let["ID"]);
                                    valorr = Convert.ToString(let["VALOR"]);
                                }
                                int valorCompra3 = valorCompra + int.Parse(valorr);
                                sql = "UPDATE fecha_mes SET VALOR ='" + valorCompra3 + "' WHERE ID = '" + idd + "'";
                                MySqlCommand comandooo = new MySqlCommand(sql, con.establecerConexion());
                                MySqlDataReader re = comandooo.ExecuteReader();
                                while (re.Read()) { }

                                //AGREGAR LA COMPRA A LA TABLA detalles_compras
                                DateTime ya = DateTime.Now;
                                String yaa = (ya.Year.ToString() + "-" + ya.Month.ToString() + "-" + ya.Day + " " + ya.Hour.ToString() + "-" + ya.Minute.ToString() + "-" + ya.Second.ToString());
                                sql = "SELECT NOMBRE from inventario where CODIGO = " + Codigo;
                                String Nombre = "";
                                coman = new MySqlCommand(sql, con.establecerConexion());
                                reader1 = coman.ExecuteReader();
                                while (reader1.Read())
                                {
                                    Nombre = Convert.ToString(reader1["NOMBRE"]);
                                }

                                int precio = int.Parse(Precio) * int.Parse(Cantidad);
                                String SQL = "INSERT INTO detalles_compras(NOMBRE, CANTIDAD, PRECIO, FECHA_COMPRA) "
                                                + "values('"+Nombre+"','"+Cantidad+"','"+ precio + "','"+yaa+"')";
                                coman = new MySqlCommand(SQL, con.establecerConexion());
                                reader1 = coman.ExecuteReader();
                                while (reader1.Read())
                                {

                                }
                            }
                            else
                            {
                                int a = int.Parse(Cantidad);
                                int b = int.Parse(Precio);
                                int valorCompra = a * b;
                                sql = "UPDATE inventario SET CANTIDAD = '" + variablee + "'  where CODIGO = " + Codigo;
                                MySqlCommand coman = new MySqlCommand(sql, con.establecerConexion());
                                MySqlDataReader reader1 = coman.ExecuteReader();
                                while (reader1.Read())
                                {

                                }

                                DateTime date = DateTime.Today;
                                String hoy = (date.Year.ToString() + "-" + date.Month.ToString() + "-" + date.Day.ToString());
                                String Sql2 = "SELECT VALOR FROM fecha_dia WHERE FECHA ='" + hoy + "'";
                                MySqlCommand comand = new MySqlCommand(Sql2, con.establecerConexion());
                                MySqlDataReader lector = comand.ExecuteReader();
                                String valu = "0";
                                while (lector.Read())
                                {

                                    valu = Convert.ToString(lector["VALOR"]); ;

                                }
                                int valorCompra1 = valorCompra + int.Parse(valu);
                                sql = "UPDATE fecha_dia SET VALOR ='" + valorCompra1 + "' WHERE FECHA = '" + hoy + "'";
                                MySqlCommand com = new MySqlCommand(sql, con.establecerConexion());
                                MySqlDataReader read = com.ExecuteReader();
                                while (read.Read())
                                {

                                }
                                sql = "select ID,VALOR from fecha_semana WHERE FECHA_INICIO <='" + hoy + "' AND  FECHA_FIN >= '" + hoy + "'";
                                MySqlCommand coma = new MySqlCommand(sql, con.establecerConexion());
                                MySqlDataReader lect = coma.ExecuteReader();
                                String id = "";
                                String Valor = "0";

                                while (lect.Read())
                                {
                                    id = Convert.ToString(lect["ID"]);
                                    Valor = Convert.ToString(lect["VALOR"]);
                                }
                                lect.Close();
                                
                                int valorCompra2 = valorCompra + int.Parse(Valor);
                                String sql8 = "UPDATE fecha_semana SET VALOR ='" + valorCompra2 + "' WHERE ID = '" + id + "'";
                                MySqlCommand co = new MySqlCommand(sql8, con.establecerConexion());
                                MySqlDataReader rea = co.ExecuteReader();

                                while (rea.Read()) { }

                                String sql4 = "select ID, VALOR from fecha_mes WHERE FECHA_INICIO <='" + hoy + "' AND  FECHA_FIN >= '" + hoy + "'";
                                MySqlCommand comandoo = new MySqlCommand(sql4, con.establecerConexion());
                                MySqlDataReader let = comandoo.ExecuteReader();

                                String idd = "";
                                String valorr= string.Empty;

                                while (let.Read())
                                {
                                    idd = Convert.ToString(let["ID"]);
                                    valorr = Convert.ToString(let ["VALOR"]);
                                }
                                int valorCompra3 = valorCompra + int.Parse(valorr);
                                sql = "UPDATE fecha_mes SET VALOR ='" + valorCompra3 + "' WHERE ID = '" + idd + "'";
                                MySqlCommand comandooo = new MySqlCommand(sql, con.establecerConexion());
                                MySqlDataReader re = comandooo.ExecuteReader();
                                while (re.Read()) { }


                                //AGREGAR LA COMPRA A LA TABLA detalles_compras
                                DateTime ya = DateTime.Now;
                                String yaa = (ya.Year.ToString() + "-" + ya.Month.ToString() + "-" + ya.Day + " " + ya.Hour.ToString() + "-" + ya.Minute.ToString() + "-" + ya.Second.ToString() );
                                sql = "SELECT NOMBRE from inventario where CODIGO = " + Codigo;
                                String Nombre = "";
                                coman = new MySqlCommand(sql, con.establecerConexion());
                                reader1 = coman.ExecuteReader();
                                while (reader1.Read())
                                {
                                    Nombre = Convert.ToString(reader1["NOMBRE"]);
                                }

                                int precio = int.Parse(Precio) * int.Parse(Cantidad);
                                String SQL = "INSERT INTO detalles_compras(NOMBRE, CANTIDAD, PRECIO, FECHA_COMPRA) "
                                                + "values('" + Nombre + "','" + Cantidad + "','" + precio + "','" + yaa + "')";
                                coman = new MySqlCommand(SQL, con.establecerConexion());
                                reader1 = coman.ExecuteReader();
                                while (reader1.Read())
                                {

                                }

                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("EL REGISTRO NO EXISTE");
                    }
                }

            }
            catch(Exception ex) { }
        }

    }
}
