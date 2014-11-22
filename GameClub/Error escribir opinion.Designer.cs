namespace GameClub
{
    partial class Error_escribir_opinion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Error_escribir_opinion));
            this.labelErrorOpinión1 = new System.Windows.Forms.Label();
            this.labelErrorOpinión2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelErrorOpinión1
            // 
            this.labelErrorOpinión1.AutoSize = true;
            this.labelErrorOpinión1.Location = new System.Drawing.Point(24, 9);
            this.labelErrorOpinión1.Name = "labelErrorOpinión1";
            this.labelErrorOpinión1.Size = new System.Drawing.Size(196, 13);
            this.labelErrorOpinión1.TabIndex = 0;
            this.labelErrorOpinión1.Text = "No puedes escribir una opinión a menos";
            this.labelErrorOpinión1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelErrorOpinión2
            // 
            this.labelErrorOpinión2.AutoSize = true;
            this.labelErrorOpinión2.Location = new System.Drawing.Point(7, 22);
            this.labelErrorOpinión2.Name = "labelErrorOpinión2";
            this.labelErrorOpinión2.Size = new System.Drawing.Size(233, 13);
            this.labelErrorOpinión2.TabIndex = 1;
            this.labelErrorOpinión2.Text = "que hayas alquilado este juego o te pertenezca.";
            // 
            // Error_escribir_opinion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 46);
            this.Controls.Add(this.labelErrorOpinión2);
            this.Controls.Add(this.labelErrorOpinión1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Error_escribir_opinion";
            this.Text = "Error al escribir opinión";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Error_opinion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelErrorOpinión1;
        private System.Windows.Forms.Label labelErrorOpinión2;
    }
}