namespace FitLine.Forms
{
    partial class HistorialAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialAsistencia));
            this.TABLA = new System.Windows.Forms.DataGridView();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TABLA)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TABLA
            // 
            this.TABLA.AllowUserToOrderColumns = true;
            this.TABLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLA.Location = new System.Drawing.Point(22, 12);
            this.TABLA.Name = "TABLA";
            this.TABLA.RowHeadersWidth = 51;
            this.TABLA.Size = new System.Drawing.Size(343, 419);
            this.TABLA.TabIndex = 15;
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(133, 22);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(100, 20);
            this.TxtCedula.TabIndex = 16;
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltrar.Location = new System.Drawing.Point(92, 48);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltrar.TabIndex = 17;
            this.BtnFiltrar.Text = "FILTRAR";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "CEDULA A FILTRAR";
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.Location = new System.Drawing.Point(253, 448);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(75, 23);
            this.BtnRegresar.TabIndex = 19;
            this.BtnRegresar.Text = "REGRESAR";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtCedula);
            this.panel1.Controls.Add(this.BtnFiltrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(387, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 94);
            this.panel1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(455, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "HISTORIAL SALIDA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HistorialAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(653, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.TABLA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HistorialAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistorialAsistencia";
            this.Load += new System.EventHandler(this.HistorialAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TABLA)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TABLA;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}