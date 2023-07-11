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
    public partial class AgregarInventario : Form
    {
        public AgregarInventario()
        {
            InitializeComponent();
        }

        private void AGREGAR_INVENTARIO_Load(object sender, EventArgs e)
        {
            CConexion con = new CConexion();
            con.establecerConexion();
            ClassModules.clsAgregarInventario tablainventario = new ClassModules.clsAgregarInventario();
            tablainventario.MostrarInventario(TABLA);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ClassModules.clsAgregarInventario tablainventario = new ClassModules.clsAgregarInventario();
            String Nombre = TxtNombre.Text;
            String Cantidad = TxtCantidad.Text;
            String Descripcion = TxtDescripcion.Text;
            String Precio = TxtPrecio.Text;
            ClassModules.clsAgregarInventario GUARDAR = new ClassModules.clsAgregarInventario();
            GUARDAR.GUARDAR(Nombre, Cantidad, Descripcion, Precio);

            tablainventario.MostrarInventario(TABLA);
        }

        private void TABLA_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ClassModules.clsAgregarInventario cargar = new ClassModules.clsAgregarInventario();
            cargar.SelectRow(TABLA, TxtCodigo, TxtNombre, TxtCantidad, TxtDescripcion, TxtPrecio);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            ClassModules.clsAgregarInventario tablainventario = new ClassModules.clsAgregarInventario();
            ClassModules.clsAgregarInventario EDITAR = new ClassModules.clsAgregarInventario();
            String Codigo = TxtCodigo.Text;
            String Nombre = TxtNombre.Text;
            String Cantidad = TxtCantidad.Text;
            String Descripcion = TxtDescripcion.Text;
            String Precio = TxtPrecio.Text;
            EDITAR.editar(Codigo, Nombre, Cantidad, Descripcion, Precio);
            tablainventario.MostrarInventario(TABLA);
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            ClassModules.clsAgregarInventario tablainventario = new ClassModules.clsAgregarInventario();
            ClassModules.clsAgregarInventario BORRAR = new ClassModules.clsAgregarInventario();
            String Codigo = TxtCodigo.Text;
            BORRAR.borrar(Codigo);
            tablainventario.MostrarInventario(TABLA);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassModules.clsAgregarInventario tablainventario = new ClassModules.clsAgregarInventario();
            ClassModules.clsAgregarInventario agregar = new ClassModules.clsAgregarInventario();
            String Codigo = TxtCodigo.Text;
            String sumar = TxtCantSuma.Text;
            String MAS = TxtCantidad.Text;
            agregar.SUMAR(Codigo, sumar, MAS);
            tablainventario.MostrarInventario(TABLA);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Inicio abrir = new Inicio();
            abrir.Show();
            this.Close();
        }

        private void TxtVender_Click(object sender, EventArgs e)
        {
            ClassModules.clsAgregarInventario tablainventario = new ClassModules.clsAgregarInventario();
            ClassModules.clsAgregarInventario vender = new ClassModules.clsAgregarInventario();
            String Codigo = TxtCodigo.Text;
            String venderr = TxtVende.Text;
            String Cantidad = TxtCantidad.Text;
            String precio = TxtPrecio.Text;
            vender.vender(Codigo, venderr, Cantidad, precio);
            tablainventario.MostrarInventario(TABLA);
        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtCantSuma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtVende_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }
    }
    
}
