using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using libzkfpcsharp;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using Sample;
using MySql.Data.MySqlClient;
using FitLine.ClassModules;

namespace Demo
{
    public partial class EntradaHuella : Form
    {
        IntPtr mDevHandle = IntPtr.Zero;
        IntPtr mDBHandle = IntPtr.Zero;
        IntPtr FormHandle = IntPtr.Zero;
        bool bIsTimeToDie = false;
        bool IsRegister = false;
        bool bIdentify = true;
        byte[] FPBuffer;
        int RegisterCount = 0;
        const int REGISTER_FINGER_COUNT = 3;

        byte[][] RegTmps = new byte[3][];
        byte[] RegTmp = new byte[2048];
        byte[] CapTmp = new byte[2048];
        int cbCapTmp = 2048;
        int cbRegTmp = 0;
        int iFid = 1;

        private int mfpWidth = 0;
        private int mfpHeight = 0;

        const int MESSAGE_CAPTURED_OK = 0x0400 + 6;

        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        public EntradaHuella()
        {
            InitializeComponent();
        }

        private void bnInit_Click(object sender, EventArgs e)
        {
            cmbIdx.Items.Clear();
            int ret = zkfperrdef.ZKFP_ERR_OK;
            if ((ret = zkfp2.Init()) == zkfperrdef.ZKFP_ERR_OK)
            {
                int nCount = zkfp2.GetDeviceCount();
                if (nCount > 0)
                {
                    for (int i = 0; i < nCount; i++)
                    {
                        cmbIdx.Items.Add(i.ToString());
                    }
                    cmbIdx.SelectedIndex = 0;
                    bnInit.Enabled = false;
                    bnFree.Enabled = true;
                    //bnOpen.Enabled = true;
                }
                else
                {
                    zkfp2.Terminate();
                    MessageBox.Show("No device connected!");
                }
            }
            else
            {
                MessageBox.Show("Initialize fail, ret=" + ret + " !");
            }
            ret = zkfp.ZKFP_ERR_OK;
            if (IntPtr.Zero == (mDevHandle = zkfp2.OpenDevice(cmbIdx.SelectedIndex)))
            {
                MessageBox.Show("OpenDevice fail");
                return;
            }
            if (IntPtr.Zero == (mDBHandle = zkfp2.DBInit()))
            {
                MessageBox.Show("Init DB fail");
                zkfp2.CloseDevice(mDevHandle);
                mDevHandle = IntPtr.Zero;
                return;
            }
            bnInit.Enabled = false;
            bnFree.Enabled = true;
            //bnOpen.Enabled = false;
            bnClose.Enabled = true;
            //bnEnroll.Enabled = true;
            //bnVerify.Enabled = true;
            //bnIdentify.Enabled = true;
            RegisterCount = 0;
            cbRegTmp = 0;
            iFid = 1;
            for (int i = 0; i < 3; i++)
            {
                RegTmps[i] = new byte[2048];
            }
            byte[] paramValue = new byte[4];
            int size = 4;
            zkfp2.GetParameters(mDevHandle, 1, paramValue, ref size);
            zkfp2.ByteArray2Int(paramValue, ref mfpWidth);

            size = 4;
            zkfp2.GetParameters(mDevHandle, 2, paramValue, ref size);
            zkfp2.ByteArray2Int(paramValue, ref mfpHeight);

            FPBuffer = new byte[mfpWidth * mfpHeight];

            Thread captureThread = new Thread(new ThreadStart(DoCapture));
            captureThread.IsBackground = true;
            captureThread.Start();
            bIsTimeToDie = false;
            textRes.Text = "Open succ";


            ////*****/////

            if (bIdentify)
            {
                bIdentify = false;
                textRes.Text = "Please press your finger!";
            }

        }

        private void bnFree_Click(object sender, EventArgs e)
        {
            zkfp2.Terminate();
            cbRegTmp = 0;
            bnInit.Enabled = true;
            bnFree.Enabled = false;
            //bnOpen.Enabled = false;
            bnClose.Enabled = false;
            //bnEnroll.Enabled = false;
            //bnVerify.Enabled = false;
            //bnIdentify.Enabled = false;
        }

