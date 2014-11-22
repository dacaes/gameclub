namespace GameClub
{
    partial class Buscar_socio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar_socio));
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxAlias = new System.Windows.Forms.TextBox();
            this.labelAlias = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.buttonAcceder = new System.Windows.Forms.Button();
            this.labelResultados = new System.Windows.Forms.Label();
            this.listBoxResultados = new System.Windows.Forms.ListBox();
            this.groupBoxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(71, 44);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(137, 20);
            this.textBoxNombre.TabIndex = 57;
            // 
            // textBoxAlias
            // 
            this.textBoxAlias.Location = new System.Drawing.Point(71, 18);
            this.textBoxAlias.Name = "textBoxAlias";
            this.textBoxAlias.Size = new System.Drawing.Size(137, 20);
            this.textBoxAlias.TabIndex = 56;
            // 
            // labelAlias
            // 
            this.labelAlias.AutoSize = true;
            this.labelAlias.Location = new System.Drawing.Point(16, 25);
            this.labelAlias.Name = "labelAlias";
            this.labelAlias.Size = new System.Drawing.Size(29, 13);
            this.labelAlias.TabIndex = 55;
            this.labelAlias.Text = "Alias";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(12, 171);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(221, 23);
            this.buttonBuscar.TabIndex = 54;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(71, 122);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(137, 20);
            this.textBoxTelefono.TabIndex = 52;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(48, 96);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(160, 20);
            this.textBoxMail.TabIndex = 50;
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(71, 70);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(137, 20);
            this.textBoxApellidos.TabIndex = 51;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(16, 129);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(49, 13);
            this.labelTelefono.TabIndex = 49;
            this.labelTelefono.Text = "Teléfono";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(16, 103);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(26, 13);
            this.labelMail.TabIndex = 48;
            this.labelMail.Text = "Mail";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(16, 77);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(49, 13);
            this.labelApellidos.TabIndex = 47;
            this.labelApellidos.Text = "Apellidos";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(16, 51);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 46;
            this.labelNombre.Text = "Nombre";
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.textBoxNombre);
            this.groupBoxDatos.Controls.Add(this.textBoxAlias);
            this.groupBoxDatos.Controls.Add(this.labelAlias);
            this.groupBoxDatos.Controls.Add(this.textBoxTelefono);
            this.groupBoxDatos.Controls.Add(this.textBoxMail);
            this.groupBoxDatos.Controls.Add(this.textBoxApellidos);
            this.groupBoxDatos.Controls.Add(this.labelTelefono);
            this.groupBoxDatos.Controls.Add(this.labelMail);
            this.groupBoxDatos.Controls.Add(this.labelApellidos);
            this.groupBoxDatos.Controls.Add(this.labelNombre);
            this.groupBoxDatos.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(222, 153);
            this.groupBoxDatos.TabIndex = 58;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos";
            // 
            // buttonAcceder
            // 
            this.buttonAcceder.Location = new System.Drawing.Point(12, 359);
            this.buttonAcceder.Name = "buttonAcceder";
            this.buttonAcceder.Size = new System.Drawing.Size(221, 23);
            this.buttonAcceder.TabIndex = 60;
            this.buttonAcceder.Text = "Acceder";
            this.buttonAcceder.UseVisualStyleBackColor = true;
            this.buttonAcceder.Click += new System.EventHandler(this.buttonAcceder_Click);
            // 
            // labelResultados
            // 
            this.labelResultados.AutoSize = true;
            this.labelResultados.Location = new System.Drawing.Point(9, 205);
            this.labelResultados.Name = "labelResultados";
            this.labelResultados.Size = new System.Drawing.Size(60, 13);
            this.labelResultados.TabIndex = 61;
            this.labelResultados.Text = "Resultados";
            // 
            // listBoxResultados
            // 
            this.listBoxResultados.FormattingEnabled = true;
            this.listBoxResultados.Location = new System.Drawing.Point(12, 221);
            this.listBoxResultados.Name = "listBoxResultados";
            this.listBoxResultados.Size = new System.Drawing.Size(221, 121);
            this.listBoxResultados.TabIndex = 62;
            this.listBoxResultados.SelectedIndexChanged += new System.EventHandler(this.listBoxResultados_SelectedIndexChanged);
            // 
            // Buscar_socio
            // 
            this.AcceptButton = this.buttonAcceder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 403);
            this.Controls.Add(this.listBoxResultados);
            this.Controls.Add(this.labelResultados);
            this.Controls.Add(this.buttonAcceder);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.buttonBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Buscar_socio";
            this.Text = "Buscar Socio";
            this.Load += new System.EventHandler(this.Buscar_socio_Load);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxAlias;
        private System.Windows.Forms.Label labelAlias;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Button buttonAcceder;
        private System.Windows.Forms.Label labelResultados;
        private System.Windows.Forms.ListBox listBoxResultados;

    }
}