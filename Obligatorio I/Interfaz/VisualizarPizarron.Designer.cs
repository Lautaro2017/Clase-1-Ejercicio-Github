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
            this.tableLayoutPizarron = new System.Windows.Forms.TableLayoutPanel();
            this.lblAgregarElemento = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(590, 352);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 25);
            this.btnCancelar.TabIndex = 97;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(437, 352);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 25);
            this.btnGuardar.TabIndex = 96;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // cmbEquipo
            // 
            this.cmbEquipo.FormattingEnabled = true;
            this.cmbEquipo.Location = new System.Drawing.Point(109, 83);
            this.cmbEquipo.Name = "cmbEquipo";
            this.cmbEquipo.Size = new System.Drawing.Size(134, 21);
            this.cmbEquipo.TabIndex = 95;
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
            // tableLayoutPizarron
            // 
            this.tableLayoutPizarron.ColumnCount = 1;
            this.tableLayoutPizarron.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPizarron.Location = new System.Drawing.Point(293, 83);
            this.tableLayoutPizarron.Name = "tableLayoutPizarron";
            this.tableLayoutPizarron.RowCount = 1;
            this.tableLayoutPizarron.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPizarron.Size = new System.Drawing.Size(398, 235);
            this.tableLayoutPizarron.TabIndex = 103;
            // 
            // lblAgregarElemento
            // 
            this.lblAgregarElemento.AutoSize = true;
            this.lblAgregarElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarElemento.Location = new System.Drawing.Point(41, 292);
            this.lblAgregarElemento.Name = "lblAgregarElemento";
            this.lblAgregarElemento.Size = new System.Drawing.Size(126, 17);
            this.lblAgregarElemento.TabIndex = 104;
            this.lblAgregarElemento.Text = "Agregar Elemento:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Location = new System.Drawing.Point(44, 325);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(111, 25);
            this.toolStrip1.TabIndex = 105;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // VisualizarPizarron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblAgregarElemento);
            this.Controls.Add(this.tableLayoutPizarron);
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
            this.Size = new System.Drawing.Size(734, 402);
            this.Load += new System.EventHandler(this.VisualizarPizarron_Load);
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
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbPizarron;
        private System.Windows.Forms.Label lblPizarron;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPizarron;
        private System.Windows.Forms.Label lblAgregarElemento;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}
