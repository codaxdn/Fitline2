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
    internal class clsTiquetes
    {
        public void MostrarTiquetes(DataGridView TABLA)
        {
            try
            {
                String sql = "SELECT CODIGO, NOMBRE, TIEMPO, PRECIO, ESTADO FROM tiquetes WHERE CODIGO != '4'";
                DataTable dt = new DataTable();

                using (CConexion con = new CConexion())
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con.establecerConexion()))
                    {
                        adapter.Fill(dt);
                    }
                }

                TABLA.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CARGAR LOS CAMPOS EN LA TABLA ", ex.Message);
            }
        }

        public void GUARDAR(string Nom, string Tiem, string Meses, string Preci, string Estad)
        {
            try
            {
                if (string.IsNullOrEmpty(Nom) || string.IsNullOrEmpty(Tiem) || string.IsNullOrEmpty(Meses) || string.IsNullOrEmpty(Preci))
                {
                    MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS");
                    return;
                }

                using (CConexion con = new CConexion())
                {
                    string sql = "SELECT COUNT(*) FROM tiquetes WHERE NOMBRE = @Nom";
                    using (MySqlCommand comando = new MySqlCommand(sql, con.establecerConexion()))
                    {
                        comando.Parameters.AddWithValue("@Nom", Nom);
                        int count = Convert.ToInt32(comando.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show($"EL REGISTRO {Nom} YA SE REGISTRO PREVIAMENTE");
                            return;
                        }
                    }

                    sql = "INSERT INTO tiquetes (NOMBRE, TIEMPO, MESES, PRECIO, ESTADO) VALUES (@Nom, @Tiem, @Meses, @Preci, @Estad)";
                    using (MySqlCommand coman = new MySqlCommand(sql, con.establecerConexion()))
                    {
                        coman.Parameters.AddWithValue("@Nom", Nom);
                        coman.Parameters.AddWithValue("@Tiem", Tiem);
                        coman.Parameters.AddWithValue("@Meses", Meses);
                        coman.Parameters.AddWithValue("@Preci", Preci);
                        coman.Parameters.AddWithValue("@Estad", Estad);

                        int rowsAffected = coman.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("EL REGISTRO SE GUARDO CON EXITO");
                        }
                        else
                        {
                            MessageBox.Show("NO SE PUDO GUARDAR EL REGISTRO");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO GUARDAR EL REGISTRO CON EXITO ", ex.Message);
            }
        }

        public void seleccionar(DataGridView Tabla, TextBox TxtCodigo, TextBox TxtNombre, TextBox TxtTiempo, TextBox TxtMeses, TextBox TxtPrecio, ComboBox ComboEstado)
        {
            try
            {
                if (Tabla.CurrentRow != null)
                {
                    TxtCodigo.Text = Tabla.CurrentRow.Cells[0].Value.ToString();
                    TxtNombre.Text = Tabla.CurrentRow.Cells[1].Value.ToString();
                    TxtTiempo.Text = Tabla.CurrentRow.Cells[2].Value.ToString();
                    TxtMeses.Text = Tabla.CurrentRow.Cells[3].Value.ToString();
                    TxtPrecio.Text = Tabla.CurrentRow.Cells[4].Value.ToString();
                    ComboEstado.Text = Tabla.CurrentRow.Cells[5].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO ACTUALIZAR EL REGISTRO CON EXITO ", ex.Message);
            }
        }

        public void editar(string codigo, string nombre, string tiempo, string meses, string precio, string estado)
        {
            try
            {
                if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(tiempo) || string.IsNullOrEmpty(meses) || string.IsNullOrEmpty(precio) || string.IsNullOrEmpty(estado))
                {
                    MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS");
                    return;
                }

                string sql = "UPDATE tiquetes SET NOMBRE = @nombre, TIEMPO = @tiempo, ESTADO = @estado, PRECIO = @precio, MESES = @meses WHERE CODIGO = @codigo";
                CConexion con = new CConexion();
                MySqlCommand comando = new MySqlCommand(sql, con.establecerConexion());
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@tiempo", tiempo);
                comando.Parameters.AddWithValue("@estado", estado);
                comando.Parameters.AddWithValue("@precio", precio);
                comando.Parameters.AddWithValue("@meses", meses);
                comando.Parameters.AddWithValue("@codigo", codigo);
                int rowsAffected = comando.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("EL TIQUETE SE ACTUALIZO CON EXITO");
                }
                else
                {
                    MessageBox.Show("EL REGISTRO " + nombre + " NO EXISTE");
                }

                con.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO GUARDAR EL REGISTRO CON EXITO " + ex.Message);
            }
        }


        public void borrar(string codigo)
        {
            try
            {
                int variable = 0;
                string sql = "SELECT CODIGO FROM tiquetes WHERE CODIGO = @codigo";
                CConexion con = new CConexion();
                MySqlCommand comando = new MySqlCommand(sql, con.establecerConexion());
                comando.Parameters.AddWithValue("@codigo", codigo);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    variable = 1;
                }
                if (codigo.Equals(""))
                {
                    MessageBox.Show("DEBE SELECCIONAR UN REGISTRO");
                }
                else
                {
                    if (variable == 1)
                    {
                        sql = "DELETE FROM tiquetes WHERE CODIGO = @codigo";
                        MySqlCommand coman = new MySqlCommand(sql, con.establecerConexion());
                        coman.Parameters.AddWithValue("@codigo", codigo);
                        MySqlDataReader reader1 = coman.ExecuteReader();
                        while (reader1.Read())
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("EL REGISTRO NO EXISTE");
                    }
                }
                con.CerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO ELIMINAR EL REGISTRO CON EXITO ", ex.Message);
            }
        }

    }
}
