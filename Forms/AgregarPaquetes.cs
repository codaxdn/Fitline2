using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitLine
{
    public partial class AgregarPaquetes : Form
    {

        public AgregarPaquetes()
        {
            InitializeComponent();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CConexion con = new CConexion();
            con.establecerConexion();
            ClassModules.clsPaquetes tbalaPaquetes = new ClassModules.clsPaquetes();
            tbalaPaquetes.MostrarPaquetes(TABLA);
            AgregarEstado();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ClassModules.clsPaquetes Guardar = new ClassModules.clsPaquetes();
            String Nom = TxtNombre.Text;
            String Tiem = TxtTiempo.Text;
            String Preci = TxtPrecio.Text;
            String Estad = ComboEstado.SelectedItem.ToString();

            Guardar.GUARDAR(Nom, Tiem, Preci, Estad);
            Guardar.MostrarPaquetes(TABLA);


        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            ClassModules.clsPaquetes Editar = new ClassModules.clsPaquetes();
            String Cod = TxtCodigo.Text;
            String Nom = TxtNombre.Text;
            String Tiem = TxtTiempo.Text;
            String Preci = TxtPrecio.Text;
            String Estad = ComboEstado.SelectedItem.ToString();

            Editar.Editar(Cod, Nom, Tiem, Preci, Estad);
            Editar.MostrarPaquetes(TABLA);
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            ClassModules.clsPaquetes Borrar = new ClassModules.clsPaquetes();
            String Cod = TxtCodigo.Text;
            Borrar.borrar(Cod);
            Borrar.MostrarPaquetes(TABLA);
        }

        private void CmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTiempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Inicio abrir = new Inicio();
            abrir.Show();
            this.Close();

        }
        private void TABLA_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            ClassModules.clsPaquetes clic = new ClassModules.clsPaquetes();
            clic.seleccionar(TABLA, TxtCodigo, TxtNombre, TxtTiempo, TxtPrecio, ComboEstado);
        }

        void AgregarEstado()
        {
            
            ComboEstado.Items.Add("Activado");
            ComboEstado.Items.Add("Desactivado");
            ComboEstado.Text = "Activado";
        }

        private void TxtTiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
