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
    public partial class HistrialSalidaCliente : Form
    {
        public HistrialSalidaCliente()
        {
            InitializeComponent();
            clsAsistenciaCliente cargar = new clsAsistenciaCliente();
            cargar.TablaSalida(TABLA);
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            HistorialAsistencia abrir = new HistorialAsistencia();
            abrir.Show();
            this.Close();
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            clsAsistenciaCliente cargar = new clsAsistenciaCliente();
            String X = TxtCedula.Text;
            cargar.filtrarSalida(TABLA, X);
        }
    }
}
