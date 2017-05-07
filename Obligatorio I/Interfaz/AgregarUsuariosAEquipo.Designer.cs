namespace Interfaz
{
    partial class AgregarUsuariosAEquipo
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
            this.cmbEquipos = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lstUsuarioParaAgregar = new System.Windows.Forms.ListView();
            this.lstUsuariosAgregados = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblCrearEquipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbEquipos
            // 
            this.cmbEquipos.FormattingEnabled = true;
            this.cmbEquipos.Location = new System.Drawing.Point(33, 78);
            this.cmbEquipos.Name = "cmbEquipos";
            this.cmbEquipos.Size = new System.Drawing.Size(185, 21);
            this.cmbEquipos.TabIndex = 60;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(30, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 17);
            this.lblNombre.TabIndex = 61;
            this.lblNombre.Text = "Equipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "Usuarios para agregar:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 63;
            this.button1.Text = "->";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lstUsuarioParaAgregar
            // 
            this.lstUsuarioParaAgregar.Location = new System.Drawing.Point(36, 130);
            this.lstUsuarioParaAgregar.Name = "lstUsuarioParaAgregar";
            this.lstUsuarioParaAgregar.Size = new System.Drawing.Size(182, 164);
            this.lstUsuarioParaAgregar.TabIndex = 64;
            this.lstUsuarioParaAgregar.UseCompatibleStateImageBehavior = false;
            // 
            // lstUsuariosAgregados
            // 
            this.lstUsuariosAgregados.Location = new System.Drawing.Point(373, 130);
            this.lstUsuariosAgregados.Name = "lstUsuariosAgregados";
            this.lstUsuariosAgregados.Size = new System.Drawing.Size(182, 164);
            this.lstUsuariosAgregados.TabIndex = 65;
            this.lstUsuariosAgregados.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 66;
            this.label2.Text = "Usuarios agregados:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(338, 316);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 25);
            this.btnCancelar.TabIndex = 69;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(172, 316);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 25);
            this.btnGuardar.TabIndex = 68;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 23);
            this.button2.TabIndex = 70;
            this.button2.Text = "<-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblCrearEquipo
            // 
            this.lblCrearEquipo.AutoSize = true;
            this.lblCrearEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearEquipo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCrearEquipo.Location = new System.Drawing.Point(167, 31);
            this.lblCrearEquipo.Name = "lblCrearEquipo";
            this.lblCrearEquipo.Size = new System.Drawing.Size(255, 25);
            this.lblCrearEquipo.TabIndex = 71;
            this.lblCrearEquipo.Text = "Agregar usuario a equipo";
            this.lblCrearEquipo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AgregarUsuariosAEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCrearEquipo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstUsuariosAgregados);
            this.Controls.Add(this.lstUsuarioParaAgregar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cmbEquipos);
            this.Name = "AgregarUsuariosAEquipo";
            this.Size = new System.Drawing.Size(582, 347);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbEquipos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lstUsuarioParaAgregar;
        private System.Windows.Forms.ListView lstUsuariosAgregados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblCrearEquipo;
    }
}
