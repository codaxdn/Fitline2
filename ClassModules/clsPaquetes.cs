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
    internal class clsPaquetes
    {
        public void MostrarPaquetes(DataGridView TABLA)
        {
            try
            {
                string sql = "select * from paquetes WHERE CODIGO != '9'";
                using (var con = new CConexion().establecerConexion())
                using (var adapter = new MySqlDataAdapter(sql, con))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    TABLA.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CARGAR LOS CAMPOS EN LA TABLA ", ex.Message);
            }
        }

        public void GUARDAR(string nom, string tiem, string preci, string estad)
        {
            try
            {
                if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(tiem) || string.IsNullOrEmpty(preci))
                {
                    MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS");
                    return;
                }

                using (var con = new CConexion())
                {
                    con.establecerConexion();

                    var sql = "SELECT COUNT(*) FROM paquetes WHERE NOMBRE = @Nom";
                    using (var comando = new MySqlCommand(sql, con.establecerConexion()))
                    {
                        comando.Parameters.AddWithValue("@Nom", nom);
                        var reader = comando.ExecuteScalar();
                        var count = Convert.ToInt32(reader);
                        if (count > 0)
                        {
                            MessageBox.Show($"EL REGISTRO {nom} YA SE REGISTRO PREVIAMENTE");
                            return;
                        }
                    }

                    sql = "INSERT INTO paquetes (NOMBRE, TIEMPO,PRECIO ,ESTADO) VALUES (@Nom, @Tiem, @Preci, @Estad)";
                    using (var coman = new MySqlCommand(sql, con.establecerConexion()))
                    {
                        coman.Parameters.AddWithValue("@Nom", nom);
                        coman.Parameters.AddWithValue("@Tiem", tiem);
                        coman.Parameters.AddWithValue("@Preci", preci);
                        coman.Parameters.AddWithValue("@Estad", estad);
                        coman.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO GUARDAR EL REGISTRO CON EXITO " + ex.Message);
            }
        }

        public void seleccionar(DataGridView tabla, TextBox txtCodigo, TextBox txtNombre, TextBox txtTiempo, TextBox txtPrecio, ComboBox comboEstado)
        {
            try
            {
                DataGridViewRow row = tabla.CurrentRow;
                if (row != null)
                {
                    txtCodigo.Text = row.Cells[0].Value?.ToString();
                    txtNombre.Text = row.Cells[1].Value?.ToString();
                    txtTiempo.Text = row.Cells[2].Value?.ToString();
                    txtPrecio.Text = row.Cells[4].Value?.ToString();
                    comboEstado.Text = row.Cells[3].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO ACTUALIZAR EL REGISTRO CON EXITO ", ex.Message);
            }
        }

        public void Editar(string txtCodigo, string txtNombre, string txtTiempo, string txtPrecio, string comboEstado)
        {
            try
            {
                int variable = 0;
                Console.WriteLine(txtCodigo);
                string sql = "SELECT CODIGO FROM paquetes WHERE CODIGO = @Codigo";
                using (var con = new CConexion())
                using (var comando = new MySqlCommand(sql, con.establecerConexion()))
                {
                    comando.Parameters.AddWithValue("@Codigo", txtCodigo);
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            variable = 1;
                        }
                    }
                }

                if (string.IsNullOrEmpty(txtNombre) || string.IsNullOrEmpty(txtTiempo) || string.IsNullOrEmpty(txtPrecio))
                {
                    MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS");
                }
                else
                {
                    if (variable == 1)
                    {
                        sql = "UPDATE paquetes SET NOMBRE = @Nombre, TIEMPO = @Tiempo, ESTADO = @Estado, PRECIO = @Precio WHERE CODIGO = @Codigo";
                        using (var con = new CConexion())
                        using (var coman = new MySqlCommand(sql, con.establecerConexion()))
                        {
                            coman.Parameters.AddWithValue("@Nombre", txtNombre);
                            coman.Parameters.AddWithValue("@Tiempo", txtTiempo);
                            coman.Parameters.AddWithValue("@Estado", comboEstado);
                            coman.Parameters.AddWithValue("@Precio", txtPrecio);
                            coman.Parameters.AddWithValue("@Codigo", txtCodigo);
                            using (var reader1 = coman.ExecuteReader())
                            {
                                while (reader1.Read())
                                {

                                }
                            }
                        }
                        MessageBox.Show("EL PAQUETE SE ACTUALIZO CON EXITO");
                    }
                    else
                    {
                        MessageBox.Show("EL REGISTRO " + txtNombre + " NO EXISTE");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO GUARDAR EL REGISTRO CON EXITO ", ex.Message);
            }
        }

        public void borrar(string codigo)
        {
            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Debe seleccionar un registro");
                return;
            }

            try
            {
                string sql = "SELECT COUNT(*) FROM paquetes WHERE CODIGO = @codigo";
                using (CConexion con = new CConexion())
                using (MySqlCommand comando = new MySqlCommand(sql, con.establecerConexion()))
                {
                    comando.Parameters.AddWithValue("@codigo", codigo);
                    int count = Convert.ToInt32(comando.ExecuteScalar());
                    if (count == 0)
                    {
                        MessageBox.Show("El registro no existe");
                        return;
                    }
                }

                sql = "DELETE FROM paquetes WHERE CODIGO = @codigo";
                using (CConexion con = new CConexion())
                using (MySqlCommand comando = new MySqlCommand(sql, con.establecerConexion()))
                {
                    comando.Parameters.AddWithValue("@codigo", codigo);
                    int rowsAffected = comando.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("El registro se eliminó con éxito");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el registro con éxito: " + ex.Message);
            }
        }

    }
}