namespace Interfaz
{
    partial class VisualizarPizarron
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
            this.cmbEquipo = new System.Windows.Forms.ComboBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMenuPizarron = new System.Windows.Forms.Label();
            this.cmbPizarron = new System.Windows.Forms.ComboBox();
            this.lblPizarron = new System.Windows.Forms.Label();
            this.lblAgregarElemento = new System.Windows.Forms.Label();
            this.pnlPizarron = new System.Windows.Forms.Panel();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnCargarCuadroTexto = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(528, 343);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 25);
            this.btnCancelar.TabIndex = 97;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.Slider;
            this.btnGuardar.Location = new System.Drawing.Point(346, 343);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 25);
            this.btnGuardar.TabIndex = 96;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbEquipo
            // 
            this.cmbEquipo.FormattingEnabled = true;
            this.cmbEquipo.Location = new System.Drawing.Point(109, 83);
            this.cmbEquipo.Name = "cmbEquipo";
            this.cmbEquipo.Size = new System.Drawing.Size(134, 21);
            this.cmbEquipo.TabIndex = 95;
            this.cmbEquipo.SelectedIndexChanged += new System.EventHandler(this.cmbEquipo_SelectedIndexChanged);
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipo.Location = new System.Drawing.Point(40, 86);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(56, 17);
            this.lblEquipo.TabIndex = 94;
            this.lblEquipo.Text = "Equipo:";
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Enabled = false;
            this.rtxtDescripcion.Location = new System.Drawing.Point(44, 199);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(199, 58);
            this.rtxtDescripcion.TabIndex = 93;
            this.rtxtDescripcion.Text = "";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(41, 39);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(55, 17);
            this.lblUsuario.TabIndex = 91;
            this.lblUsuario.Text = "usuario";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(41, 167);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(86, 17);
            this.lblDescripcion.TabIndex = 90;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblMenuPizarron
            // 
            this.lblMenuPizarron.AutoSize = true;
            this.lblMenuPizarron.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuPizarron.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMenuPizarron.Location = new System.Drawing.Point(288, 32);
            this.lblMenuPizarron.Name = "lblMenuPizarron";
            this.lblMenuPizarron.Size = new System.Drawing.Size(193, 25);
            this.lblMenuPizarron.TabIndex = 88;
            this.lblMenuPizarron.Text = "Visualizar Pizarrón";
            this.lblMenuPizarron.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbPizarron
            // 
            this.cmbPizarron.FormattingEnabled = true;
            this.cmbPizarron.Location = new System.Drawing.Point(109, 121);
            this.cmbPizarron.Name = "cmbPizarron";
            this.cmbPizarron.Size = new System.Drawing.Size(134, 21);
            this.cmbPizarron.TabIndex = 102;
            this.cmbPizarron.SelectedIndexChanged += new System.EventHandler(this.cmbPizarron_SelectedIndexChanged);
            // 
            // lblPizarron
            // 
            this.lblPizarron.AutoSize = true;
            this.lblPizarron.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizarron.Location = new System.Drawing.Point(40, 124);
            this.lblPizarron.Name = "lblPizarron";
            this.lblPizarron.Size = new System.Drawing.Size(65, 17);
            this.lblPizarron.TabIndex = 101;
            this.lblPizarron.Text = "Pizarron:";
            // 
            // lblAgregarElemento
            // 
            this.lblAgregarElemento.AutoSize = true;
            this.lblAgregarElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarElemento.Location = new System.Drawing.Point(41, 285);
            this.lblAgregarElemento.Name = "lblAgregarElemento";
            this.lblAgregarElemento.Size = new System.Drawing.Size(126, 17);
            this.lblAgregarElemento.TabIndex = 104;
            this.lblAgregarElemento.Text = "Agregar Elemento:";
            // 
            // pnlPizarron
            // 
            this.pnlPizarron.Location = new System.Drawing.Point(289, 74);
            this.pnlPizarron.Name = "pnlPizarron";
            this.pnlPizarron.Size = new System.Drawing.Size(363, 240);
            this.pnlPizarron.TabIndex = 106;
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(44, 317);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(83, 37);
            this.btnCargarImagen.TabIndex = 107;
            this.btnCargarImagen.Text = "Cargar imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnCargarCuadroTexto
            // 
            this.btnCargarCuadroTexto.Location = new System.Drawing.Point(160, 317);
            this.btnCargarCuadroTexto.Name = "btnCargarCuadroTexto";
            this.btnCargarCuadroTexto.Size = new System.Drawing.Size(83, 37);
            this.btnCargarCuadroTexto.TabIndex = 108;
            this.btnCargarCuadroTexto.Text = "Cargar cuadro de texto";
            this.btnCargarCuadroTexto.UseVisualStyleBackColor = true;
            this.btnCargarCuadroTexto.Click += new System.EventHandler(this.btnCargarCuadroTexto_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(549, 32);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(86, 23);
            this.btnImprimir.TabIndex = 109;
            this.btnImprimir.Text = "Imprimir a PDF";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // VisualizarPizarron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCargarCuadroTexto);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.pnlPizarron);
            this.Controls.Add(this.lblAgregarElemento);
            this.Controls.Add(this.cmbPizarron);
            this.Controls.Add(this.lblPizarron);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbEquipo);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.rtxtDescripcion);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblMenuPizarron);
            this.Name = "VisualizarPizarron";
            this.Size = new System.Drawing.Size(667, 382);
            this.Load += new System.EventHandler(this.VisualizarPizarron_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VisualizarPizarron_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbEquipo;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.RichTextBox rtxtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMenuPizarron;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbPizarron;
        private System.Windows.Forms.Label lblPizarron;
        private System.Windows.Forms.Label lblAgregarElemento;
        private System.Windows.Forms.Panel pnlPizarron;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnCargarCuadroTexto;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
