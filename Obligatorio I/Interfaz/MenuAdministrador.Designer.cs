namespace Interfaz
{
    partial class MenuAdministrador
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnInformeComentario = new System.Windows.Forms.Button();
            this.btnInformePizarron = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVerPizarrón = new System.Windows.Forms.Button();
            this.btnCrearPizarron = new System.Windows.Forms.Button();
            this.btnCrearEquipo = new System.Windows.Forms.Button();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarPizarron = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarEquipo = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnModificarEquipo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMenu.Location = new System.Drawing.Point(218, 48);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(205, 25);
            this.lblMenu.TabIndex = 85;
            this.lblMenu.Text = "Menú Administrador";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnInformeComentario
            // 
            this.btnInformeComentario.Location = new System.Drawing.Point(399, 164);
            this.btnInformeComentario.Name = "btnInformeComentario";
            this.btnInformeComentario.Size = new System.Drawing.Size(127, 37);
            this.btnInformeComentario.TabIndex = 104;
            this.btnInformeComentario.Text = "Informe Comentario por Usuario";
            this.btnInformeComentario.UseVisualStyleBackColor = true;
            this.btnInformeComentario.Click += new System.EventHandler(this.btnInformeComentario_Click);
            // 
            // btnInformePizarron
            // 
            this.btnInformePizarron.Location = new System.Drawing.Point(399, 112);
            this.btnInformePizarron.Name = "btnInformePizarron";
            this.btnInformePizarron.Size = new System.Drawing.Size(127, 37);
            this.btnInformePizarron.TabIndex = 103;
            this.btnInformePizarron.Text = "Informe Pizarron por Equipo";
            this.btnInformePizarron.UseVisualStyleBackColor = true;
            this.btnInformePizarron.Click += new System.EventHandler(this.btnInformePizarron_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(478, 313);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 27);
            this.btnSalir.TabIndex = 102;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVerPizarrón
            // 
            this.btnVerPizarrón.Location = new System.Drawing.Point(256, 164);
            this.btnVerPizarrón.Name = "btnVerPizarrón";
            this.btnVerPizarrón.Size = new System.Drawing.Size(127, 37);
            this.btnVerPizarrón.TabIndex = 101;
            this.btnVerPizarrón.Text = "Ver Pizarrón";
            this.btnVerPizarrón.UseVisualStyleBackColor = true;
            this.btnVerPizarrón.Click += new System.EventHandler(this.btnVerPizarrón_Click);
            // 
            // btnCrearPizarron
            // 
            this.btnCrearPizarron.Location = new System.Drawing.Point(256, 112);
            this.btnCrearPizarron.Name = "btnCrearPizarron";
            this.btnCrearPizarron.Size = new System.Drawing.Size(127, 37);
            this.btnCrearPizarron.TabIndex = 100;
            this.btnCrearPizarron.Text = "Crear Pizarrón";
            this.btnCrearPizarron.UseVisualStyleBackColor = true;
            this.btnCrearPizarron.Click += new System.EventHandler(this.btnCrearPizarron_Click);
            // 
            // btnCrearEquipo
            // 
            this.btnCrearEquipo.Location = new System.Drawing.Point(100, 164);
            this.btnCrearEquipo.Name = "btnCrearEquipo";
            this.btnCrearEquipo.Size = new System.Drawing.Size(127, 37);
            this.btnCrearEquipo.TabIndex = 99;
            this.btnCrearEquipo.Text = "Crear Equipo";
            this.btnCrearEquipo.UseVisualStyleBackColor = true;
            this.btnCrearEquipo.Click += new System.EventHandler(this.btnCrearEquipo_Click);
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Location = new System.Drawing.Point(100, 112);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(127, 37);
            this.btnCrearUsuario.TabIndex = 98;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(100, 207);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(127, 37);
            this.btnAgregarUsuario.TabIndex = 105;
            this.btnAgregarUsuario.Text = "Agrega usuario a equipo";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnEliminarPizarron
            // 
            this.btnEliminarPizarron.Location = new System.Drawing.Point(256, 207);
            this.btnEliminarPizarron.Name = "btnEliminarPizarron";
            this.btnEliminarPizarron.Size = new System.Drawing.Size(127, 37);
            this.btnEliminarPizarron.TabIndex = 106;
            this.btnEliminarPizarron.Text = "Eliminar pizarrón";
            this.btnEliminarPizarron.UseVisualStyleBackColor = true;
            this.btnEliminarPizarron.Click += new System.EventHandler(this.btnEliminarPizarron_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(399, 207);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(127, 37);
            this.btnEliminarUsuario.TabIndex = 107;
            this.btnEliminarUsuario.Text = "Eliminar usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnEliminarEquipo
            // 
            this.btnEliminarEquipo.Location = new System.Drawing.Point(100, 250);
            this.btnEliminarEquipo.Name = "btnEliminarEquipo";
            this.btnEliminarEquipo.Size = new System.Drawing.Size(127, 37);
            this.btnEliminarEquipo.TabIndex = 108;
            this.btnEliminarEquipo.Text = "Eliminar equipo";
            this.btnEliminarEquipo.UseVisualStyleBackColor = true;
            this.btnEliminarEquipo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Location = new System.Drawing.Point(256, 250);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(127, 37);
            this.btnModificarUsuario.TabIndex = 109;
            this.btnModificarUsuario.Text = "Modificar usuario";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnModificarEquipo
            // 
            this.btnModificarEquipo.Location = new System.Drawing.Point(399, 250);
            this.btnModificarEquipo.Name = "btnModificarEquipo";
            this.btnModificarEquipo.Size = new System.Drawing.Size(127, 37);
            this.btnModificarEquipo.TabIndex = 110;
            this.btnModificarEquipo.Text = "Modificar equipo";
            this.btnModificarEquipo.UseVisualStyleBackColor = true;
            this.btnModificarEquipo.Click += new System.EventHandler(this.btnModificarEquipo_Click);
            // 
            // MenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnModificarEquipo);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.btnEliminarEquipo);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnEliminarPizarron);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.btnInformeComentario);
            this.Controls.Add(this.btnInformePizarron);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerPizarrón);
            this.Controls.Add(this.btnCrearPizarron);
            this.Controls.Add(this.btnCrearEquipo);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.lblMenu);
            this.Name = "MenuAdministrador";
            this.Size = new System.Drawing.Size(637, 366);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnInformeComentario;
        private System.Windows.Forms.Button btnInformePizarron;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVerPizarrón;
        private System.Windows.Forms.Button btnCrearPizarron;
        private System.Windows.Forms.Button btnCrearEquipo;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnEliminarPizarron;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnEliminarEquipo;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnModificarEquipo;
    }
}
