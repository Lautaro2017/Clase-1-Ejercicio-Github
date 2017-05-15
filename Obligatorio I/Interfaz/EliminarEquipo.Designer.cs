namespace Interfaz
{
    partial class EliminarEquipo
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lstEquipos = new System.Windows.Forms.DataGridView();
            this.lblEliminarEquipo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lstEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(345, 325);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 93;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(82, 325);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 92;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lstEquipos
            // 
            this.lstEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstEquipos.Location = new System.Drawing.Point(64, 57);
            this.lstEquipos.Name = "lstEquipos";
            this.lstEquipos.Size = new System.Drawing.Size(374, 244);
            this.lstEquipos.TabIndex = 91;
            // 
            // lblEliminarEquipo
            // 
            this.lblEliminarEquipo.AutoSize = true;
            this.lblEliminarEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarEquipo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEliminarEquipo.Location = new System.Drawing.Point(157, 20);
            this.lblEliminarEquipo.Name = "lblEliminarEquipo";
            this.lblEliminarEquipo.Size = new System.Drawing.Size(160, 25);
            this.lblEliminarEquipo.TabIndex = 90;
            this.lblEliminarEquipo.Text = "Eliminar equipo";
            this.lblEliminarEquipo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EliminarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lstEquipos);
            this.Controls.Add(this.lblEliminarEquipo);
            this.Name = "EliminarEquipo";
            this.Size = new System.Drawing.Size(503, 369);
            ((System.ComponentModel.ISupportInitialize)(this.lstEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView lstEquipos;
        private System.Windows.Forms.Label lblEliminarEquipo;
    }
}
