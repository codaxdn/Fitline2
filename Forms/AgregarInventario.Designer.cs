namespace FitLine
{
    partial class AgregarInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarInventario));
            this.TABLA = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtCantSuma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtVender = new System.Windows.Forms.Button();
            this.TxtVende = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TABLA)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TABLA
            // 
            this.TABLA.AllowUserToOrderColumns = true;
            this.TABLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLA.Location = new System.Drawing.Point(49, 47);
            this.TABLA.Name = "TABLA";
            this.TABLA.RowHeadersWidth = 51;
            this.TABLA.Size = new System.Drawing.Size(536, 470);
            this.TABLA.TabIndex = 15;
            this.TABLA.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TABLA_CellMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.BtnBorrar);
            this.panel1.Controls.Add(this.BtnEditar);
            this.panel1.Controls.Add(this.BtnGuardar);
            this.panel1.Controls.Add(this.TxtDescripcion);
            this.panel1.Controls.Add(this.TxtCantidad);
            this.panel1.Controls.Add(this.TxtCodigo);
            this.panel1.Controls.Add(this.TxtNombre);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtPrecio);
            this.panel1.Location = new System.Drawing.Point(629, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 216);
            this.panel1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "PRECIO";
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.Location = new System.Drawing.Point(218, 177);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(75, 23);
            this.BtnBorrar.TabIndex = 39;
            this.BtnBorrar.Text = "BORRAR";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(118, 177);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 38;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(17, 177);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 37;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(135, 104);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(142, 20);
            this.TxtDescripcion.TabIndex = 8;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(135, 74);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(142, 20);
            this.TxtCantidad.TabIndex = 7;
            this.TxtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Location = new System.Drawing.Point(135, 16);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.Size = new System.Drawing.Size(142, 20);
            this.TxtCodigo.TabIndex = 6;
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigo_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(135, 46);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(142, 20);
            this.TxtNombre.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DESCRIPCION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CANTIDAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(135, 131);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(142, 20);
            this.TxtPrecio.TabIndex = 41;
            this.TxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.TxtCantSuma);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(629, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 121);
            this.panel2.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(118, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtCantSuma
            // 
            this.TxtCantSuma.Location = new System.Drawing.Point(135, 46);
            this.TxtCantSuma.Name = "TxtCantSuma";
            this.TxtCantSuma.Size = new System.Drawing.Size(142, 20);
            this.TxtCantSuma.TabIndex = 8;
            this.TxtCantSuma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantSuma_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "CANTIDAD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(132, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "AGREGAR";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(263, 540);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 19;
            this.BtnSalir.Text = "REGRESAR";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TxtVender);
            this.panel3.Controls.Add(this.TxtVende);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(629, 396);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 121);
            this.panel3.TabIndex = 20;
            // 
            // TxtVender
            // 
            this.TxtVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVender.Location = new System.Drawing.Point(118, 85);
            this.TxtVender.Name = "TxtVender";
            this.TxtVender.Size = new System.Drawing.Size(75, 23);
            this.TxtVender.TabIndex = 9;
            this.TxtVender.Text = "VENDER";
            this.TxtVender.UseVisualStyleBackColor = true;
            this.TxtVender.Click += new System.EventHandler(this.TxtVender_Click);
            // 
            // TxtVende
            // 
            this.TxtVende.Location = new System.Drawing.Point(135, 46);
            this.TxtVende.Name = "TxtVende";
            this.TxtVende.Size = new System.Drawing.Size(142, 20);
            this.TxtVende.TabIndex = 8;
            this.TxtVende.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtVende_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "CANTIDAD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(132, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "VENDER";
            // 
            // AgregarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(994, 575);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TABLA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AgregarInventario";
            this.Text = "AGREGAR_INVENTARIO";
            this.Load += new System.EventHandler(this.AGREGAR_INVENTARIO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TABLA)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TABLA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtCantSuma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button TxtVender;
        private System.Windows.Forms.TextBox TxtVende;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}