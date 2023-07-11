using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace FitLine
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loggin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LOGGIN_Load(object sender, EventArgs e)
        {
            LaPista.Visible = false;

        }
        public void loggin()
        {
            string usuario = TxtUsuario.Text;
            string contraseña = TxtContraseña.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Debes llenar todos los campos!");
                return;
            }

            try
            {
                using (CConexion con = new CConexion())
                {
                    con.establecerConexion();
                    string sql = "SELECT USUARIO, CONTRASEÑA FROM loggin WHERE USUARIO = @usuario AND CONTRASEÑA = @contraseña";
                    MySqlCommand comando = new MySqlCommand(sql, con.establecerConexion());
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@contraseña", contraseña);
                    MySqlDataReader lector = comando.ExecuteReader();

                    if (lector.Read())
                    {
                        Inicio abrir = new Inicio();
                        abrir.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña invalida!");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se pudo realizar la conexión a la base de datos: " + ex.Message);
            }
        }

        public void pista()
        {
            string usuario = TxtUsuario.Text.Trim();

            if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Debes llenar todos los campos.");
                return;
            }

            try
            {
                using (CConexion con = new CConexion())
                {
                    con.establecerConexion();

                    string sql = "SELECT PISTA FROM loggin WHERE USUARIO = @usuario";
                    MySqlCommand comando = new MySqlCommand(sql, con.establecerConexion());
                    comando.Parameters.AddWithValue("@usuario", usuario);

                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            LaPista.Text = lector.GetString("PISTA");
                            LaPista.Visible = true;
                        }
                    }
                }
            }
            catch (MySqlException)
            {
                // handle exception
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pista();
        }
    }
}
