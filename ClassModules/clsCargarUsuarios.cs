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
    internal class clsCargarUsuarios
    {

        public void MostrarUsuarios(DataGridView TABLA)
        {
            try
            {
                string sql = "SELECT CEDULA, NOMBRE, APELLIDO, NUMERO_CONTAC, CONTAC_EMER, EMAIL FROM clientes";
                using (CConexion con = new CConexion())
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con.establecerConexion()))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    TABLA.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CARGAR LOS CAMPOS EN LA TABLA: " + ex.Message);
            }
        }

        public void GUARDAR(String Cedula, String Nom, String Apellidos, String Contac, String Emergen, String Email, String Huella)
        {
            try
            {
                if (Cedula.Equals("") || Nom.Equals("") || Apellidos.Equals(""))
                {
                    MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS");
                    return;
                }

                CConexion con = new CConexion();

                String sql = "SELECT CEDULA FROM clientes WHERE CEDULA = @Cedula";
                MySqlCommand comando = new MySqlCommand(sql, con.establecerConexion());
                comando.Parameters.AddWithValue("@Cedula", Cedula);
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("EL REGISTRO " + Nom + " YA SE REGISTRO PREVIEAMENTE");
                    con.CerrarConexion();
                    return;
                }

                reader.Close();

                sql = "INSERT INTO clientes (CEDULA, NOMBRE, APELLIDO, NUMERO_CONTAC, CONTAC_EMER, EMAIL, HUELLA) " +
                      "VALUES (@Cedula, @Nombre, @Apellidos, @Contac, @Emergen, @Email, @Huella)";

                MySqlCommand coman = new MySqlCommand(sql, con.establecerConexion());
                coman.Parameters.AddWithValue("@Cedula", Cedula);
                coman.Parameters.AddWithValue("@Nombre", Nom);
                coman.Parameters.AddWithValue("@Apellidos", Apellidos);
                coman.Parameters.AddWithValue("@Contac", Contac);
                coman.Parameters.AddWithValue("@Emergen", Emergen);
                coman.Parameters.AddWithValue("@Email", Email);
                coman.Parameters.AddWithValue("@Huella", Huella);

                coman.ExecuteNonQuery();

                utils.GlobalCachingProvider objCache = utils.GlobalCachingProvider.Instance;
                objCache.RemoveItem("huella");

                con.CerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO GUARDAR EL REGISTRO CON EXITO ", ex.Message);
            }
        }



        public void seleccionar(DataGridView Tabla, TextBox TxtCedula, TextBox TxtNombres, TextBox TxtApellidos, TextBox TxtNumeroCon, TextBox TxtContactoEmer, TextBox TxtEmail)
        {
            try
            {
                TxtCedula.Text = Tabla.CurrentRow.Cells[0].Value.ToString();
                TxtNombres.Text = Tabla.CurrentRow.Cells[1].Value.ToString();
                TxtApellidos.Text = Tabla.CurrentRow.Cells[2].Value.ToString();
                TxtNumeroCon.Text = Tabla.CurrentRow.Cells[3].Value.ToString();
                TxtContactoEmer.Text = Tabla.CurrentRow.Cells[4].Value.ToString();
                TxtEmail.Text = Tabla.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO ACTUALIZAR EL REGISTRO CON EXITO ", ex.Message);
            }

        }


        public void editar(String Cedula, String Nom, String Apellidos, String Contac, String Emergen, String Email, String Huella)
        {
            try
            {
                if (string.IsNullOrEmpty(Cedula) || string.IsNullOrEmpty(Nom) || string.IsNullOrEmpty(Apellidos))
                {
                    MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS");
                    return;
                }

                CConexion con = new CConexion();
                con.establecerConexion();

                int variable = 0;
                String sql = "select CEDULA from clientes WHERE CEDULA = @cedula";
                MySqlCommand comando = new MySqlCommand(sql, con.establecerConexion());
                comando.Parameters.AddWithValue("@cedula", Cedula);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    variable = 1;
                }
                reader.Close();

                if (variable == 1)
                {
                    if (!string.IsNullOrEmpty(Huella))
                    {
                        sql = "UPDATE clientes SET NOMBRE = @nom, APELLIDO = @apellidos, NUMERO_CONTAC = @contac, CONTAC_EMER = @emergen, EMAIL = @email, HUELLA = @huella  where CEDULA = @cedula";
                    }
                    else
                    {
                        sql = "UPDATE clientes SET NOMBRE = @nom, APELLIDO = @apellidos, NUMERO_CONTAC = @contac, CONTAC_EMER = @emergen, EMAIL = @email where CEDULA = @cedula";
                    }

                    MySqlCommand coman = new MySqlCommand(sql, con.establecerConexion());
                    coman.Parameters.AddWithValue("@nom", Nom);
                    coman.Parameters.AddWithValue("@apellidos", Apellidos);
                    coman.Parameters.AddWithValue("@contac", Contac);
                    coman.Parameters.AddWithValue("@emergen", Emergen);
                    coman.Parameters.AddWithValue("@email", Email);
                    coman.Parameters.AddWithValue("@cedula", Cedula);

                    if (!string.IsNullOrEmpty(Huella))
                    {
                        coman.Parameters.AddWithValue("@huella", Huella);
                    }

                    coman.ExecuteNonQuery();
                    MessageBox.Show("EL USUARIO SE ACTUALIZO CON EXITO");
                }
                else
                {
                    MessageBox.Show("EL USUARIO CON NUMERO DE CEDULA " + Cedula + " NO EXISTE");
                }

                con.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO GUARDAR EL REGISTRO CON EXITO ", ex.Message);
            }
        }

        public void borrar(string cedula)
        {
            if (string.IsNullOrEmpty(cedula))
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO");
                return;
            }

            try
            {
                using (CConexion con = new CConexion())
                {
                    string sql = "SELECT CEDULA FROM clientes WHERE CEDULA = @cedula";
                    MySqlCommand comando = new MySqlCommand(sql, con.establecerConexion());
                    comando.Parameters.AddWithValue("@cedula", cedula);
                    MySqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Close();
                        sql = "DELETE FROM clientes WHERE CEDULA = @cedula";
                        comando = new MySqlCommand(sql, con.establecerConexion());
                        comando.Parameters.AddWithValue("@cedula", cedula);
                        comando.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("EL REGISTRO NO EXISTE");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO ELIMINAR EL REGISTRO CON EXITO ", ex.Message);
            }
        }

        public void Filtrar(DataGridView TABLA, string Filtro)
        {
            try
            {
                string sql = "SELECT CEDULA, NOMBRE, APELLIDO, NUMERO_CONTAC, CONTAC_EMER, EMAIL FROM clientes";
                if (!string.IsNullOrEmpty(Filtro))
                {
                    sql += " WHERE CEDULA = @cedula";
                }

                using (var con = new CConexion())
                {
                    using (var cmd = new MySqlCommand(sql, con.establecerConexion()))
                    {
                        if (!string.IsNullOrEmpty(Filtro))
                        {
                            cmd.Parameters.AddWithValue("@cedula", Filtro);
                        }

                        TABLA.DataSource = null;
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            var dt = new DataTable();
                            adapter.Fill(dt);
                            TABLA.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CARGAR LOS CAMPOS EN LA TABLA ", ex.Message);
            }
        }

    }
}
