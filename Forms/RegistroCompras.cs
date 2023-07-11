using FitLine.ClassModules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitLine.Forms
{
    public partial class RegistroCompras : Form
    {
        public RegistroCompras()
        {
            InitializeComponent();
            clsMostrarCompras mostrar = new clsMostrarCompras();
            mostrar.Tabla(TABLA);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Inicio regresar = new Inicio();
            regresar.Show();
            this.Close();
        }

        private void RegistroCompras_Load(object sender, EventArgs e)
        {
            AgregarEstado();


        }
        void AgregarEstado()
        {

            CmbFiltro.Items.Add("Dia");
            CmbFiltro.Items.Add("Semana");
            CmbFiltro.Items.Add("Mes");
            
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            String filtro = CmbFiltro.Text;
            clsMostrarCompras mostrar = new clsMostrarCompras();
            mostrar.Cargar(filtro, TABLA);
        }

        private void TxtAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void BtnFiltroFecha_Click(object sender, EventArgs e)
        {
            String Año = TxtAño.Text;
            if (Año.Length == 2 )
            {
                Año = ("20" + Año);
            }else if (Año.Length == 1)
            {
                Año = ("202" + Año);
            }
            String mes = TxtMes.Text;
            String dia = TxtDia.Text;
            String fecha = (Año + "-" + mes + "-" + dia);
            if (Año.Equals("") || mes.Equals("") || dia.Equals(""))
            {
                MessageBox.Show("DEBES LLENAR TODOS LOS DATOS");
            }
            else
            {

                clsMostrarCompras cargar = new clsMostrarCompras();
                cargar.NuevoFiltro(fecha, TABLA);
            }


        }
    }
}
