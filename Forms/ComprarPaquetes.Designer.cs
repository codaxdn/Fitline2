namespace FitLine.Forms
{
    partial class ComprarPaquetes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComprarPaquetes));
            this.CmbPaquetes = new System.Windows.Forms.ComboBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.CmbTiquetes = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnComprar = new System.Windows.Forms.Button();
            this.CEDULA = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.TABLA = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            this.BtnFiltro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TABLA)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmbPaquetes
            // 
            this.CmbPaquetes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPaquetes.FormattingEnabled = true;
            this.CmbPaquetes.Location = new System.Drawing.Point(215, 64);
            this.CmbPaquetes.Margin = new System.Windows.Forms.Padding(2);
            this.CmbPaquetes.Name = "CmbPaquetes";
            this.CmbPaquetes.Size = new System.Drawing.Size(105, 21);
            this.CmbPaquetes.TabIndex = 0;
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.Location = new System.Drawing.Point(278, 503);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(78, 19);
            this.BtnRegresar.TabIndex = 1;
            this.BtnRegresar.Text = "REGRESAR";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // CmbTiquetes
            // 
            this.CmbTiquetes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTiquetes.FormattingEnabled = true;
            this.CmbTiquetes.Location = new System.Drawing.Point(215, 105);
            this.CmbTiquetes.Margin = new System.Windows.Forms.Padding(2);
            this.CmbTiquetes.Name = "CmbTiquetes";
            this.CmbTiquetes.Size = new System.Drawing.Size(105, 21);
            this.CmbTiquetes.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnComprar);
            this.panel1.Controls.Add(this.CEDULA);
            this.panel1.Controls.Add(this.TxtCedula);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.A);
            this.panel1.Controls.Add(this.CmbTiquetes);
            this.panel1.Controls.Add(this.CmbPaquetes);
            this.panel1.Location = new System.Drawing.Point(987, 56);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 186);
            this.panel1.TabIndex = 3;
            // 
            // BtnComprar
            // 
            this.BtnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComprar.Location = new System.Drawing.Point(85, 148);
            this.BtnComprar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnComprar.Name = "BtnComprar";
            this.BtnComprar.Size = new System.Drawing.Size(161, 19);
            this.BtnComprar.TabIndex = 6;
            this.BtnComprar.Text = "REALIZAR COMPRA";
            this.BtnComprar.UseVisualStyleBackColor = true;
            this.BtnComprar.Click += new System.EventHandler(this.BtnComprar_Click);
            // 
            // CEDULA
            // 
            this.CEDULA.AutoSize = true;
            this.CEDULA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEDULA.Location = new System.Drawing.Point(16, 26);
            this.CEDULA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CEDULA.Name = "CEDULA";
            this.CEDULA.Size = new System.Drawing.Size(67, 16);
            this.CEDULA.TabIndex = 5;
            this.CEDULA.Text = "CEDULA";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(215, 25);
            this.TxtCedula.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(105, 20);
            this.TxtCedula.TabIndex = 4;
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "SELECCIONAR TIQUETE";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.Location = new System.Drawing.Point(16, 63);
            this.A.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(188, 16);
            this.A.TabIndex = 1;
            this.A.Text = "SELECCIONAR PAQUETE";
            // 
            // TABLA
            // 
            this.TABLA.AllowUserToOrderColumns = true;
            this.TABLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLA.Location = new System.Drawing.Point(39, 32);
            this.TABLA.Name = "TABLA";
            this.TABLA.RowHeadersWidth = 51;
            this.TABLA.Size = new System.Drawing.Size(943, 440);
            this.TABLA.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnFiltro);
            this.panel2.Controls.Add(this.TxtFiltro);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(987, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 116);
            this.panel2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "FILTRAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "CEDULA";
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.Location = new System.Drawing.Point(179, 46);
            this.TxtFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(105, 20);
            this.TxtFiltro.TabIndex = 7;
            this.TxtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFiltro_KeyPress);
            // 
            // BtnFiltro
            // 
            this.BtnFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltro.Location = new System.Drawing.Point(85, 83);
            this.BtnFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.BtnFiltro.Name = "BtnFiltro";
            this.BtnFiltro.Size = new System.Drawing.Size(161, 19);
            this.BtnFiltro.TabIndex = 8;
            this.BtnFiltro.Text = "FILTRAR USUARIO";
            this.BtnFiltro.UseVisualStyleBackColor = true;
            this.BtnFiltro.Click += new System.EventHandler(this.BtnFiltro_Click);
            // 
            // ComprarPaquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1362, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TABLA);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnRegresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ComprarPaquetes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComprarPaquetes";
            this.Load += new System.EventHandler(this.ComprarPaquetes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TABLA)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbPaquetes;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.ComboBox CmbTiquetes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Button BtnComprar;
        private System.Windows.Forms.Label CEDULA;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.DataGridView TABLA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnFiltro;
        private System.Windows.Forms.TextBox TxtFiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}