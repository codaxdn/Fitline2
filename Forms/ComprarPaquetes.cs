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
    public partial class ComprarPaquetes : Form
    {
        public ComprarPaquetes()
        {
            InitializeComponent();
        }

        private void ComprarPaquetes_Load(object sender, EventArgs e)
        {
            clsComprarPaquetes comprarPaque = new clsComprarPaquetes();
            comprarPaque.CargarPaquetes(CmbPaquetes);
            comprarPaque.CargarTiquetes(CmbTiquetes);
            comprarPaque.CargarTabla(TABLA);
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Inicio abrir = new Inicio();
            abrir.Show();
            this.Close();
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47 )||(e.KeyChar >=58 && e.KeyChar <= 255))
            {
                e.Handled= true;
                return;
            }
        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            String cedula = TxtCedula.Text;
            String paquetes = CmbPaquetes.Text;
            String tiquetes = CmbTiquetes.Text;
            clsComprarPaquetes comprarPaquetesTiquetes= new clsComprarPaquetes();
            comprarPaquetesTiquetes.ComprarPaquetesTiquetes(cedula, paquetes, tiquetes);
            comprarPaquetesTiquetes.CargarTabla(TABLA);
        }

        private void TxtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void BtnFiltro_Click(object sender, EventArgs e)
        {
            String Filtro = TxtFiltro.Text;
            clsComprarPaquetes comprarPaquetesTiquetes = new clsComprarPaquetes();
            comprarPaquetesTiquetes.Filtrar(TABLA, Filtro);
        }
    }
}
