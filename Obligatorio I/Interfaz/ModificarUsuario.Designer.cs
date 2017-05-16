namespace Interfaz
{
    partial class ModificarUsuario
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
            this.chkEsAdministrador = new System.Windows.Forms.CheckBox();
            this.dateTimeFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.lblConfirmarContraseña = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblModificarUsuario = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblElegirUsuario = new System.Windows.Forms.Label();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // chkEsAdministrador
            // 
            this.chkEsAdministrador.AutoSize = true;
            this.chkEsAdministrador.Enabled = false;
            this.chkEsAdministrador.Location = new System.Drawing.Point(334, 181);
            this.chkEsAdministrador.Name = "chkEsAdministrador";
            this.chkEsAdministrador.Size = new System.Drawing.Size(104, 17);
            this.chkEsAdministrador.TabIndex = 59;
            this.chkEsAdministrador.Text = "Es Administrador";
            this.chkEsAdministrador.UseVisualStyleBackColor = true;
            // 
            // dateTimeFechaNacimiento
            // 
            this.dateTimeFechaNacimiento.Enabled = false;
            this.dateTimeFechaNacimiento.Location = new System.Drawing.Point(334, 147);
            this.dateTimeFechaNacimiento.Name = "dateTimeFechaNacimiento";
            this.dateTimeFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFechaNacimiento.TabIndex = 58;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(88, 224);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(85, 17);
            this.lblContraseña.TabIndex = 57;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Enabled = false;
            this.txtContraseña.Location = new System.Drawing.Point(181, 223);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(134, 20);
            this.txtContraseña.TabIndex = 53;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(148, 122);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 20);
            this.txtNombre.TabIndex = 48;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(73, 122);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 55;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.Enabled = false;
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(181, 249);
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(134, 20);
            this.txtConfirmarContraseña.TabIndex = 56;
            this.txtConfirmarContraseña.UseSystemPasswordChar = true;
            // 
            // lblConfirmarContraseña
            // 
            this.lblConfirmarContraseña.AutoSize = true;
            this.lblConfirmarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarContraseña.Location = new System.Drawing.Point(23, 247);
            this.lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            this.lblConfirmarContraseña.Size = new System.Drawing.Size(150, 17);
            this.lblConfirmarContraseña.TabIndex = 54;
            this.lblConfirmarContraseña.Text = "Confirmar Contraseña:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(334, 307);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 25);
            this.btnCancelar.TabIndex = 61;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(181, 307);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 25);
            this.btnGuardar.TabIndex = 60;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(331, 122);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(145, 17);
            this.lblFechaNacimiento.TabIndex = 52;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(73, 179);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 51;
            this.lblEmail.Text = "Email:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(73, 149);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 17);
            this.lblApellido.TabIndex = 50;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblModificarUsuario
            // 
            this.lblModificarUsuario.AutoSize = true;
            this.lblModificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarUsuario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblModificarUsuario.Location = new System.Drawing.Point(186, 31);
            this.lblModificarUsuario.Name = "lblModificarUsuario";
            this.lblModificarUsuario.Size = new System.Drawing.Size(180, 25);
            this.lblModificarUsuario.TabIndex = 49;
            this.lblModificarUsuario.Text = "Modificar Usuario";
            this.lblModificarUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(148, 150);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(134, 20);
            this.txtApellido.TabIndex = 62;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(148, 178);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(134, 20);
            this.txtEmail.TabIndex = 63;
            // 
            // lblElegirUsuario
            // 
            this.lblElegirUsuario.AutoSize = true;
            this.lblElegirUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElegirUsuario.Location = new System.Drawing.Point(64, 85);
            this.lblElegirUsuario.Name = "lblElegirUsuario";
            this.lblElegirUsuario.Size = new System.Drawing.Size(109, 17);
            this.lblElegirUsuario.TabIndex = 64;
            this.lblElegirUsuario.Text = "Elija un usuario:";
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(191, 84);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(134, 21);
            this.cmbUsuarios.TabIndex = 96;
            this.cmbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cmbUsuarios_SelectedIndexChanged);
            // 
            // ModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.lblElegirUsuario);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.chkEsAdministrador);
            this.Controls.Add(this.dateTimeFechaNacimiento);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtConfirmarContraseña);
            this.Controls.Add(this.lblConfirmarContraseña);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblModificarUsuario);
            this.Name = "ModificarUsuario";
            this.Size = new System.Drawing.Size(557, 391);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEsAdministrador;
        private System.Windows.Forms.DateTimePicker dateTimeFechaNacimiento;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtConfirmarContraseña;
        private System.Windows.Forms.Label lblConfirmarContraseña;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblModificarUsuario;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblElegirUsuario;
        private System.Windows.Forms.ComboBox cmbUsuarios;
    }
}
