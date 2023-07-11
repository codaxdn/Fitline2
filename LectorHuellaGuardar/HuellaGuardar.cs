﻿using System;
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
using FitLine;

namespace Demo
{
    public partial class HuellaGuardar : Form
    {

        FitLine.utils.GlobalCachingProvider objCache = FitLine.utils.GlobalCachingProvider.Instance;
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

        public HuellaGuardar()
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
                    MessageBox.Show("Ningún dispositivo conectado!");
                }
            }
            else
            {
                MessageBox.Show("Initialize fail, ret=" + ret + " !");
            }
            ret = zkfp.ZKFP_ERR_OK;
            if (IntPtr.Zero == (mDevHandle = zkfp2.OpenDevice(cmbIdx.SelectedIndex)))
            {
                MessageBox.Show("ERROR AL ABRIR");
                return;
            }
            if (IntPtr.Zero == (mDBHandle = zkfp2.DBInit()))
            {
                MessageBox.Show("ERROR AL INICIAR");
                zkfp2.CloseDevice(mDevHandle);
                mDevHandle = IntPtr.Zero;
                return;
            }
            bnInit.Enabled = false;
            bnFree.Enabled = true;
            //bnOpen.Enabled = false;
            bnClose.Enabled = true;
            bnEnroll.Enabled = true;
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
            textRes.Text = "ABRIO CON EXITO";
        }

        private void bnFree_Click(object sender, EventArgs e)
        {
            zkfp2.Terminate();
            cbRegTmp = 0;
            bnInit.Enabled = true;
            bnFree.Enabled = false;
            //bnOpen.Enabled = false;
            bnClose.Enabled = false;
            bnEnroll.Enabled = false;
            //bnVerify.Enabled = false;
            //bnIdentify.Enabled = false;
        }

        private void bnOpen_Click(object sender, EventArgs e)
        {
            int ret = zkfp.ZKFP_ERR_OK;
            if (IntPtr.Zero == (mDevHandle = zkfp2.OpenDevice(cmbIdx.SelectedIndex)))
            {
                MessageBox.Show("ERROR AL ABRIR");
                return;
            }
            if (IntPtr.Zero == (mDBHandle = zkfp2.DBInit()))
            {
                MessageBox.Show("ERROR AL INICIAR LA BASE DE DATOS");
                zkfp2.CloseDevice(mDevHandle);
                mDevHandle = IntPtr.Zero;
                return;
            }
            bnInit.Enabled = false;
            bnFree.Enabled = true;
            //bnOpen.Enabled = false;
            bnClose.Enabled = true;
            bnEnroll.Enabled = true;
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
            textRes.Text = "ABRIO CON EXITO";

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
                                textRes.Text = "Este dedo ya fue registrado por " + fid + "!";
                                return;
                            }
                            if (RegisterCount > 0 && zkfp2.DBMatch(mDBHandle, CapTmp, RegTmps[RegisterCount - 1]) <= 0)
                            {
                                textRes.Text = "Presione el mismo dedo 3 veces para la inscripción";
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
                                    textRes.Text = "EL REGISTRO GUARDO CON EXITO";

                                    //Guardar en cache dato de la huella
                                    objCache.RemoveItem("huella");
                                    objCache.AddItem("huella", strBase64);
                                    RegistroUsuarios x = new RegistroUsuarios();
                                    x.SetHuella("CARGADA");
                                }
                                else
                                {
                                    //Guardar en cache dato de la huella
                                    objCache.RemoveItem("huella");
                                    objCache.AddItem("huella", strBase64);
                                    RegistroUsuarios x = new RegistroUsuarios();
                                    x.SetHuella("CARGADA");
                                    textRes.Text = "EL REGISTRO GUARDO CON EXITO";
                                }
                                IsRegister = false;
                                return;
                            }
                            else
                            {
                                textRes.Text = "Necesitas presionar el DEDO " + (REGISTER_FINGER_COUNT - RegisterCount) + " VECES";
                            }
                        }
                        else
                        {
                            if (cbRegTmp <= 0)
                            {
                                textRes.Text = "Primero registre su dedo!";
                                return;
                            }
                            if (bIdentify)
                            {
                                int ret = zkfp.ZKFP_ERR_OK;
                                int fid = 0, score = 0;
                                ret = zkfp2.DBIdentify(mDBHandle, CapTmp, ref fid, ref score);
                                if (zkfp.ZKFP_ERR_OK == ret)
                                {
                                    textRes.Text = "Se identifico con exito= " + fid + ",score=" + score + "!";
                                    return;
                                }
                                else
                                {
                                    textRes.Text = "ERROR AL IDENTICAR, SCORE= " + ret;
                                    return;
                                }
                            }
                            else
                            {
                                int ret = zkfp2.DBMatch(mDBHandle, CapTmp, RegTmp);
                                if (0 < ret)
                                {
                                    textRes.Text = "Match finger succ, score=" + ret + "!";
                                    return;
                                }
                                else
                                {
                                    textRes.Text = "Match finger fail, ret= " + ret;
                                    return;
                                }
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
            bnEnroll.Enabled = false;
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
            bnEnroll.Enabled = false;
            //bnVerify.Enabled = false;
            //bnIdentify.Enabled = false;

            zkfp2.Terminate();
            cbRegTmp = 0;
            bnInit.Enabled = true;
            bnFree.Enabled = false;
            //bnOpen.Enabled = false;
            bnClose.Enabled = false;
            bnEnroll.Enabled = false;
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