        private void bnOpen_Click(object sender, EventArgs e)
        {
            int ret = zkfp.ZKFP_ERR_OK;
            if (IntPtr.Zero == (mDevHandle = zkfp2.OpenDevice(cmbIdx.SelectedIndex)))
            {
                MessageBox.Show("OpenDevice fail");
                return;
            }
            if (IntPtr.Zero == (mDBHandle = zkfp2.DBInit()))
            {
                MessageBox.Show("Init DB fail");
                zkfp2.CloseDevice(mDevHandle);
                mDevHandle = IntPtr.Zero;
                return;
            }
            bnInit.Enabled = false;
            bnFree.Enabled = true;
            //bnOpen.Enabled = false;
            bnClose.Enabled = true;
            //bnEnroll.Enabled = true;
            //bnVerify.Enabled = true;
            //bnIdentify.Enabled = true;
            RegisterCount = 0;
            cbRegTmp = 0;
            iFid = 1;
            for (int i = 0; i < 3; i++)
            {
                RegTmps[i] = new byte[2048];
            }
            byte[] paramValue = new byte[4];
            int size = 4;
            zkfp2.GetParameters(mDevHandle, 1, paramValue, ref size);
            zkfp2.ByteArray2Int(paramValue, ref mfpWidth);

            size = 4;
            zkfp2.GetParameters(mDevHandle, 2, paramValue, ref size);
            zkfp2.ByteArray2Int(paramValue, ref mfpHeight);

            FPBuffer = new byte[mfpWidth*mfpHeight];

            Thread captureThread = new Thread(new ThreadStart(DoCapture));
            captureThread.IsBackground = true;
            captureThread.Start();
            bIsTimeToDie = false;
            textRes.Text = "ABRIO DE FORMA EXITOSA";

        }


        private void DoCapture()
        {
            while (!bIsTimeToDie)
            {
                cbCapTmp = 2048;
                int ret = zkfp2.AcquireFingerprint(mDevHandle, FPBuffer, CapTmp, ref cbCapTmp);
                if (ret == zkfp.ZKFP_ERR_OK)
                {
                    SendMessage(FormHandle, MESSAGE_CAPTURED_OK, IntPtr.Zero, IntPtr.Zero);
                }
                Thread.Sleep(200);
            }
        }

