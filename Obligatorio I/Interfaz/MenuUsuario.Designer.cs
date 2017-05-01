namespace Interfaz
{
    partial class MenuUsuario
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMenuUsuario = new System.Windows.Forms.Label();
            this.btnVerPizarrón = new System.Windows.Forms.Button();
            this.btnCrearPizarron = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenuUsuario
            // 
            this.lblMenuUsuario.AutoSize = true;
            this.lblMenuUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuUsuario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMenuUsuario.Location = new System.Drawing.Point(252, 54);
            this.lblMenuUsuario.Name = "lblMenuUsuario";
            this.lblMenuUsuario.Size = new System.Drawing.Size(146, 25);
            this.lblMenuUsuario.TabIndex = 86;
            this.lblMenuUsuario.Text = "Menú Usuario";
            this.lblMenuUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnVerPizarrón
            // 
            this.btnVerPizarrón.Location = new System.Drawing.Point(257, 141);
            this.btnVerPizarrón.Name = "btnVerPizarrón";
            this.btnVerPizarrón.Size = new System.Drawing.Size(127, 37);
            this.btnVerPizarrón.TabIndex = 103;
            this.btnVerPizarrón.Text = "Ver Pizarrón";
            this.btnVerPizarrón.UseVisualStyleBackColor = true;
            // 
            // btnCrearPizarron
            // 
            this.btnCrearPizarron.Location = new System.Drawing.Point(105, 141);
            this.btnCrearPizarron.Name = "btnCrearPizarron";
            this.btnCrearPizarron.Size = new System.Drawing.Size(127, 37);
            this.btnCrearPizarron.TabIndex = 102;
            this.btnCrearPizarron.Text = "Crear Pizarrón";
            this.btnCrearPizarron.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(500, 314);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 25);
            this.btnSalir.TabIndex = 104;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // MenuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerPizarrón);
            this.Controls.Add(this.btnCrearPizarron);
            this.Controls.Add(this.lblMenuUsuario);
            this.Name = "MenuUsuario";
            this.Size = new System.Drawing.Size(637, 366);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuUsuario;
        private System.Windows.Forms.Button btnVerPizarrón;
        private System.Windows.Forms.Button btnCrearPizarron;
        private System.Windows.Forms.Button btnSalir;
    }
}
