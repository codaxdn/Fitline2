namespace FitLine
{
    partial class AgregarTiquetes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarTiquetes));
            this.TABLA = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtMeses = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.ComboEstado = new System.Windows.Forms.ComboBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtTiempo = new System.Windows.Forms.TextBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TABLA)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TABLA
            // 
            this.TABLA.AllowUserToOrderColumns = true;
            this.TABLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLA.Location = new System.Drawing.Point(14, 24);
            this.TABLA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TABLA.Name = "TABLA";
            this.TABLA.RowHeadersWidth = 51;
            this.TABLA.Size = new System.Drawing.Size(637, 419);
            this.TABLA.TabIndex = 15;
            this.TABLA.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TABLA_CellMouseDoubleClick_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TxtMeses);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BtnBorrar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BtnEditar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.BtnGuardar);
            this.panel1.Controls.Add(this.TxtCodigo);
            this.panel1.Controls.Add(this.ComboEstado);
            this.panel1.Controls.Add(this.TxtNombre);
            this.panel1.Controls.Add(this.TxtPrecio);
            this.panel1.Controls.Add(this.TxtTiempo);
            this.panel1.Location = new System.Drawing.Point(695, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 351);
            this.panel1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "MESES DE LA TIQUETERA";
            // 
            // TxtMeses
            // 
            this.TxtMeses.Location = new System.Drawing.Point(226, 140);
            this.TxtMeses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtMeses.Name = "TxtMeses";
            this.TxtMeses.Size = new System.Drawing.Size(192, 20);
            this.TxtMeses.TabIndex = 14;
            this.TxtMeses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMeses_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "CLASES DE LA TIQUETERA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE";
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Location = new System.Drawing.Point(312, 274);
            this.BtnBorrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(88, 23);
            this.BtnBorrar.TabIndex = 12;
            this.BtnBorrar.Text = "BORRAR";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "PRECIO";
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(170, 274);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(88, 23);
            this.BtnEditar.TabIndex = 11;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "ESTADO";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(21, 274);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(88, 23);
            this.BtnGuardar.TabIndex = 10;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Location = new System.Drawing.Point(226, 41);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.Size = new System.Drawing.Size(192, 20);
            this.TxtCodigo.TabIndex = 5;
            // 
            // ComboEstado
            // 
            this.ComboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboEstado.FormattingEnabled = true;
            this.ComboEstado.Location = new System.Drawing.Point(226, 203);
            this.ComboEstado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComboEstado.Name = "ComboEstado";
            this.ComboEstado.Size = new System.Drawing.Size(192, 21);
            this.ComboEstado.TabIndex = 9;
            this.ComboEstado.SelectedIndexChanged += new System.EventHandler(this.ComboEstado_SelectedIndexChanged);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(226, 73);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(192, 20);
            this.TxtNombre.TabIndex = 6;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(226, 171);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(192, 20);
            this.TxtPrecio.TabIndex = 8;
            this.TxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            // 
            // TxtTiempo
            // 
            this.TxtTiempo.Location = new System.Drawing.Point(226, 106);
            this.TxtTiempo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtTiempo.Name = "TxtTiempo";
            this.TxtTiempo.Size = new System.Drawing.Size(192, 20);
            this.TxtTiempo.TabIndex = 7;
            this.TxtTiempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTiempo_KeyPress);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(294, 479);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(88, 23);
            this.BtnSalir.TabIndex = 17;
            this.BtnSalir.Text = "REGRESAR";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgregarTiquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1187, 522);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TABLA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AgregarTiquetes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGREGAR_TIQUETES";
            this.Load += new System.EventHandler(this.AGREGAR_TIQUETES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TABLA)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TABLA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtMeses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.ComboBox ComboEstado;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox TxtTiempo;
        private System.Windows.Forms.Button BtnSalir;
    }
}