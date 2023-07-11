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
    public partial class HistorialAsistencia : Form
    {
        public HistorialAsistencia()
        {
            InitializeComponent();
            clsAsistenciaCliente cargar = new clsAsistenciaCliente();
            cargar.Tabla(TABLA);
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Inicio abrir = new Inicio();
            abrir.Show();
            this.Close();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            clsAsistenciaCliente cargar = new clsAsistenciaCliente();
            String X = TxtCedula.Text;
            cargar.filtrar(TABLA, X);

        }

        private void HistorialAsistencia_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HistrialSalidaCliente abrir = new HistrialSalidaCliente();
            abrir.Show();
            this.Close();
        }
    }
}
