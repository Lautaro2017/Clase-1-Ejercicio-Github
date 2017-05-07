namespace Interfaz
{
    partial class InformePizarronesPorEquipo
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
            this.lblInformePizarrones = new System.Windows.Forms.Label();
            this.dateTimeFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.cmbEquipo = new System.Windows.Forms.ComboBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.lstPizarrones = new System.Windows.Forms.ListBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInformePizarrones
            // 
            this.lblInformePizarrones.AutoSize = true;
            this.lblInformePizarrones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformePizarrones.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblInformePizarrones.Location = new System.Drawing.Point(116, 53);
            this.lblInformePizarrones.Name = "lblInformePizarrones";
            this.lblInformePizarrones.Size = new System.Drawing.Size(421, 25);
            this.lblInformePizarrones.TabIndex = 86;
            this.lblInformePizarrones.Text = "Informe de Pizarrónes Creados por Equipo";
            this.lblInformePizarrones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimeFechaCreacion
            // 
            this.dateTimeFechaCreacion.Enabled = false;
            this.dateTimeFechaCreacion.Location = new System.Drawing.Point(55, 148);
            this.dateTimeFechaCreacion.Name = "dateTimeFechaCreacion";
            this.dateTimeFechaCreacion.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFechaCreacion.TabIndex = 88;
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCreacion.Location = new System.Drawing.Point(52, 123);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(131, 17);
            this.lblFechaCreacion.TabIndex = 87;
            this.lblFechaCreacion.Text = "Fecha de Creación:";
            // 
            // cmbEquipo
            // 
            this.cmbEquipo.FormattingEnabled = true;
            this.cmbEquipo.Location = new System.Drawing.Point(121, 187);
            this.cmbEquipo.Name = "cmbEquipo";
            this.cmbEquipo.Size = new System.Drawing.Size(134, 21);
            this.cmbEquipo.TabIndex = 90;
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipo.Location = new System.Drawing.Point(52, 190);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(56, 17);
            this.lblEquipo.TabIndex = 89;
            this.lblEquipo.Text = "Equipo:";
            // 
            // lstPizarrones
            // 
            this.lstPizarrones.FormattingEnabled = true;
            this.lstPizarrones.Location = new System.Drawing.Point(288, 123);
            this.lstPizarrones.Name = "lstPizarrones";
            this.lstPizarrones.Size = new System.Drawing.Size(307, 173);
            this.lstPizarrones.TabIndex = 91;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(494, 319);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(101, 25);
            this.btnAtras.TabIndex = 103;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(373, 319);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 25);
            this.btnBuscar.TabIndex = 126;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // InformePizarronesPorEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lstPizarrones);
            this.Controls.Add(this.cmbEquipo);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.dateTimeFechaCreacion);
            this.Controls.Add(this.lblFechaCreacion);
            this.Controls.Add(this.lblInformePizarrones);
            this.Name = "InformePizarronesPorEquipo";
            this.Size = new System.Drawing.Size(637, 366);
            this.Load += new System.EventHandler(this.InformePizarronesPorEquipo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformePizarrones;
        private System.Windows.Forms.DateTimePicker dateTimeFechaCreacion;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.ComboBox cmbEquipo;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.ListBox lstPizarrones;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnBuscar;
    }
}
