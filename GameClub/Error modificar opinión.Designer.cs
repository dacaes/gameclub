namespace GameClub
{
    partial class Error_modificar_opinión
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Error_modificar_opinión));
            this.labelErrorOpinion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelErrorOpinion
            // 
            this.labelErrorOpinion.AutoSize = true;
            this.labelErrorOpinion.Location = new System.Drawing.Point(12, 9);
            this.labelErrorOpinion.Name = "labelErrorOpinion";
            this.labelErrorOpinion.Size = new System.Drawing.Size(272, 13);
            this.labelErrorOpinion.TabIndex = 0;
            this.labelErrorOpinion.Text = "Esta opinión no la has escrito tú, no la puedes modificar.";
            // 
            // Error_modificar_opinión
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 29);
            this.Controls.Add(this.labelErrorOpinion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Error_modificar_opinión";
            this.Text = "Error modificar opinión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelErrorOpinion;
    }
}