namespace Interfaz
{
    partial class EliminarPizarron
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
            this.lblEliminarPizarron = new System.Windows.Forms.Label();
            this.lstPizarrones = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lstPizarrones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEliminarPizarron
            // 
            this.lblEliminarPizarron.AutoSize = true;
            this.lblEliminarPizarron.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarPizarron.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEliminarPizarron.Location = new System.Drawing.Point(218, 28);
            this.lblEliminarPizarron.Name = "lblEliminarPizarron";
            this.lblEliminarPizarron.Size = new System.Drawing.Size(173, 25);
            this.lblEliminarPizarron.TabIndex = 86;
            this.lblEliminarPizarron.Text = "Eliminar pizarrón";
            this.lblEliminarPizarron.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstPizarrones
            // 
            this.lstPizarrones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstPizarrones.Location = new System.Drawing.Point(125, 65);
            this.lstPizarrones.Name = "lstPizarrones";
            this.lstPizarrones.Size = new System.Drawing.Size(374, 244);
            this.lstPizarrones.TabIndex = 87;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(143, 333);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 88;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(406, 333);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 89;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // EliminarPizarron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lstPizarrones);
            this.Controls.Add(this.lblEliminarPizarron);
            this.Name = "EliminarPizarron";
            this.Size = new System.Drawing.Size(637, 366);
            ((System.ComponentModel.ISupportInitialize)(this.lstPizarrones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEliminarPizarron;
        private System.Windows.Forms.DataGridView lstPizarrones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
