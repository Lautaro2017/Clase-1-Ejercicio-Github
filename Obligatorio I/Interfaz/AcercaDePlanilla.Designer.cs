namespace Interfaz
{
    partial class AcercaDePlanilla
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
            this.btnOK = new System.Windows.Forms.Button();
            this.lblAbout3 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAbout2 = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(403, 222);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblAbout3
            // 
            this.lblAbout3.AutoSize = true;
            this.lblAbout3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout3.Location = new System.Drawing.Point(84, 201);
            this.lblAbout3.Name = "lblAbout3";
            this.lblAbout3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAbout3.Size = new System.Drawing.Size(230, 16);
            this.lblAbout3.TabIndex = 19;
            this.lblAbout3.Text = "Todos los derechos reservados";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(163, 55);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(186, 25);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Acerca de Planilla";
            // 
            // lblAbout2
            // 
            this.lblAbout2.AutoSize = true;
            this.lblAbout2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout2.Location = new System.Drawing.Point(83, 154);
            this.lblAbout2.Name = "lblAbout2";
            this.lblAbout2.Size = new System.Drawing.Size(229, 24);
            this.lblAbout2.TabIndex = 17;
            this.lblAbout2.Text = "aplicación para obligatorio";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(80, 115);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(199, 24);
            this.lblCopyright.TabIndex = 16;
            this.lblCopyright.Text = "Copyright Planilla 2017";
            // 
            // AcercaDePlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblAbout3);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblAbout2);
            this.Controls.Add(this.lblCopyright);
            this.Name = "AcercaDePlanilla";
            this.Size = new System.Drawing.Size(507, 280);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblAbout3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAbout2;
        private System.Windows.Forms.Label lblCopyright;
    }
}