        protected override void DefWndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case MESSAGE_CAPTURED_OK:
                    {
                        MemoryStream ms = new MemoryStream();
                        BitmapFormat.GetBitmap(FPBuffer, mfpWidth, mfpHeight, ref ms);
                        Bitmap bmp = new Bitmap(ms);
                        this.picFPImg.Image = bmp;
                        if (IsRegister)
                        {
                            int ret = zkfp.ZKFP_ERR_OK;
                            int fid = 0, score = 0;
                            ret = zkfp2.DBIdentify(mDBHandle, CapTmp, ref fid, ref score);
                            if (zkfp.ZKFP_ERR_OK == ret)
                            {
                                textRes.Text = "This finger was already register by " + fid + "!";
                                return;
                            }
                            if (RegisterCount > 0 && zkfp2.DBMatch(mDBHandle, CapTmp, RegTmps[RegisterCount - 1]) <= 0)
                            {
                                textRes.Text = "Please press the same finger 3 times for the enrollment";
                                return;
                            }
                            Array.Copy(CapTmp, RegTmps[RegisterCount], cbCapTmp);
                            String strBase64 = zkfp2.BlobToBase64(CapTmp, cbCapTmp);
                            byte[] blob = zkfp2.Base64ToBlob(strBase64);
                            RegisterCount++;
                            if (RegisterCount >= REGISTER_FINGER_COUNT)
                            {
                                RegisterCount = 0;
                                if (zkfp.ZKFP_ERR_OK == (ret = zkfp2.DBMerge(mDBHandle, RegTmps[0], RegTmps[1], RegTmps[2], RegTmp, ref cbRegTmp)) &&
                                       zkfp.ZKFP_ERR_OK == (ret = zkfp2.DBAdd(mDBHandle, iFid, RegTmp)))
                                {
                                    iFid++;
                                    textRes.Text = "enroll succ";
                                }
                                else
                                {
                                    textRes.Text = "enroll fail, error code=" + ret;
                                }
                                IsRegister = false;
                                return;
                            }
                            else
                            {
                                textRes.Text = "You need to press the " + (REGISTER_FINGER_COUNT - RegisterCount) + " times fingerprint";
                            }
                        }
                        else
                        {
                            //if (cbRegTmp <= 0)
                            //{
                            //    textRes.Text = "Please register your finger first!";
                            //    return;
                            //}
                            if (bIdentify)
                            {
                                int ret = zkfp.ZKFP_ERR_OK;
                                int fid = 0, score = 0;
                                ret = zkfp2.DBIdentify(mDBHandle, CapTmp, ref fid, ref score);
                                if (zkfp.ZKFP_ERR_OK == ret)
                                {
                                    textRes.Text = "Identify succ, fid= " + fid + ",score=" + score + "!";
                                    return;
                                }
                                else
                                {
                                    textRes.Text = "Identify fail, ret= " + ret;
                                    return;
                                }
                            }
                            else
                            {

                                DateTime hoy = DateTime.Now;
                                String hoyy = (hoy.Year.ToString() + "-" + hoy.Month.ToString() + "-" + hoy.Day.ToString());

                                String sql = "select * from clientes";
                                CConexion con = new CConexion();
                                MySqlCommand comando = new MySqlCommand(sql, con.establecerConexion());
                                MySqlDataReader reader1 = comando.ExecuteReader();
                                int ret = 0;
                                String nombre = "";
                                String Cedula = "";

                                while (reader1.Read())
                                {
                                    String x = Convert.ToString(reader1["HUELLA"]);

                                    byte[] b = new byte[2048];
                                    b = Convert.FromBase64String(x);
                                    ret = zkfp2.DBMatch(mDBHandle, CapTmp, b);
                                    if (ret >= 70)
                                    {
                                        nombre = Convert.ToString(reader1["NOMBRE"]);
                                        Cedula = Convert.ToString(reader1["CEDULA"]);
                                        break;
                                    }

                                }

                                String CantClases = "";
                                String idPersona = "";
                                sql = "SELECT COUNT(CEDULA_CLIENTE) FROM asistencia WHERE Date(ASISTENCIA) = '" + hoyy + "' AND CEDULA_CLIENTE = '" + Cedula + "'";
                                comando = new MySqlCommand(sql, con.establecerConexion());
                                reader1 = comando.ExecuteReader();
                                String num = "";
                                while (reader1.Read())
                                {
                                    num = Convert.ToString(reader1["COUNT(CEDULA_CLIENTE)"]);
                                }

                                sql = "SELECT COUNT(CEDULA_CLIENTE) FROM salida WHERE Date(SALIDA) = '" + hoyy + "' AND CEDULA_CLIENTE = '" + Cedula + "'";
                                comando = new MySqlCommand(sql, con.establecerConexion());
                                reader1 = comando.ExecuteReader();
                                String NUM2 = "";
                                while (reader1.Read())
                                {
                                    NUM2 = Convert.ToString(reader1["COUNT(CEDULA_CLIENTE)"]);
                                }
                                int evalaluar = int.Parse(num) - int.Parse(NUM2);
                                


                                comando = new MySqlCommand(sql, con.establecerConexion());
                                reader1 = comando.ExecuteReader();

                                



                                if (evalaluar == 0)
                                {
                                    sql = "SELECT * FROM compra_paquetes WHere CED_CLIENTE = '" + Cedula + "' AND FECHA_FIN >= '" + hoyy + "' AND CLASES > '0'";
                                    comando = new MySqlCommand(sql, con.establecerConexion());
                                    reader1 = comando.ExecuteReader();
                                    int count = 0;
                                    DateTime FechaFin = DateTime.Now;
                                    if (reader1.Read())
                                    {
                                        count = 1;
                                        idPersona = Convert.ToString(reader1["ID"]);
                                        CantClases = Convert.ToString(reader1["CLASES"]);
                                        FechaFin = Convert.ToDateTime(reader1["Fecha_Fin"]);
                                    }

                                    if (count == 0)
                                    {
                                        MessageBox.Show("EL USUARIO NO ESTA REGISTRADO O NO CUENTA CON CLASES DISPONIBLES");
                                    }
                                    else
                                    {
                                        DateTime z = DateTime.Now;
                                        String zz = (z.Year.ToString() + "-" + z.Month.ToString() + "-" + z.Day.ToString() + " " + z.Hour.ToString() + "-" + z.Minute.ToString() + "-" + z.Second.ToString());
                                        int ClasesFinales = int.Parse(CantClases) - 1;

                                        if (hoy.Year.ToString() == FechaFin.Year.ToString())
                                        {
                                            if (hoy.Month.ToString() == FechaFin.Month.ToString())
                                            {
                                                int v = hoy.Day;
                                                int w = FechaFin.Day;
                                                int a = w - v;
                                                if (a <= 3)
                                                {
                                                    MessageBox.Show("ALERTA, SOLO TE QUEDAN " + a + " DIAS");
                                                }
                                            }
                                        }
                                        else if (ClasesFinales <= 5)
                                        {
                                            MessageBox.Show("ALERTA, SOLO TE QUEDAN " + ClasesFinales + " CLASES");
                                        }

                                        MessageBox.Show("PUEDES INGRESAR " + nombre + " Te quedan " + ClasesFinales + " Clases");
                                        sql = "UPDATE compra_paquetes SET CLASES = '" + ClasesFinales + "' WHERE ID = '" + idPersona + "'";
                                        comando = new MySqlCommand(sql, con.establecerConexion());
                                        reader1 = comando.ExecuteReader();
                                        while (reader1.Read()) { }
                                        sql = "INSERT INTO asistencia(CEDULA_CLIENTE, ASISTENCIA)"
                                             + "VALUES('" + Cedula + "','" + zz + "')";
                                        comando = new MySqlCommand(sql, con.establecerConexion());
                                        reader1 = comando.ExecuteReader();
                                        while (reader1.Read()) { }
                                        clsInicio puerta = new clsInicio();
                                        puerta.arduino();

                                    }
                                }
                                else
                                {
                                    DateTime z = DateTime.Now;
                                    String zz = (z.Year.ToString() + "-" + z.Month.ToString() + "-" + z.Day.ToString() + " " + z.Hour.ToString() + "-" + z.Minute.ToString() + "-" + z.Second.ToString());
                                    MessageBox.Show("HASTA LUEGO " + nombre);

                                    sql = "INSERT INTO salida(CEDULA_CLIENTE, SALIDA)"
                                             + "VALUES('" + Cedula + "','" + zz + "')";
                                    comando = new MySqlCommand(sql, con.establecerConexion());
                                    reader1 = comando.ExecuteReader();
                                    while (reader1.Read()) { }

                                    clsInicio puerta = new clsInicio();
                                    puerta.arduino();



                                }

                                con.CerrarConexion();






                            }

                        }
                    }
                    break;

