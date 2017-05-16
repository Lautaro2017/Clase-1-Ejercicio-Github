namespace Interfaz
{
    partial class ModificarEquipo
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
            this.cmbCantMaxUsuarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.dateTimeFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblModificarEquipo = new System.Windows.Forms.Label();
            this.lblElegirEquipo = new System.Windows.Forms.Label();
            this.cmbModificarEquipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(292, 316);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 25);
            this.btnCancelar.TabIndex = 72;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(139, 316);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 25);
            this.btnGuardar.TabIndex = 71;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbCantMaxUsuarios
            // 
            this.cmbCantMaxUsuarios.FormattingEnabled = true;
            this.cmbCantMaxUsuarios.Location = new System.Drawing.Point(446, 202);
            this.cmbCantMaxUsuarios.Name = "cmbCantMaxUsuarios";
            this.cmbCantMaxUsuarios.Size = new System.Drawing.Size(52, 21);
            this.cmbCantMaxUsuarios.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 69;
            this.label1.Text = "Cantidad de Usuarios:";
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Location = new System.Drawing.Point(34, 204);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(206, 72);
            this.rtxtDescripcion.TabIndex = 68;
            this.rtxtDescripcion.Text = "";
            // 
            // dateTimeFechaCreacion
            // 
            this.dateTimeFechaCreacion.Enabled = false;
            this.dateTimeFechaCreacion.Location = new System.Drawing.Point(298, 161);
            this.dateTimeFechaCreacion.Name = "dateTimeFechaCreacion";
            this.dateTimeFechaCreacion.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFechaCreacion.TabIndex = 67;
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCreacion.Location = new System.Drawing.Point(295, 136);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(131, 17);
            this.lblFechaCreacion.TabIndex = 66;
            this.lblFechaCreacion.Text = "Fecha de Creación:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(106, 137);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 20);
            this.txtNombre.TabIndex = 62;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(31, 137);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 65;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(31, 174);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(86, 17);
            this.lblDescripcion.TabIndex = 64;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblModificarEquipo
            // 
            this.lblModificarEquipo.AutoSize = true;
            this.lblModificarEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarEquipo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblModificarEquipo.Location = new System.Drawing.Point(194, 30);
            this.lblModificarEquipo.Name = "lblModificarEquipo";
            this.lblModificarEquipo.Size = new System.Drawing.Size(171, 25);
            this.lblModificarEquipo.TabIndex = 63;
            this.lblModificarEquipo.Text = "Modificar equipo";
            this.lblModificarEquipo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblElegirEquipo
            // 
            this.lblElegirEquipo.AutoSize = true;
            this.lblElegirEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElegirEquipo.Location = new System.Drawing.Point(31, 89);
            this.lblElegirEquipo.Name = "lblElegirEquipo";
            this.lblElegirEquipo.Size = new System.Drawing.Size(95, 17);
            this.lblElegirEquipo.TabIndex = 73;
            this.lblElegirEquipo.Text = "Elegir equipo:";
            // 
            // cmbModificarEquipo
            // 
            this.cmbModificarEquipo.FormattingEnabled = true;
            this.cmbModificarEquipo.Location = new System.Drawing.Point(139, 89);
            this.cmbModificarEquipo.Name = "cmbModificarEquipo";
            this.cmbModificarEquipo.Size = new System.Drawing.Size(101, 21);
            this.cmbModificarEquipo.TabIndex = 74;
            this.cmbModificarEquipo.SelectedIndexChanged += new System.EventHandler(this.cmbModificarEquipo_SelectedIndexChanged);
            // 
            // ModificarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbModificarEquipo);
            this.Controls.Add(this.lblElegirEquipo);
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
            this.Controls.Add(this.lblModificarEquipo);
            this.Name = "ModificarEquipo";
            this.Size = new System.Drawing.Size(527, 412);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbCantMaxUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtDescripcion;
        private System.Windows.Forms.DateTimePicker dateTimeFechaCreacion;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblModificarEquipo;
        private System.Windows.Forms.Label lblElegirEquipo;
        private System.Windows.Forms.ComboBox cmbModificarEquipo;
    }
}
