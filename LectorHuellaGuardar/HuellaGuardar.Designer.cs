namespace Demo
{
    partial class HuellaGuardar
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.bnInit = new System.Windows.Forms.Button();
            this.bnEnroll = new System.Windows.Forms.Button();
            this.bnFree = new System.Windows.Forms.Button();
            this.bnClose = new System.Windows.Forms.Button();
            this.textRes = new System.Windows.Forms.TextBox();
            this.picFPImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIdx = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFPImg)).BeginInit();
            this.SuspendLayout();
            // 
            // bnInit
            // 
            this.bnInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnInit.Location = new System.Drawing.Point(29, 65);
            this.bnInit.Name = "bnInit";
            this.bnInit.Size = new System.Drawing.Size(75, 25);
            this.bnInit.TabIndex = 0;
            this.bnInit.Text = "INICIAR";
            this.bnInit.UseVisualStyleBackColor = true;
            this.bnInit.Click += new System.EventHandler(this.bnInit_Click);
            // 
            // bnEnroll
            // 
            this.bnEnroll.Enabled = false;
            this.bnEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnEnroll.Location = new System.Drawing.Point(29, 113);
            this.bnEnroll.Name = "bnEnroll";
            this.bnEnroll.Size = new System.Drawing.Size(75, 25);
            this.bnEnroll.TabIndex = 2;
            this.bnEnroll.Text = "GUARDAR HUELLA";
            this.bnEnroll.UseVisualStyleBackColor = true;
            this.bnEnroll.Click += new System.EventHandler(this.bnEnroll_Click);
            // 
            // bnFree
            // 
            this.bnFree.Enabled = false;
            this.bnFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnFree.Location = new System.Drawing.Point(132, 65);
            this.bnFree.Name = "bnFree";
            this.bnFree.Size = new System.Drawing.Size(75, 25);
            this.bnFree.TabIndex = 4;
            this.bnFree.Text = "FINALIZAR";
            this.bnFree.UseVisualStyleBackColor = true;
            this.bnFree.Click += new System.EventHandler(this.bnFree_Click);
            // 
            // bnClose
            // 
            this.bnClose.Enabled = false;
            this.bnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnClose.Location = new System.Drawing.Point(132, 113);
            this.bnClose.Name = "bnClose";
            this.bnClose.Size = new System.Drawing.Size(75, 25);
            this.bnClose.TabIndex = 5;
            this.bnClose.Text = "CERRAR";
            this.bnClose.UseVisualStyleBackColor = true;
            this.bnClose.Click += new System.EventHandler(this.bnClose_Click);
            // 
            // textRes
            // 
            this.textRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRes.Location = new System.Drawing.Point(3, 236);
            this.textRes.Multiline = true;
            this.textRes.Name = "textRes";
            this.textRes.ReadOnly = true;
            this.textRes.Size = new System.Drawing.Size(451, 124);
            this.textRes.TabIndex = 7;
            // 
            // picFPImg
            // 
            this.picFPImg.Location = new System.Drawing.Point(312, 49);
            this.picFPImg.Name = "picFPImg";
            this.picFPImg.Size = new System.Drawing.Size(131, 174);
            this.picFPImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFPImg.TabIndex = 8;
            this.picFPImg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Index:";
            // 
            // cmbIdx
            // 
            this.cmbIdx.FormattingEnabled = true;
            this.cmbIdx.Location = new System.Drawing.Point(250, 67);
            this.cmbIdx.Name = "cmbIdx";
            this.cmbIdx.Size = new System.Drawing.Size(40, 21);
            this.cmbIdx.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(420, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(380, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // HuellaGuardar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 365);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbIdx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picFPImg);
            this.Controls.Add(this.textRes);
            this.Controls.Add(this.bnClose);
            this.Controls.Add(this.bnFree);
            this.Controls.Add(this.bnEnroll);
            this.Controls.Add(this.bnInit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "HuellaGuardar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUARDAR HUELLA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFPImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnInit;
        private System.Windows.Forms.Button bnEnroll;
        private System.Windows.Forms.Button bnFree;
        private System.Windows.Forms.Button bnClose;
        private System.Windows.Forms.TextBox textRes;
        private System.Windows.Forms.PictureBox picFPImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIdx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

