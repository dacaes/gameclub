namespace GameClub
{
    partial class Panel_de_socio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_de_socio));
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.buttonAñadir_SocioAceptar = new System.Windows.Forms.Button();
            this.labelAlias = new System.Windows.Forms.Label();
            this.textBoxAlias = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.textBoxContraseñaActual = new System.Windows.Forms.TextBox();
            this.labelNuevaContraseña = new System.Windows.Forms.Label();
            this.textBoxNuevaContraseña = new System.Windows.Forms.TextBox();
            this.labelConfirmarContraseña = new System.Windows.Forms.Label();
            this.textBoxConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.groupBoxContraseña = new System.Windows.Forms.GroupBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.groupBoxContraseña.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(22, 44);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 27;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(22, 70);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(49, 13);
            this.labelApellidos.TabIndex = 28;
            this.labelApellidos.Text = "Apellidos";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(22, 96);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(26, 13);
            this.labelMail.TabIndex = 29;
            this.labelMail.Text = "Mail";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(22, 122);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(49, 13);
            this.labelTelefono.TabIndex = 30;
            this.labelTelefono.Text = "Teléfono";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(77, 63);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(137, 20);
            this.textBoxApellidos.TabIndex = 33;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(54, 89);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(160, 20);
            this.textBoxMail.TabIndex = 32;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(77, 115);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(76, 20);
            this.textBoxTelefono.TabIndex = 35;
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Enabled = false;
            this.checkBoxAdmin.Location = new System.Drawing.Point(159, 118);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxAdmin.Size = new System.Drawing.Size(55, 17);
            this.checkBoxAdmin.TabIndex = 36;
            this.checkBoxAdmin.Text = "Admin";
            this.checkBoxAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonAñadir_SocioAceptar
            // 
            this.buttonAñadir_SocioAceptar.Location = new System.Drawing.Point(25, 265);
            this.buttonAñadir_SocioAceptar.Name = "buttonAñadir_SocioAceptar";
            this.buttonAñadir_SocioAceptar.Size = new System.Drawing.Size(190, 23);
            this.buttonAñadir_SocioAceptar.TabIndex = 37;
            this.buttonAñadir_SocioAceptar.Text = "Aceptar";
            this.buttonAñadir_SocioAceptar.UseVisualStyleBackColor = true;
            this.buttonAñadir_SocioAceptar.Click += new System.EventHandler(this.buttonAñadir_SocioAceptar_Click);
            // 
            // labelAlias
            // 
            this.labelAlias.AutoSize = true;
            this.labelAlias.Location = new System.Drawing.Point(22, 18);
            this.labelAlias.Name = "labelAlias";
            this.labelAlias.Size = new System.Drawing.Size(29, 13);
            this.labelAlias.TabIndex = 38;
            this.labelAlias.Text = "Alias";
            // 
            // textBoxAlias
            // 
            this.textBoxAlias.Enabled = false;
            this.textBoxAlias.Location = new System.Drawing.Point(77, 11);
            this.textBoxAlias.Name = "textBoxAlias";
            this.textBoxAlias.Size = new System.Drawing.Size(137, 20);
            this.textBoxAlias.TabIndex = 39;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(77, 37);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(137, 20);
            this.textBoxNombre.TabIndex = 40;
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(9, 25);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(37, 13);
            this.labelContraseña.TabIndex = 31;
            this.labelContraseña.Text = "Actual";
            // 
            // textBoxContraseñaActual
            // 
            this.textBoxContraseñaActual.Location = new System.Drawing.Point(66, 19);
            this.textBoxContraseñaActual.Name = "textBoxContraseñaActual";
            this.textBoxContraseñaActual.Size = new System.Drawing.Size(112, 20);
            this.textBoxContraseñaActual.TabIndex = 34;
            this.textBoxContraseñaActual.UseSystemPasswordChar = true;
            // 
            // labelNuevaContraseña
            // 
            this.labelNuevaContraseña.AutoSize = true;
            this.labelNuevaContraseña.Location = new System.Drawing.Point(9, 52);
            this.labelNuevaContraseña.Name = "labelNuevaContraseña";
            this.labelNuevaContraseña.Size = new System.Drawing.Size(39, 13);
            this.labelNuevaContraseña.TabIndex = 41;
            this.labelNuevaContraseña.Text = "Nueva";
            // 
            // textBoxNuevaContraseña
            // 
            this.textBoxNuevaContraseña.Location = new System.Drawing.Point(66, 45);
            this.textBoxNuevaContraseña.Name = "textBoxNuevaContraseña";
            this.textBoxNuevaContraseña.Size = new System.Drawing.Size(112, 20);
            this.textBoxNuevaContraseña.TabIndex = 42;
            this.textBoxNuevaContraseña.UseSystemPasswordChar = true;
            // 
            // labelConfirmarContraseña
            // 
            this.labelConfirmarContraseña.AutoSize = true;
            this.labelConfirmarContraseña.Location = new System.Drawing.Point(9, 79);
            this.labelConfirmarContraseña.Name = "labelConfirmarContraseña";
            this.labelConfirmarContraseña.Size = new System.Drawing.Size(51, 13);
            this.labelConfirmarContraseña.TabIndex = 43;
            this.labelConfirmarContraseña.Text = "Confirmar";
            // 
            // textBoxConfirmarContraseña
            // 
            this.textBoxConfirmarContraseña.Location = new System.Drawing.Point(66, 72);
            this.textBoxConfirmarContraseña.Name = "textBoxConfirmarContraseña";
            this.textBoxConfirmarContraseña.Size = new System.Drawing.Size(112, 20);
            this.textBoxConfirmarContraseña.TabIndex = 44;
            this.textBoxConfirmarContraseña.UseSystemPasswordChar = true;
            // 
            // groupBoxContraseña
            // 
            this.groupBoxContraseña.Controls.Add(this.textBoxConfirmarContraseña);
            this.groupBoxContraseña.Controls.Add(this.labelConfirmarContraseña);
            this.groupBoxContraseña.Controls.Add(this.textBoxNuevaContraseña);
            this.groupBoxContraseña.Controls.Add(this.labelNuevaContraseña);
            this.groupBoxContraseña.Controls.Add(this.textBoxContraseñaActual);
            this.groupBoxContraseña.Controls.Add(this.labelContraseña);
            this.groupBoxContraseña.Location = new System.Drawing.Point(25, 141);
            this.groupBoxContraseña.Name = "groupBoxContraseña";
            this.groupBoxContraseña.Size = new System.Drawing.Size(189, 106);
            this.groupBoxContraseña.TabIndex = 45;
            this.groupBoxContraseña.TabStop = false;
            this.groupBoxContraseña.Text = "Contraseña";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(25, 294);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(190, 23);
            this.buttonEliminar.TabIndex = 46;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // Panel_de_socio
            // 
            this.AcceptButton = this.buttonAñadir_SocioAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(242, 339);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.groupBoxContraseña);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxAlias);
            this.Controls.Add(this.labelAlias);
            this.Controls.Add(this.buttonAñadir_SocioAceptar);
            this.Controls.Add(this.checkBoxAdmin);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxApellidos);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.labelNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Panel_de_socio";
            this.Text = "Panel de Socio";
            this.Load += new System.EventHandler(this.Panel_de_socio_Load);
            this.groupBoxContraseña.ResumeLayout(false);
            this.groupBoxContraseña.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.Button buttonAñadir_SocioAceptar;
        private System.Windows.Forms.Label labelAlias;
        private System.Windows.Forms.TextBox textBoxAlias;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox textBoxContraseñaActual;
        private System.Windows.Forms.Label labelNuevaContraseña;
        private System.Windows.Forms.TextBox textBoxNuevaContraseña;
        private System.Windows.Forms.Label labelConfirmarContraseña;
        private System.Windows.Forms.TextBox textBoxConfirmarContraseña;
        private System.Windows.Forms.GroupBox groupBoxContraseña;
        private System.Windows.Forms.Button buttonEliminar;

    }
}