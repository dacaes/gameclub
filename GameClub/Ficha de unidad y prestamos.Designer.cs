namespace GameClub
{
    partial class Ficha_de_unidad_y_prestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ficha_de_unidad_y_prestamos));
            this.groupBoxUnidades = new System.Windows.Forms.GroupBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonPropietario = new System.Windows.Forms.Button();
            this.buttonNueva = new System.Windows.Forms.Button();
            this.labelNoDisponible = new System.Windows.Forms.Label();
            this.listBoxUnidadNoDisponible = new System.Windows.Forms.ListBox();
            this.labelDisponibles = new System.Windows.Forms.Label();
            this.listBoxUnidadDisponible = new System.Windows.Forms.ListBox();
            this.groupBoxPrestamos = new System.Windows.Forms.GroupBox();
            this.buttonDevolver = new System.Windows.Forms.Button();
            this.comboBoxSocio = new System.Windows.Forms.ComboBox();
            this.labelSocio = new System.Windows.Forms.Label();
            this.labelFecha1 = new System.Windows.Forms.Label();
            this.buttonPrestar = new System.Windows.Forms.Button();
            this.labelFecha0 = new System.Windows.Forms.Label();
            this.dateTimePickerJuego2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerJuego1 = new System.Windows.Forms.DateTimePicker();
            this.groupBoxUnidades.SuspendLayout();
            this.groupBoxPrestamos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUnidades
            // 
            this.groupBoxUnidades.Controls.Add(this.buttonDevolver);
            this.groupBoxUnidades.Controls.Add(this.comboBoxSocio);
            this.groupBoxUnidades.Controls.Add(this.buttonEliminar);
            this.groupBoxUnidades.Controls.Add(this.labelSocio);
            this.groupBoxUnidades.Controls.Add(this.listBoxUnidadDisponible);
            this.groupBoxUnidades.Controls.Add(this.buttonPropietario);
            this.groupBoxUnidades.Controls.Add(this.buttonPrestar);
            this.groupBoxUnidades.Controls.Add(this.buttonNueva);
            this.groupBoxUnidades.Controls.Add(this.labelNoDisponible);
            this.groupBoxUnidades.Controls.Add(this.listBoxUnidadNoDisponible);
            this.groupBoxUnidades.Controls.Add(this.labelDisponibles);
            this.groupBoxUnidades.Location = new System.Drawing.Point(21, 21);
            this.groupBoxUnidades.Name = "groupBoxUnidades";
            this.groupBoxUnidades.Size = new System.Drawing.Size(464, 222);
            this.groupBoxUnidades.TabIndex = 53;
            this.groupBoxUnidades.TabStop = false;
            this.groupBoxUnidades.Text = "Unidades";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(195, 117);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 10;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonPropietario
            // 
            this.buttonPropietario.Location = new System.Drawing.Point(195, 38);
            this.buttonPropietario.Name = "buttonPropietario";
            this.buttonPropietario.Size = new System.Drawing.Size(75, 23);
            this.buttonPropietario.TabIndex = 9;
            this.buttonPropietario.Text = "Propietario";
            this.buttonPropietario.UseVisualStyleBackColor = true;
            this.buttonPropietario.Click += new System.EventHandler(this.buttonPropietario_Click);
            // 
            // buttonNueva
            // 
            this.buttonNueva.Location = new System.Drawing.Point(195, 146);
            this.buttonNueva.Name = "buttonNueva";
            this.buttonNueva.Size = new System.Drawing.Size(75, 23);
            this.buttonNueva.TabIndex = 7;
            this.buttonNueva.Text = "Nueva";
            this.buttonNueva.UseVisualStyleBackColor = true;
            this.buttonNueva.Click += new System.EventHandler(this.buttonNueva_Click);
            // 
            // labelNoDisponible
            // 
            this.labelNoDisponible.AutoSize = true;
            this.labelNoDisponible.Location = new System.Drawing.Point(326, 22);
            this.labelNoDisponible.Name = "labelNoDisponible";
            this.labelNoDisponible.Size = new System.Drawing.Size(80, 13);
            this.labelNoDisponible.TabIndex = 5;
            this.labelNoDisponible.Text = "NO Disponibles";
            // 
            // listBoxUnidadNoDisponible
            // 
            this.listBoxUnidadNoDisponible.FormattingEnabled = true;
            this.listBoxUnidadNoDisponible.Location = new System.Drawing.Point(276, 38);
            this.listBoxUnidadNoDisponible.Name = "listBoxUnidadNoDisponible";
            this.listBoxUnidadNoDisponible.Size = new System.Drawing.Size(179, 147);
            this.listBoxUnidadNoDisponible.TabIndex = 3;
            // 
            // labelDisponibles
            // 
            this.labelDisponibles.AutoSize = true;
            this.labelDisponibles.Location = new System.Drawing.Point(68, 22);
            this.labelDisponibles.Name = "labelDisponibles";
            this.labelDisponibles.Size = new System.Drawing.Size(61, 13);
            this.labelDisponibles.TabIndex = 2;
            this.labelDisponibles.Text = "Disponibles";
            // 
            // listBoxUnidadDisponible
            // 
            this.listBoxUnidadDisponible.FormattingEnabled = true;
            this.listBoxUnidadDisponible.Location = new System.Drawing.Point(10, 38);
            this.listBoxUnidadDisponible.Name = "listBoxUnidadDisponible";
            this.listBoxUnidadDisponible.Size = new System.Drawing.Size(179, 147);
            this.listBoxUnidadDisponible.TabIndex = 0;
            this.listBoxUnidadDisponible.SelectedIndexChanged += new System.EventHandler(this.listBoxUnidadDisponible_SelectedIndexChanged);
            // 
            // groupBoxPrestamos
            // 
            this.groupBoxPrestamos.Controls.Add(this.labelFecha1);
            this.groupBoxPrestamos.Controls.Add(this.labelFecha0);
            this.groupBoxPrestamos.Controls.Add(this.dateTimePickerJuego2);
            this.groupBoxPrestamos.Controls.Add(this.dateTimePickerJuego1);
            this.groupBoxPrestamos.Location = new System.Drawing.Point(21, 249);
            this.groupBoxPrestamos.Name = "groupBoxPrestamos";
            this.groupBoxPrestamos.Size = new System.Drawing.Size(464, 61);
            this.groupBoxPrestamos.TabIndex = 54;
            this.groupBoxPrestamos.TabStop = false;
            this.groupBoxPrestamos.Text = "Préstamos";
            this.groupBoxPrestamos.Enter += new System.EventHandler(this.groupBoxPrestamos_Enter);
            // 
            // buttonDevolver
            // 
            this.buttonDevolver.Location = new System.Drawing.Point(312, 189);
            this.buttonDevolver.Name = "buttonDevolver";
            this.buttonDevolver.Size = new System.Drawing.Size(143, 22);
            this.buttonDevolver.TabIndex = 60;
            this.buttonDevolver.Text = "Devolver";
            this.buttonDevolver.UseVisualStyleBackColor = true;
            this.buttonDevolver.Click += new System.EventHandler(this.buttonDevolver_Click);
            // 
            // comboBoxSocio
            // 
            this.comboBoxSocio.FormattingEnabled = true;
            this.comboBoxSocio.Location = new System.Drawing.Point(157, 190);
            this.comboBoxSocio.Name = "comboBoxSocio";
            this.comboBoxSocio.Size = new System.Drawing.Size(149, 21);
            this.comboBoxSocio.TabIndex = 59;
            // 
            // labelSocio
            // 
            this.labelSocio.AutoSize = true;
            this.labelSocio.Location = new System.Drawing.Point(214, 172);
            this.labelSocio.Name = "labelSocio";
            this.labelSocio.Size = new System.Drawing.Size(34, 13);
            this.labelSocio.TabIndex = 58;
            this.labelSocio.Text = "Socio";
            // 
            // labelFecha1
            // 
            this.labelFecha1.AutoSize = true;
            this.labelFecha1.Location = new System.Drawing.Point(351, 16);
            this.labelFecha1.Name = "labelFecha1";
            this.labelFecha1.Size = new System.Drawing.Size(107, 13);
            this.labelFecha1.TabIndex = 57;
            this.labelFecha1.Text = "Fecha de devolución";
            // 
            // buttonPrestar
            // 
            this.buttonPrestar.Location = new System.Drawing.Point(10, 190);
            this.buttonPrestar.Name = "buttonPrestar";
            this.buttonPrestar.Size = new System.Drawing.Size(141, 23);
            this.buttonPrestar.TabIndex = 7;
            this.buttonPrestar.Text = "Prestar";
            this.buttonPrestar.UseVisualStyleBackColor = true;
            this.buttonPrestar.Click += new System.EventHandler(this.buttonPrestar_Click);
            // 
            // labelFecha0
            // 
            this.labelFecha0.AutoSize = true;
            this.labelFecha0.Location = new System.Drawing.Point(8, 16);
            this.labelFecha0.Name = "labelFecha0";
            this.labelFecha0.Size = new System.Drawing.Size(98, 13);
            this.labelFecha0.TabIndex = 11;
            this.labelFecha0.Text = "Fecha de préstamo";
            // 
            // dateTimePickerJuego2
            // 
            this.dateTimePickerJuego2.Location = new System.Drawing.Point(236, 32);
            this.dateTimePickerJuego2.Name = "dateTimePickerJuego2";
            this.dateTimePickerJuego2.Size = new System.Drawing.Size(220, 20);
            this.dateTimePickerJuego2.TabIndex = 56;
            // 
            // dateTimePickerJuego1
            // 
            this.dateTimePickerJuego1.Location = new System.Drawing.Point(11, 32);
            this.dateTimePickerJuego1.Name = "dateTimePickerJuego1";
            this.dateTimePickerJuego1.Size = new System.Drawing.Size(219, 20);
            this.dateTimePickerJuego1.TabIndex = 55;
            // 
            // Ficha_de_unidad_y_prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 332);
            this.Controls.Add(this.groupBoxPrestamos);
            this.Controls.Add(this.groupBoxUnidades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ficha_de_unidad_y_prestamos";
            this.Text = "Ficha de Unidad y Préstamos";
            this.Load += new System.EventHandler(this.Ficha_de_unidad_y_prestamos_Load);
            this.groupBoxUnidades.ResumeLayout(false);
            this.groupBoxUnidades.PerformLayout();
            this.groupBoxPrestamos.ResumeLayout(false);
            this.groupBoxPrestamos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUnidades;
        private System.Windows.Forms.ListBox listBoxUnidadDisponible;
        private System.Windows.Forms.Label labelDisponibles;
        private System.Windows.Forms.Label labelNoDisponible;
        private System.Windows.Forms.ListBox listBoxUnidadNoDisponible;
        private System.Windows.Forms.Button buttonNueva;
        private System.Windows.Forms.Button buttonPropietario;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.GroupBox groupBoxPrestamos;
        private System.Windows.Forms.Button buttonPrestar;
        private System.Windows.Forms.Label labelFecha1;
        private System.Windows.Forms.Label labelFecha0;
        private System.Windows.Forms.DateTimePicker dateTimePickerJuego2;
        private System.Windows.Forms.DateTimePicker dateTimePickerJuego1;
        private System.Windows.Forms.Label labelSocio;
        private System.Windows.Forms.ComboBox comboBoxSocio;
        private System.Windows.Forms.Button buttonDevolver;
    }
}