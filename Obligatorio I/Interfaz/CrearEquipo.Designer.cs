namespace Interfaz
{
    partial class CrearEquipo
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCrearEquipo = new System.Windows.Forms.Label();
            this.dateTimeFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCantMaxUsuarios = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 20);
            this.txtNombre.TabIndex = 44;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(61, 109);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 52;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(61, 146);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(86, 17);
            this.lblDescripcion.TabIndex = 49;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblCrearEquipo
            // 
            this.lblCrearEquipo.AutoSize = true;
            this.lblCrearEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearEquipo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCrearEquipo.Location = new System.Drawing.Point(216, 43);
            this.lblCrearEquipo.Name = "lblCrearEquipo";
            this.lblCrearEquipo.Size = new System.Drawing.Size(139, 25);
            this.lblCrearEquipo.TabIndex = 48;
            this.lblCrearEquipo.Text = "Crear Equipo";
            this.lblCrearEquipo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimeFechaCreacion
            // 
            this.dateTimeFechaCreacion.Enabled = false;
            this.dateTimeFechaCreacion.Location = new System.Drawing.Point(328, 133);
            this.dateTimeFechaCreacion.Name = "dateTimeFechaCreacion";
            this.dateTimeFechaCreacion.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFechaCreacion.TabIndex = 56;
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCreacion.Location = new System.Drawing.Point(325, 108);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(131, 17);
            this.lblFechaCreacion.TabIndex = 55;
            this.lblFechaCreacion.Text = "Fecha de Creación:";
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Location = new System.Drawing.Point(64, 176);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(206, 72);
            this.rtxtDescripcion.TabIndex = 57;
            this.rtxtDescripcion.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "Cantidad de Usuarios:";
            // 
            // cmbCantMaxUsuarios
            // 
            this.cmbCantMaxUsuarios.FormattingEnabled = true;
            this.cmbCantMaxUsuarios.Location = new System.Drawing.Point(476, 173);
            this.cmbCantMaxUsuarios.Name = "cmbCantMaxUsuarios";
            this.cmbCantMaxUsuarios.Size = new System.Drawing.Size(52, 21);
            this.cmbCantMaxUsuarios.TabIndex = 59;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(322, 288);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 25);
            this.btnCancelar.TabIndex = 61;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(169, 288);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 25);
            this.btnGuardar.TabIndex = 60;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // CrearEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbCantMaxUsuarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtDescripcion);
            this.Controls.Add(this.dateTimeFechaCreacion);
            this.Controls.Add(this.lblFechaCreacion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCrearEquipo);
            this.Name = "CrearEquipo";
            this.Size = new System.Drawing.Size(582, 347);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCrearEquipo;
        private System.Windows.Forms.DateTimePicker dateTimeFechaCreacion;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.RichTextBox rtxtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCantMaxUsuarios;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}
