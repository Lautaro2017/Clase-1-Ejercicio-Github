namespace Interfaz
{
    partial class InformeComentariosPorUsuario
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
            this.lblInformeComentarios = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dateTimeFechaResuelto = new System.Windows.Forms.DateTimePicker();
            this.lblFechaResuelto = new System.Windows.Forms.Label();
            this.cmbUsuarioQueResuelve = new System.Windows.Forms.ComboBox();
            this.lblUsuarioQueResuelve = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lstPizarrones = new System.Windows.Forms.ListBox();
            this.cmbUsuarioCreador = new System.Windows.Forms.ComboBox();
            this.lblUsuarioCreador = new System.Windows.Forms.Label();
            this.dateTimeFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInformeComentarios
            // 
            this.lblInformeComentarios.AutoSize = true;
            this.lblInformeComentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformeComentarios.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblInformeComentarios.Location = new System.Drawing.Point(94, 40);
            this.lblInformeComentarios.Name = "lblInformeComentarios";
            this.lblInformeComentarios.Size = new System.Drawing.Size(460, 25);
            this.lblInformeComentarios.TabIndex = 87;
            this.lblInformeComentarios.Text = "Informe de Comentarios Resueltos por Usuario";
            this.lblInformeComentarios.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(376, 320);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 25);
            this.btnBuscar.TabIndex = 125;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dateTimeFechaResuelto
            // 
            this.dateTimeFechaResuelto.Enabled = false;
            this.dateTimeFechaResuelto.Location = new System.Drawing.Point(54, 246);
            this.dateTimeFechaResuelto.Name = "dateTimeFechaResuelto";
            this.dateTimeFechaResuelto.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFechaResuelto.TabIndex = 124;
            // 
            // lblFechaResuelto
            // 
            this.lblFechaResuelto.AutoSize = true;
            this.lblFechaResuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaResuelto.Location = new System.Drawing.Point(51, 221);
            this.lblFechaResuelto.Name = "lblFechaResuelto";
            this.lblFechaResuelto.Size = new System.Drawing.Size(131, 17);
            this.lblFechaResuelto.TabIndex = 123;
            this.lblFechaResuelto.Text = "Fecha de Resuelto:";
            // 
            // cmbUsuarioQueResuelve
            // 
            this.cmbUsuarioQueResuelve.FormattingEnabled = true;
            this.cmbUsuarioQueResuelve.Location = new System.Drawing.Point(54, 294);
            this.cmbUsuarioQueResuelve.Name = "cmbUsuarioQueResuelve";
            this.cmbUsuarioQueResuelve.Size = new System.Drawing.Size(149, 21);
            this.cmbUsuarioQueResuelve.TabIndex = 122;
            // 
            // lblUsuarioQueResuelve
            // 
            this.lblUsuarioQueResuelve.AutoSize = true;
            this.lblUsuarioQueResuelve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioQueResuelve.Location = new System.Drawing.Point(51, 274);
            this.lblUsuarioQueResuelve.Name = "lblUsuarioQueResuelve";
            this.lblUsuarioQueResuelve.Size = new System.Drawing.Size(152, 17);
            this.lblUsuarioQueResuelve.TabIndex = 121;
            this.lblUsuarioQueResuelve.Text = "Usuario que Resuelve:";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(495, 320);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(101, 25);
            this.btnAtras.TabIndex = 120;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // lstPizarrones
            // 
            this.lstPizarrones.FormattingEnabled = true;
            this.lstPizarrones.Location = new System.Drawing.Point(289, 106);
            this.lstPizarrones.Name = "lstPizarrones";
            this.lstPizarrones.Size = new System.Drawing.Size(307, 199);
            this.lstPizarrones.TabIndex = 119;
            // 
            // cmbUsuarioCreador
            // 
            this.cmbUsuarioCreador.FormattingEnabled = true;
            this.cmbUsuarioCreador.Location = new System.Drawing.Point(54, 180);
            this.cmbUsuarioCreador.Name = "cmbUsuarioCreador";
            this.cmbUsuarioCreador.Size = new System.Drawing.Size(149, 21);
            this.cmbUsuarioCreador.TabIndex = 118;
            // 
            // lblUsuarioCreador
            // 
            this.lblUsuarioCreador.AutoSize = true;
            this.lblUsuarioCreador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioCreador.Location = new System.Drawing.Point(51, 160);
            this.lblUsuarioCreador.Name = "lblUsuarioCreador";
            this.lblUsuarioCreador.Size = new System.Drawing.Size(116, 17);
            this.lblUsuarioCreador.TabIndex = 117;
            this.lblUsuarioCreador.Text = "Usuario Creador:";
            // 
            // dateTimeFechaCreacion
            // 
            this.dateTimeFechaCreacion.Enabled = false;
            this.dateTimeFechaCreacion.Location = new System.Drawing.Point(54, 131);
            this.dateTimeFechaCreacion.Name = "dateTimeFechaCreacion";
            this.dateTimeFechaCreacion.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFechaCreacion.TabIndex = 116;
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCreacion.Location = new System.Drawing.Point(51, 106);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(131, 17);
            this.lblFechaCreacion.TabIndex = 115;
            this.lblFechaCreacion.Text = "Fecha de Creación:";
            // 
            // InformeComentariosPorUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dateTimeFechaResuelto);
            this.Controls.Add(this.lblFechaResuelto);
            this.Controls.Add(this.cmbUsuarioQueResuelve);
            this.Controls.Add(this.lblUsuarioQueResuelve);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lstPizarrones);
            this.Controls.Add(this.cmbUsuarioCreador);
            this.Controls.Add(this.lblUsuarioCreador);
            this.Controls.Add(this.dateTimeFechaCreacion);
            this.Controls.Add(this.lblFechaCreacion);
            this.Controls.Add(this.lblInformeComentarios);
            this.Name = "InformeComentariosPorUsuario";
            this.Size = new System.Drawing.Size(637, 366);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformeComentarios;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dateTimeFechaResuelto;
        private System.Windows.Forms.Label lblFechaResuelto;
        private System.Windows.Forms.ComboBox cmbUsuarioQueResuelve;
        private System.Windows.Forms.Label lblUsuarioQueResuelve;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.ListBox lstPizarrones;
        private System.Windows.Forms.DateTimePicker dateTimeFechaCreacion;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.Label lblUsuarioCreador;
        private System.Windows.Forms.ComboBox cmbUsuarioCreador;
    }
}
