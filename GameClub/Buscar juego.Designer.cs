namespace GameClub
{
    partial class Buscar_juego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar_juego));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.checkBoxDisponible = new System.Windows.Forms.CheckBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.labelPlataforma = new System.Windows.Forms.Label();
            this.labelPEGI = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelMedia = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.listBoxResultados = new System.Windows.Forms.ListBox();
            this.labelResultados = new System.Windows.Forms.Label();
            this.buttonAcceder = new System.Windows.Forms.Button();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.comboBoxNota = new System.Windows.Forms.ComboBox();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.comboBoxPlataforma = new System.Windows.Forms.ComboBox();
            this.comboBoxPEGI = new System.Windows.Forms.ComboBox();
            this.groupBoxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(5, 25);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(35, 13);
            this.labelTitulo.TabIndex = 48;
            this.labelTitulo.Text = "Título";
            // 
            // checkBoxDisponible
            // 
            this.checkBoxDisponible.AutoSize = true;
            this.checkBoxDisponible.Location = new System.Drawing.Point(333, 46);
            this.checkBoxDisponible.Name = "checkBoxDisponible";
            this.checkBoxDisponible.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxDisponible.Size = new System.Drawing.Size(75, 17);
            this.checkBoxDisponible.TabIndex = 6;
            this.checkBoxDisponible.Text = "Disponible";
            this.checkBoxDisponible.UseVisualStyleBackColor = true;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(43, 18);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(234, 20);
            this.textBoxTitulo.TabIndex = 1;
            // 
            // labelPlataforma
            // 
            this.labelPlataforma.AutoSize = true;
            this.labelPlataforma.Location = new System.Drawing.Point(5, 50);
            this.labelPlataforma.Name = "labelPlataforma";
            this.labelPlataforma.Size = new System.Drawing.Size(57, 13);
            this.labelPlataforma.TabIndex = 49;
            this.labelPlataforma.Text = "Plataforma";
            // 
            // labelPEGI
            // 
            this.labelPEGI.AutoSize = true;
            this.labelPEGI.Location = new System.Drawing.Point(173, 50);
            this.labelPEGI.Name = "labelPEGI";
            this.labelPEGI.Size = new System.Drawing.Size(32, 13);
            this.labelPEGI.TabIndex = 50;
            this.labelPEGI.Text = "PEGI";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(283, 25);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(42, 13);
            this.labelGenero.TabIndex = 51;
            this.labelGenero.Text = "Género";
            // 
            // labelMedia
            // 
            this.labelMedia.AutoSize = true;
            this.labelMedia.Location = new System.Drawing.Point(251, 50);
            this.labelMedia.Name = "labelMedia";
            this.labelMedia.Size = new System.Drawing.Size(36, 13);
            this.labelMedia.TabIndex = 60;
            this.labelMedia.Text = "Media";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(17, 83);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(417, 23);
            this.buttonBuscar.TabIndex = 62;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // listBoxResultados
            // 
            this.listBoxResultados.FormattingEnabled = true;
            this.listBoxResultados.Location = new System.Drawing.Point(17, 112);
            this.listBoxResultados.Name = "listBoxResultados";
            this.listBoxResultados.Size = new System.Drawing.Size(417, 121);
            this.listBoxResultados.TabIndex = 66;
            // 
            // labelResultados
            // 
            this.labelResultados.AutoSize = true;
            this.labelResultados.Location = new System.Drawing.Point(14, 148);
            this.labelResultados.Name = "labelResultados";
            this.labelResultados.Size = new System.Drawing.Size(60, 13);
            this.labelResultados.TabIndex = 65;
            this.labelResultados.Text = "Resultados";
            // 
            // buttonAcceder
            // 
            this.buttonAcceder.Location = new System.Drawing.Point(17, 239);
            this.buttonAcceder.Name = "buttonAcceder";
            this.buttonAcceder.Size = new System.Drawing.Size(417, 23);
            this.buttonAcceder.TabIndex = 64;
            this.buttonAcceder.Text = "Acceder";
            this.buttonAcceder.UseVisualStyleBackColor = true;
            this.buttonAcceder.Click += new System.EventHandler(this.buttonAcceder_Click);
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.comboBoxNota);
            this.groupBoxDatos.Controls.Add(this.comboBoxGenero);
            this.groupBoxDatos.Controls.Add(this.comboBoxPlataforma);
            this.groupBoxDatos.Controls.Add(this.comboBoxPEGI);
            this.groupBoxDatos.Controls.Add(this.labelMedia);
            this.groupBoxDatos.Controls.Add(this.labelTitulo);
            this.groupBoxDatos.Controls.Add(this.checkBoxDisponible);
            this.groupBoxDatos.Controls.Add(this.textBoxTitulo);
            this.groupBoxDatos.Controls.Add(this.labelPlataforma);
            this.groupBoxDatos.Controls.Add(this.labelPEGI);
            this.groupBoxDatos.Controls.Add(this.labelGenero);
            this.groupBoxDatos.Location = new System.Drawing.Point(17, 5);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(417, 72);
            this.groupBoxDatos.TabIndex = 68;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos";
            // 
            // comboBoxNota
            // 
            this.comboBoxNota.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxNota.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxNota.FormattingEnabled = true;
            this.comboBoxNota.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxNota.Location = new System.Drawing.Point(293, 42);
            this.comboBoxNota.Name = "comboBoxNota";
            this.comboBoxNota.Size = new System.Drawing.Size(34, 21);
            this.comboBoxNota.TabIndex = 5;
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxGenero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Items.AddRange(new object[] {
            "Acción",
            "Arcade",
            "Aventura",
            "Casual",
            "Conducción",
            "Deportes",
            "Educativo",
            "Estrategia",
            "Lucha",
            "MMO",
            "Otro",
            "Plataforma",
            "Puzzle",
            "Rol",
            "Simulación"});
            this.comboBoxGenero.Location = new System.Drawing.Point(331, 17);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(77, 21);
            this.comboBoxGenero.TabIndex = 2;
            // 
            // comboBoxPlataforma
            // 
            this.comboBoxPlataforma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPlataforma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPlataforma.FormattingEnabled = true;
            this.comboBoxPlataforma.Items.AddRange(new object[] {
            "Xbox360",
            "PlayStation 3",
            "Wii U",
            "PC",
            "PlayStation Vita",
            "Nintendo 3DS",
            "Xbox",
            "PlayStation 2",
            "Wii",
            "PSP",
            "Nintendo DS",
            "Otra"});
            this.comboBoxPlataforma.Location = new System.Drawing.Point(68, 42);
            this.comboBoxPlataforma.Name = "comboBoxPlataforma";
            this.comboBoxPlataforma.Size = new System.Drawing.Size(99, 21);
            this.comboBoxPlataforma.TabIndex = 3;
            // 
            // comboBoxPEGI
            // 
            this.comboBoxPEGI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPEGI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPEGI.FormattingEnabled = true;
            this.comboBoxPEGI.Items.AddRange(new object[] {
            "3",
            "7",
            "12",
            "16",
            "18"});
            this.comboBoxPEGI.Location = new System.Drawing.Point(211, 42);
            this.comboBoxPEGI.Name = "comboBoxPEGI";
            this.comboBoxPEGI.Size = new System.Drawing.Size(34, 21);
            this.comboBoxPEGI.TabIndex = 4;
            // 
            // Buscar_juego
            // 
            this.AcceptButton = this.buttonBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 278);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.listBoxResultados);
            this.Controls.Add(this.labelResultados);
            this.Controls.Add(this.buttonAcceder);
            this.Controls.Add(this.buttonBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Buscar_juego";
            this.Text = "Buscar Juego";
            this.Load += new System.EventHandler(this.Buscar_juego_Load);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.CheckBox checkBoxDisponible;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label labelPlataforma;
        private System.Windows.Forms.Label labelPEGI;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Label labelMedia;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.ListBox listBoxResultados;
        private System.Windows.Forms.Label labelResultados;
        private System.Windows.Forms.Button buttonAcceder;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.ComboBox comboBoxPEGI;
        private System.Windows.Forms.ComboBox comboBoxPlataforma;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.ComboBox comboBoxNota;
    }
}