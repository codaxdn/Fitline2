using Demo;
using FitLine.ClassModules;
using FitLine.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitLine
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarPaquetes abrir = new AgregarPaquetes();
            abrir.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarTiquetes abrir = new AgregarTiquetes();
            abrir.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistroUsuarios abrir = new RegistroUsuarios();
            abrir.Show();
            this.Close();
        }

        private void INICIO_Load(object sender, EventArgs e)
        {
            ClassModules.clsInicio inicio = new ClassModules.clsInicio();
            inicio.ingresos(label4);
            inicio.ingresos2(label5);
            inicio.dia(label6);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            AgregarInventario abrir = new AgregarInventario();
            abrir.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ComprarPaquetes abrir = new ComprarPaquetes();
            abrir.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegistroCompras compras = new RegistroCompras();
            compras.Show();
            this.Close();




        }

        private void BtnEntradaPer_Click(object sender, EventArgs e)
        {
            EntradaHuella ingresar = new EntradaHuella();
            ingresar.Show();
        }

        private void BtnAsistencia_Click(object sender, EventArgs e)
        {
            HistorialAsistencia abrir = new HistorialAsistencia();
            abrir.Show();
            this.Close();



        }


        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            String x = TxtFiltro.Text;
            ClassModules.clsInicio buscar = new ClassModules.clsInicio();
            buscar.ingresar(x);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.IO.Ports.SerialPort Arduino;
            Arduino = new System.IO.Ports.SerialPort();
            Arduino.PortName = "COM5";
            Arduino.BaudRate = 9600;
            Arduino.Open();
            Arduino.Write("E");
            var stopwatch = Stopwatch.StartNew();
            Thread.Sleep(2000); //tiempo de pausa
            stopwatch.Stop();
            Arduino.Write("F");
            Arduino.Close();

        }
    }
}
