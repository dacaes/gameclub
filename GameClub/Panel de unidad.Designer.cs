namespace GameClub
{
    partial class Panel_de_unidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_de_unidad));
            this.buttonModificar_JuegoAceptar = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelPropietario = new System.Windows.Forms.Label();
            this.textBoxIDJuego = new System.Windows.Forms.TextBox();
            this.labelIDJuego = new System.Windows.Forms.Label();
            this.comboBoxAliasPropietario = new System.Windows.Forms.ComboBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonModificar_JuegoAceptar
            // 
            this.buttonModificar_JuegoAceptar.Location = new System.Drawing.Point(12, 79);
            this.buttonModificar_JuegoAceptar.Name = "buttonModificar_JuegoAceptar";
            this.buttonModificar_JuegoAceptar.Size = new System.Drawing.Size(288, 25);
            this.buttonModificar_JuegoAceptar.TabIndex = 38;
            this.buttonModificar_JuegoAceptar.Text = "Aceptar";
            this.buttonModificar_JuegoAceptar.UseVisualStyleBackColor = true;
            this.buttonModificar_JuegoAceptar.Click += new System.EventHandler(this.buttonModificar_JuegoAceptar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(9, 16);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(35, 13);
            this.labelTitulo.TabIndex = 35;
            this.labelTitulo.Text = "Título";
            // 
            // labelPropietario
            // 
            this.labelPropietario.AutoSize = true;
            this.labelPropietario.Location = new System.Drawing.Point(128, 51);
            this.labelPropietario.Name = "labelPropietario";
            this.labelPropietario.Size = new System.Drawing.Size(57, 13);
            this.labelPropietario.TabIndex = 34;
            this.labelPropietario.Text = "Propietario";
            // 
            // textBoxIDJuego
            // 
            this.textBoxIDJuego.Enabled = false;
            this.textBoxIDJuego.Location = new System.Drawing.Point(72, 44);
            this.textBoxIDJuego.Name = "textBoxIDJuego";
            this.textBoxIDJuego.ReadOnly = true;
            this.textBoxIDJuego.Size = new System.Drawing.Size(47, 20);
            this.textBoxIDJuego.TabIndex = 32;
            // 
            // labelIDJuego
            // 
            this.labelIDJuego.AutoSize = true;
            this.labelIDJuego.Location = new System.Drawing.Point(9, 51);
            this.labelIDJuego.Name = "labelIDJuego";
            this.labelIDJuego.Size = new System.Drawing.Size(50, 13);
            this.labelIDJuego.TabIndex = 31;
            this.labelIDJuego.Text = "ID Juego";
            // 
            // comboBoxAliasPropietario
            // 
            this.comboBoxAliasPropietario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxAliasPropietario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxAliasPropietario.FormattingEnabled = true;
            this.comboBoxAliasPropietario.Location = new System.Drawing.Point(191, 43);
            this.comboBoxAliasPropietario.Name = "comboBoxAliasPropietario";
            this.comboBoxAliasPropietario.Size = new System.Drawing.Size(109, 21);
            this.comboBoxAliasPropietario.TabIndex = 46;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Enabled = false;
            this.textBoxTitulo.Location = new System.Drawing.Point(50, 9);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(250, 20);
            this.textBoxTitulo.TabIndex = 48;
            // 
            // Panel_de_unidad
            // 
            this.AcceptButton = this.buttonModificar_JuegoAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 114);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.comboBoxAliasPropietario);
            this.Controls.Add(this.buttonModificar_JuegoAceptar);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelPropietario);
            this.Controls.Add(this.textBoxIDJuego);
            this.Controls.Add(this.labelIDJuego);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Panel_de_unidad";
            this.Text = "Panel de Unidad";
            this.Load += new System.EventHandler(this.Panel_de_unidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonModificar_JuegoAceptar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelPropietario;
        private System.Windows.Forms.TextBox textBoxIDJuego;
        private System.Windows.Forms.Label labelIDJuego;
        private System.Windows.Forms.ComboBox comboBoxAliasPropietario;
        private System.Windows.Forms.TextBox textBoxTitulo;
    }
}