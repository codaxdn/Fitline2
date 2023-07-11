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
    public partial class AgregarTiquetes : Form
    {
        public AgregarTiquetes()
        {
            InitializeComponent();
        }

        private void AGREGAR_TIQUETES_Load(object sender, EventArgs e)
        {
            CConexion con = new CConexion();
            con.establecerConexion();
            ClassModules.clsTiquetes tbalaPaquetes = new ClassModules.clsTiquetes();
            tbalaPaquetes.MostrarTiquetes(TABLA);
            AgregarEstado();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ClassModules.clsTiquetes Guardar = new ClassModules.clsTiquetes();
            String Nom = TxtNombre.Text;
            String Tiem = TxtTiempo.Text;
            String Meses = TxtMeses.Text;
            String Preci = TxtPrecio.Text;
            String Estad = ComboEstado.SelectedItem.ToString();
            Guardar.GUARDAR( Nom,  Tiem,  Meses,  Preci,  Estad);
            Guardar.MostrarTiquetes(TABLA);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Inicio abrir = new Inicio();
            abrir.Show();
            this.Close();
            
        }

        void AgregarEstado()
        {

            ComboEstado.Items.Add("Activado");
            ComboEstado.Items.Add("Desactivado");
            ComboEstado.Text = "Activado";
        }

        private void TABLA_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            ClassModules.clsTiquetes clic = new ClassModules.clsTiquetes();
            clic.seleccionar(TABLA, TxtCodigo, TxtNombre, TxtTiempo, TxtMeses, TxtPrecio, ComboEstado);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            ClassModules.clsTiquetes Editar = new ClassModules.clsTiquetes();
            String Cod = TxtCodigo.Text;
            String Nom = TxtNombre.Text;
            String Tiem = TxtTiempo.Text;
            String Meses = TxtMeses.Text;
            String Preci = TxtPrecio.Text;
            String Estad = ComboEstado.SelectedItem.ToString();

            Editar.editar(Cod, Nom, Tiem, Meses,  Preci, Estad);
            Editar.MostrarTiquetes(TABLA);
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            ClassModules.clsTiquetes Borrar = new ClassModules.clsTiquetes();
            String Cod = TxtCodigo.Text;
            Borrar.borrar(Cod);
            Borrar.MostrarTiquetes(TABLA);
        }

        private void ComboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtTiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
