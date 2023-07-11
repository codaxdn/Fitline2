namespace FitLine.Forms
{
    partial class RegistroCompras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroCompras));
            this.BtnSalir = new System.Windows.Forms.Button();
            this.TABLA = new System.Windows.Forms.DataGridView();
            this.CmbFiltro = new System.Windows.Forms.ComboBox();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnFiltroFecha = new System.Windows.Forms.Button();
            this.TxtAño = new System.Windows.Forms.TextBox();
            this.TxtMes = new System.Windows.Forms.TextBox();
            this.TxtDia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TABLA)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(225, 516);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 20;
            this.BtnSalir.Text = "REGRESAR";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TABLA
            // 
            this.TABLA.AllowUserToOrderColumns = true;
            this.TABLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLA.Location = new System.Drawing.Point(32, 25);
            this.TABLA.Name = "TABLA";
            this.TABLA.RowHeadersWidth = 51;
            this.TABLA.Size = new System.Drawing.Size(536, 470);
            this.TABLA.TabIndex = 21;
            // 
            // CmbFiltro
            // 
            this.CmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFiltro.FormattingEnabled = true;
            this.CmbFiltro.Location = new System.Drawing.Point(18, 49);
            this.CmbFiltro.Name = "CmbFiltro";
            this.CmbFiltro.Size = new System.Drawing.Size(121, 21);
            this.CmbFiltro.TabIndex = 22;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltrar.Location = new System.Drawing.Point(145, 47);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltrar.TabIndex = 23;
            this.BtnFiltrar.Text = "FILTRAR";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CmbFiltro);
            this.panel1.Controls.Add(this.BtnFiltrar);
            this.panel1.Location = new System.Drawing.Point(621, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 95);
            this.panel1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "FILTRO GENERAL";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TxtDia);
            this.panel2.Controls.Add(this.TxtMes);
            this.panel2.Controls.Add(this.TxtAño);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BtnFiltroFecha);
            this.panel2.Location = new System.Drawing.Point(621, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 133);
            this.panel2.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "FILTRO POR FECHA";
            // 
            // BtnFiltroFecha
            // 
            this.BtnFiltroFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltroFecha.Location = new System.Drawing.Point(84, 100);
            this.BtnFiltroFecha.Name = "BtnFiltroFecha";
            this.BtnFiltroFecha.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltroFecha.TabIndex = 23;
            this.BtnFiltroFecha.Text = "FILTRAR";
            this.BtnFiltroFecha.UseVisualStyleBackColor = true;
            this.BtnFiltroFecha.Click += new System.EventHandler(this.BtnFiltroFecha_Click);
            // 
            // TxtAño
            // 
            this.TxtAño.Location = new System.Drawing.Point(32, 62);
            this.TxtAño.Name = "TxtAño";
            this.TxtAño.Size = new System.Drawing.Size(48, 20);
            this.TxtAño.TabIndex = 25;
            this.TxtAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAño_KeyPress);
            // 
            // TxtMes
            // 
            this.TxtMes.Location = new System.Drawing.Point(100, 62);
            this.TxtMes.Name = "TxtMes";
            this.TxtMes.Size = new System.Drawing.Size(48, 20);
            this.TxtMes.TabIndex = 26;
            this.TxtMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMes_KeyPress);
            // 
            // TxtDia
            // 
            this.TxtDia.Location = new System.Drawing.Point(172, 62);
            this.TxtDia.Name = "TxtDia";
            this.TxtDia.Size = new System.Drawing.Size(48, 20);
            this.TxtDia.TabIndex = 27;
            this.TxtDia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDia_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "AÑO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "MES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "DIA";
            // 
            // RegistroCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(958, 563);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TABLA);
            this.Controls.Add(this.BtnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegistroCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroCompras";
            this.Load += new System.EventHandler(this.RegistroCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TABLA)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridView TABLA;
        private System.Windows.Forms.ComboBox CmbFiltro;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDia;
        private System.Windows.Forms.TextBox TxtMes;
        private System.Windows.Forms.TextBox TxtAño;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnFiltroFecha;
    }
}