                default:
                    base.DefWndProc(ref m);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormHandle = this.Handle;
        }

        private void bnClose_Click(object sender, EventArgs e)
        {
            bIsTimeToDie = true;
            RegisterCount = 0;
            Thread.Sleep(1000);
            zkfp2.CloseDevice(mDevHandle);
            bnInit.Enabled = false;
            bnFree.Enabled = true;
            //bnOpen.Enabled = true;
            bnClose.Enabled = false;
            //bnEnroll.Enabled = false;
            //bnVerify.Enabled = false;
            //bnIdentify.Enabled = false;
        }

        private void bnEnroll_Click(object sender, EventArgs e)
        {
            if (!IsRegister)
            {
                IsRegister = true;
                RegisterCount = 0;
                cbRegTmp = 0;
                textRes.Text = "Please press your finger 3 times!";
            }
        }

        private void bnIdentify_Click(object sender, EventArgs e)
        {
            if (!bIdentify)
            {
                bIdentify = true;
                textRes.Text = "Please press your finger!";
            }
        }

        private void bnVerify_Click(object sender, EventArgs e)
        {
            if (bIdentify)
            {
                bIdentify = false;
                textRes.Text = "Please press your finger!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bIsTimeToDie = true;
            RegisterCount = 0;
            Thread.Sleep(1000);
            zkfp2.CloseDevice(mDevHandle);
            bnInit.Enabled = false;
            bnFree.Enabled = true;
            //bnOpen.Enabled = true;
            bnClose.Enabled = false;
            //bnEnroll.Enabled = false;
            //bnVerify.Enabled = false;
            //bnIdentify.Enabled = false;

            zkfp2.Terminate();
            cbRegTmp = 0;
            bnInit.Enabled = true;
            bnFree.Enabled = false;
            //bnOpen.Enabled = false;
            bnClose.Enabled = false;
            //bnEnroll.Enabled = false;
            //bnVerify.Enabled = false;
            //bnIdentify.Enabled = false;

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
