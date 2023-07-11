namespace FitLine
{
    partial class RegistroUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroUsuarios));
            this.TABLA = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtHuella = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtContactoEmer = new System.Windows.Forms.TextBox();
            this.TxtNumeroCon = new System.Windows.Forms.TextBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TABLA)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TABLA
            // 
            this.TABLA.AllowUserToOrderColumns = true;
            this.TABLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLA.Location = new System.Drawing.Point(65, 44);
            this.TABLA.Name = "TABLA";
            this.TABLA.RowHeadersWidth = 51;
            this.TABLA.Size = new System.Drawing.Size(640, 568);
            this.TABLA.TabIndex = 16;
            this.TABLA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TABLA_CellContentClick);
            this.TABLA.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TABLA_CellMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtCedula);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.BtnBorrar);
            this.panel1.Controls.Add(this.BtnEditar);
            this.panel1.Controls.Add(this.BtnGuardar);
            this.panel1.Controls.Add(this.TxtHuella);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.TxtEmail);
            this.panel1.Controls.Add(this.TxtContactoEmer);
            this.panel1.Controls.Add(this.TxtNumeroCon);
            this.panel1.Controls.Add(this.TxtApellidos);
            this.panel1.Controls.Add(this.TxtNombres);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(829, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 335);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(257, 31);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(179, 20);
            this.TxtCedula.TabIndex = 38;
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 37;
            this.label9.Text = "CEDULA";
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.Location = new System.Drawing.Point(341, 290);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(75, 23);
            this.BtnBorrar.TabIndex = 36;
            this.BtnBorrar.Text = "BORRAR";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(225, 290);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 35;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(98, 290);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 34;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtHuella
            // 
            this.TxtHuella.Enabled = false;
            this.TxtHuella.Location = new System.Drawing.Point(257, 222);
            this.TxtHuella.Name = "TxtHuella";
            this.TxtHuella.Size = new System.Drawing.Size(134, 20);
            this.TxtHuella.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "CAPTURAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(257, 189);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(179, 20);
            this.TxtEmail.TabIndex = 28;
            // 
            // TxtContactoEmer
            // 
            this.TxtContactoEmer.Location = new System.Drawing.Point(257, 160);
            this.TxtContactoEmer.Name = "TxtContactoEmer";
            this.TxtContactoEmer.Size = new System.Drawing.Size(179, 20);
            this.TxtContactoEmer.TabIndex = 27;
            this.TxtContactoEmer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContactoEmer_KeyPress);
            // 
            // TxtNumeroCon
            // 
            this.TxtNumeroCon.Location = new System.Drawing.Point(257, 123);
            this.TxtNumeroCon.Name = "TxtNumeroCon";
            this.TxtNumeroCon.Size = new System.Drawing.Size(179, 20);
            this.TxtNumeroCon.TabIndex = 26;
            this.TxtNumeroCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeroCon_KeyPress);
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(257, 93);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(179, 20);
            this.TxtApellidos.TabIndex = 25;
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(257, 63);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(179, 20);
            this.TxtNombres.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "HUELLA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "EMAIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "CONTACTO DE EMERGENCIAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "NUMERO DE CONTACTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "APELLIDOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "NOMBRES";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(372, 629);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 18;
            this.BtnSalir.Text = "REGRESAR";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.TxtFiltro);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(829, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 100);
            this.panel2.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "CEDULA";
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.Location = new System.Drawing.Point(121, 38);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(179, 20);
            this.TxtFiltro.TabIndex = 39;
            this.TxtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFiltro_KeyPress);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(341, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 40;
            this.button2.Text = "FILTRAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1352, 690);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TABLA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegistroUsuarios";
            this.Text = "REGISTRO_USUARIOS";
            this.Load += new System.EventHandler(this.REGISTRO_USUARIOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TABLA)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TABLA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtContactoEmer;
        private System.Windows.Forms.TextBox TxtNumeroCon;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtHuella;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtFiltro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}