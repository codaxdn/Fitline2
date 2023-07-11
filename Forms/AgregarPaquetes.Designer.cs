namespace FitLine
{
    partial class AgregarPaquetes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarPaquetes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtTiempo = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.ComboEstado = new System.Windows.Forms.ComboBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.TABLA = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TABLA)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "PRECIO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "ESTADO";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Location = new System.Drawing.Point(146, 44);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.Size = new System.Drawing.Size(165, 20);
            this.TxtCodigo.TabIndex = 5;
            this.TxtCodigo.TextChanged += new System.EventHandler(this.TxtCodigo_TextChanged);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(146, 81);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(165, 20);
            this.TxtNombre.TabIndex = 6;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // TxtTiempo
            // 
            this.TxtTiempo.Location = new System.Drawing.Point(146, 119);
            this.TxtTiempo.Name = "TxtTiempo";
            this.TxtTiempo.Size = new System.Drawing.Size(165, 20);
            this.TxtTiempo.TabIndex = 7;
            this.TxtTiempo.TextChanged += new System.EventHandler(this.TxtTiempo_TextChanged);
            this.TxtTiempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTiempo_KeyPress);
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(146, 158);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(165, 20);
            this.TxtPrecio.TabIndex = 8;
            this.TxtPrecio.TextChanged += new System.EventHandler(this.TxtPrecio_TextChanged);
            this.TxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            // 
            // ComboEstado
            // 
            this.ComboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboEstado.FormattingEnabled = true;
            this.ComboEstado.Location = new System.Drawing.Point(146, 191);
            this.ComboEstado.Name = "ComboEstado";
            this.ComboEstado.Size = new System.Drawing.Size(165, 21);
            this.ComboEstado.TabIndex = 9;
            this.ComboEstado.SelectedIndexChanged += new System.EventHandler(this.CmbEstado_SelectedIndexChanged);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(18, 289);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 10;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(146, 289);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 11;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.Location = new System.Drawing.Point(267, 289);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(75, 23);
            this.BtnBorrar.TabIndex = 12;
            this.BtnBorrar.Text = "BORRAR";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.Location = new System.Drawing.Point(380, 490);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(75, 23);
            this.BtnRegresar.TabIndex = 13;
            this.BtnRegresar.Text = "REGRESAR";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // TABLA
            // 
            this.TABLA.AllowUserToOrderColumns = true;
            this.TABLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLA.Location = new System.Drawing.Point(36, 33);
            this.TABLA.Name = "TABLA";
            this.TABLA.RowHeadersWidth = 51;
            this.TABLA.Size = new System.Drawing.Size(533, 419);
            this.TABLA.TabIndex = 14;
            this.TABLA.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TABLA_CellMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
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
            this.panel1.Location = new System.Drawing.Point(702, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 356);
            this.panel1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "TIEMPO MESES";
            // 
            // AgregarPaquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1110, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TABLA);
            this.Controls.Add(this.BtnRegresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AgregarPaquetes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TABLA)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtTiempo;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.ComboBox ComboEstado;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.DataGridView TABLA;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Panel panel1;

    }
}

