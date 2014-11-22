namespace GameClub
{
    partial class Ficha_de_juego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ficha_de_juego));
            this.groupBoxDatosJuego = new System.Windows.Forms.GroupBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.checkBoxDisponible = new System.Windows.Forms.CheckBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxPEGI = new System.Windows.Forms.TextBox();
            this.labelPlataforma = new System.Windows.Forms.Label();
            this.textBoxPlataforma = new System.Windows.Forms.TextBox();
            this.textBoxGenero = new System.Windows.Forms.TextBox();
            this.labelPEGI = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.buttonModificarOpinion = new System.Windows.Forms.Button();
            this.comboBoxAlias = new System.Windows.Forms.ComboBox();
            this.labelNota = new System.Windows.Forms.Label();
            this.textBoxNota = new System.Windows.Forms.TextBox();
            this.groupBoxOpiniones = new System.Windows.Forms.GroupBox();
            this.textBoxMedia = new System.Windows.Forms.TextBox();
            this.labelMedia = new System.Windows.Forms.Label();
            this.textBoxOpiniones = new System.Windows.Forms.TextBox();
            this.labelAutor = new System.Windows.Forms.Label();
            this.buttonEscribirOpinión = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonUnidades = new System.Windows.Forms.Button();
            this.groupBoxDatosJuego.SuspendLayout();
            this.groupBoxOpiniones.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDatosJuego
            // 
            this.groupBoxDatosJuego.Controls.Add(this.labelTitulo);
            this.groupBoxDatosJuego.Controls.Add(this.checkBoxDisponible);
            this.groupBoxDatosJuego.Controls.Add(this.textBoxTitulo);
            this.groupBoxDatosJuego.Controls.Add(this.textBoxPEGI);
            this.groupBoxDatosJuego.Controls.Add(this.labelPlataforma);
            this.groupBoxDatosJuego.Controls.Add(this.textBoxPlataforma);
            this.groupBoxDatosJuego.Controls.Add(this.textBoxGenero);
            this.groupBoxDatosJuego.Controls.Add(this.labelPEGI);
            this.groupBoxDatosJuego.Controls.Add(this.labelGenero);
            this.groupBoxDatosJuego.Location = new System.Drawing.Point(21, 22);
            this.groupBoxDatosJuego.Name = "groupBoxDatosJuego";
            this.groupBoxDatosJuego.Size = new System.Drawing.Size(397, 76);
            this.groupBoxDatosJuego.TabIndex = 47;
            this.groupBoxDatosJuego.TabStop = false;
            this.groupBoxDatosJuego.Text = "Datos del juego";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(6, 25);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(35, 13);
            this.labelTitulo.TabIndex = 49;
            this.labelTitulo.Text = "Título";
            // 
            // checkBoxDisponible
            // 
            this.checkBoxDisponible.AutoSize = true;
            this.checkBoxDisponible.Enabled = false;
            this.checkBoxDisponible.Location = new System.Drawing.Point(315, 49);
            this.checkBoxDisponible.Name = "checkBoxDisponible";
            this.checkBoxDisponible.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxDisponible.Size = new System.Drawing.Size(75, 17);
            this.checkBoxDisponible.TabIndex = 56;
            this.checkBoxDisponible.Text = "Disponible";
            this.checkBoxDisponible.UseVisualStyleBackColor = true;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Enabled = false;
            this.textBoxTitulo.Location = new System.Drawing.Point(47, 18);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(170, 20);
            this.textBoxTitulo.TabIndex = 48;
            // 
            // textBoxPEGI
            // 
            this.textBoxPEGI.Enabled = false;
            this.textBoxPEGI.Location = new System.Drawing.Point(292, 46);
            this.textBoxPEGI.Name = "textBoxPEGI";
            this.textBoxPEGI.Size = new System.Drawing.Size(20, 20);
            this.textBoxPEGI.TabIndex = 55;
            // 
            // labelPlataforma
            // 
            this.labelPlataforma.AutoSize = true;
            this.labelPlataforma.Location = new System.Drawing.Point(223, 25);
            this.labelPlataforma.Name = "labelPlataforma";
            this.labelPlataforma.Size = new System.Drawing.Size(57, 13);
            this.labelPlataforma.TabIndex = 50;
            this.labelPlataforma.Text = "Plataforma";
            // 
            // textBoxPlataforma
            // 
            this.textBoxPlataforma.Enabled = false;
            this.textBoxPlataforma.Location = new System.Drawing.Point(286, 18);
            this.textBoxPlataforma.Name = "textBoxPlataforma";
            this.textBoxPlataforma.Size = new System.Drawing.Size(104, 20);
            this.textBoxPlataforma.TabIndex = 53;
            // 
            // textBoxGenero
            // 
            this.textBoxGenero.Enabled = false;
            this.textBoxGenero.Location = new System.Drawing.Point(47, 46);
            this.textBoxGenero.Name = "textBoxGenero";
            this.textBoxGenero.Size = new System.Drawing.Size(201, 20);
            this.textBoxGenero.TabIndex = 54;
            this.textBoxGenero.TextChanged += new System.EventHandler(this.textBoxGenero_TextChanged);
            // 
            // labelPEGI
            // 
            this.labelPEGI.AutoSize = true;
            this.labelPEGI.Location = new System.Drawing.Point(254, 53);
            this.labelPEGI.Name = "labelPEGI";
            this.labelPEGI.Size = new System.Drawing.Size(32, 13);
            this.labelPEGI.TabIndex = 51;
            this.labelPEGI.Text = "PEGI";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(6, 50);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(42, 13);
            this.labelGenero.TabIndex = 52;
            this.labelGenero.Text = "Género";
            // 
            // buttonModificarOpinion
            // 
            this.buttonModificarOpinion.Location = new System.Drawing.Point(286, 13);
            this.buttonModificarOpinion.Name = "buttonModificarOpinion";
            this.buttonModificarOpinion.Size = new System.Drawing.Size(105, 27);
            this.buttonModificarOpinion.TabIndex = 48;
            this.buttonModificarOpinion.Text = "Modificar Opinión";
            this.buttonModificarOpinion.UseVisualStyleBackColor = true;
            this.buttonModificarOpinion.Click += new System.EventHandler(this.buttonModificarOpinion_Click);
            // 
            // comboBoxAlias
            // 
            this.comboBoxAlias.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxAlias.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxAlias.FormattingEnabled = true;
            this.comboBoxAlias.Location = new System.Drawing.Point(47, 19);
            this.comboBoxAlias.Name = "comboBoxAlias";
            this.comboBoxAlias.Size = new System.Drawing.Size(97, 21);
            this.comboBoxAlias.TabIndex = 49;
            // 
            // labelNota
            // 
            this.labelNota.AutoSize = true;
            this.labelNota.Location = new System.Drawing.Point(153, 27);
            this.labelNota.Name = "labelNota";
            this.labelNota.Size = new System.Drawing.Size(30, 13);
            this.labelNota.TabIndex = 51;
            this.labelNota.Text = "Nota";
            // 
            // textBoxNota
            // 
            this.textBoxNota.Enabled = false;
            this.textBoxNota.Location = new System.Drawing.Point(187, 20);
            this.textBoxNota.Name = "textBoxNota";
            this.textBoxNota.Size = new System.Drawing.Size(23, 20);
            this.textBoxNota.TabIndex = 52;
            this.textBoxNota.Tag = "";
            this.textBoxNota.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // groupBoxOpiniones
            // 
            this.groupBoxOpiniones.Controls.Add(this.textBoxMedia);
            this.groupBoxOpiniones.Controls.Add(this.labelMedia);
            this.groupBoxOpiniones.Controls.Add(this.textBoxOpiniones);
            this.groupBoxOpiniones.Controls.Add(this.buttonModificarOpinion);
            this.groupBoxOpiniones.Controls.Add(this.labelAutor);
            this.groupBoxOpiniones.Controls.Add(this.textBoxNota);
            this.groupBoxOpiniones.Controls.Add(this.labelNota);
            this.groupBoxOpiniones.Controls.Add(this.comboBoxAlias);
            this.groupBoxOpiniones.Location = new System.Drawing.Point(21, 133);
            this.groupBoxOpiniones.Name = "groupBoxOpiniones";
            this.groupBoxOpiniones.Size = new System.Drawing.Size(397, 215);
            this.groupBoxOpiniones.TabIndex = 50;
            this.groupBoxOpiniones.TabStop = false;
            this.groupBoxOpiniones.Text = "Opiniones";
            // 
            // textBoxMedia
            // 
            this.textBoxMedia.Enabled = false;
            this.textBoxMedia.Location = new System.Drawing.Point(257, 20);
            this.textBoxMedia.Name = "textBoxMedia";
            this.textBoxMedia.Size = new System.Drawing.Size(23, 20);
            this.textBoxMedia.TabIndex = 59;
            this.textBoxMedia.Tag = "";
            // 
            // labelMedia
            // 
            this.labelMedia.AutoSize = true;
            this.labelMedia.Location = new System.Drawing.Point(216, 27);
            this.labelMedia.Name = "labelMedia";
            this.labelMedia.Size = new System.Drawing.Size(36, 13);
            this.labelMedia.TabIndex = 58;
            this.labelMedia.Text = "Media";
            // 
            // textBoxOpiniones
            // 
            this.textBoxOpiniones.Location = new System.Drawing.Point(12, 46);
            this.textBoxOpiniones.Multiline = true;
            this.textBoxOpiniones.Name = "textBoxOpiniones";
            this.textBoxOpiniones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOpiniones.Size = new System.Drawing.Size(379, 159);
            this.textBoxOpiniones.TabIndex = 56;
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(9, 27);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(32, 13);
            this.labelAutor.TabIndex = 53;
            this.labelAutor.Text = "Autor";
            // 
            // buttonEscribirOpinión
            // 
            this.buttonEscribirOpinión.Location = new System.Drawing.Point(21, 354);
            this.buttonEscribirOpinión.Name = "buttonEscribirOpinión";
            this.buttonEscribirOpinión.Size = new System.Drawing.Size(397, 27);
            this.buttonEscribirOpinión.TabIndex = 60;
            this.buttonEscribirOpinión.Text = "Escribir Opinión";
            this.buttonEscribirOpinión.UseVisualStyleBackColor = true;
            this.buttonEscribirOpinión.Click += new System.EventHandler(this.buttonEscribirOpinión_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(21, 104);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(202, 23);
            this.buttonModificar.TabIndex = 57;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonUnidades
            // 
            this.buttonUnidades.Location = new System.Drawing.Point(229, 104);
            this.buttonUnidades.Name = "buttonUnidades";
            this.buttonUnidades.Size = new System.Drawing.Size(189, 23);
            this.buttonUnidades.TabIndex = 61;
            this.buttonUnidades.Text = "Ver unidades";
            this.buttonUnidades.UseVisualStyleBackColor = true;
            this.buttonUnidades.Click += new System.EventHandler(this.buttonUnidades_Click);
            // 
            // Ficha_de_juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 406);
            this.Controls.Add(this.buttonUnidades);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonEscribirOpinión);
            this.Controls.Add(this.groupBoxOpiniones);
            this.Controls.Add(this.groupBoxDatosJuego);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ficha_de_juego";
            this.Text = "Ficha de Juego";
            this.Load += new System.EventHandler(this.Ficha_de_juego_Load);
            this.groupBoxDatosJuego.ResumeLayout(false);
            this.groupBoxDatosJuego.PerformLayout();
            this.groupBoxOpiniones.ResumeLayout(false);
            this.groupBoxOpiniones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDatosJuego;
        private System.Windows.Forms.Button buttonModificarOpinion;
        private System.Windows.Forms.ComboBox comboBoxAlias;
        private System.Windows.Forms.Label labelNota;
        private System.Windows.Forms.TextBox textBoxNota;
        private System.Windows.Forms.GroupBox groupBoxOpiniones;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.TextBox textBoxOpiniones;
        private System.Windows.Forms.TextBox textBoxMedia;
        private System.Windows.Forms.Label labelMedia;
        private System.Windows.Forms.Button buttonEscribirOpinión;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.CheckBox checkBoxDisponible;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxPEGI;
        private System.Windows.Forms.Label labelPlataforma;
        private System.Windows.Forms.TextBox textBoxPlataforma;
        private System.Windows.Forms.TextBox textBoxGenero;
        private System.Windows.Forms.Label labelPEGI;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Button buttonUnidades;
    }
}