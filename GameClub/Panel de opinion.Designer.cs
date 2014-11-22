namespace GameClub
{
    partial class Panel_de_opinión
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_de_opinión));
            this.textBoxNota = new System.Windows.Forms.TextBox();
            this.labelNota = new System.Windows.Forms.Label();
            this.buttonOpinionAceptar = new System.Windows.Forms.Button();
            this.textBoxOpinion = new System.Windows.Forms.TextBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNota
            // 
            this.textBoxNota.Location = new System.Drawing.Point(53, 237);
            this.textBoxNota.Name = "textBoxNota";
            this.textBoxNota.Size = new System.Drawing.Size(23, 20);
            this.textBoxNota.TabIndex = 59;
            this.textBoxNota.Tag = "";
            // 
            // labelNota
            // 
            this.labelNota.AutoSize = true;
            this.labelNota.Location = new System.Drawing.Point(19, 244);
            this.labelNota.Name = "labelNota";
            this.labelNota.Size = new System.Drawing.Size(30, 13);
            this.labelNota.TabIndex = 58;
            this.labelNota.Text = "Nota";
            // 
            // buttonOpinionAceptar
            // 
            this.buttonOpinionAceptar.Location = new System.Drawing.Point(82, 234);
            this.buttonOpinionAceptar.Name = "buttonOpinionAceptar";
            this.buttonOpinionAceptar.Size = new System.Drawing.Size(228, 25);
            this.buttonOpinionAceptar.TabIndex = 62;
            this.buttonOpinionAceptar.Text = "Aceptar";
            this.buttonOpinionAceptar.UseVisualStyleBackColor = true;
            this.buttonOpinionAceptar.Click += new System.EventHandler(this.buttonOpinionAceptar_Click);
            // 
            // textBoxOpinion
            // 
            this.textBoxOpinion.Location = new System.Drawing.Point(22, 43);
            this.textBoxOpinion.Multiline = true;
            this.textBoxOpinion.Name = "textBoxOpinion";
            this.textBoxOpinion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOpinion.Size = new System.Drawing.Size(288, 185);
            this.textBoxOpinion.TabIndex = 63;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Enabled = false;
            this.textBoxTitulo.Location = new System.Drawing.Point(60, 17);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(250, 20);
            this.textBoxTitulo.TabIndex = 66;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(19, 24);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(35, 13);
            this.labelTitulo.TabIndex = 65;
            this.labelTitulo.Text = "Título";
            // 
            // Panel_de_opinión
            // 
            this.AcceptButton = this.buttonOpinionAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 276);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.textBoxOpinion);
            this.Controls.Add(this.buttonOpinionAceptar);
            this.Controls.Add(this.textBoxNota);
            this.Controls.Add(this.labelNota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Panel_de_opinión";
            this.Text = "Panel de Opinión";
            this.Load += new System.EventHandler(this.Panel_de_opinión_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNota;
        private System.Windows.Forms.Label labelNota;
        private System.Windows.Forms.Button buttonOpinionAceptar;
        private System.Windows.Forms.TextBox textBoxOpinion;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label labelTitulo;
    }
}