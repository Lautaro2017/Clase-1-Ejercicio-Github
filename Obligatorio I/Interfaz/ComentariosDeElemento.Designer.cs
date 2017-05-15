namespace Interfaz
{
    partial class ComentariosDeElemento
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
            this.lblComentariosDeElemento = new System.Windows.Forms.Label();
            this.lstComentarios = new System.Windows.Forms.DataGridView();
            this.btnResolver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lstComentarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblComentariosDeElemento
            // 
            this.lblComentariosDeElemento.AutoSize = true;
            this.lblComentariosDeElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentariosDeElemento.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblComentariosDeElemento.Location = new System.Drawing.Point(31, 23);
            this.lblComentariosDeElemento.Name = "lblComentariosDeElemento";
            this.lblComentariosDeElemento.Size = new System.Drawing.Size(335, 25);
            this.lblComentariosDeElemento.TabIndex = 90;
            this.lblComentariosDeElemento.Text = "Lista de comentarios de elemento";
            this.lblComentariosDeElemento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstComentarios
            // 
            this.lstComentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstComentarios.Location = new System.Drawing.Point(10, 69);
            this.lstComentarios.MultiSelect = false;
            this.lstComentarios.Name = "lstComentarios";
            this.lstComentarios.Size = new System.Drawing.Size(350, 218);
            this.lstComentarios.TabIndex = 129;
            this.lstComentarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstComentarios_CellContentClick);
            this.lstComentarios.SelectionChanged += new System.EventHandler(this.lstComentarios_SelectionChanged);
            // 
            // btnResolver
            // 
            this.btnResolver.Enabled = false;
            this.btnResolver.Location = new System.Drawing.Point(36, 306);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(75, 23);
            this.btnResolver.TabIndex = 130;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.UseVisualStyleBackColor = true;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 131;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComentariosDeElemento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.lstComentarios);
            this.Controls.Add(this.lblComentariosDeElemento);
            this.Name = "ComentariosDeElemento";
            this.Size = new System.Drawing.Size(371, 357);
            ((System.ComponentModel.ISupportInitialize)(this.lstComentarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComentariosDeElemento;
        private System.Windows.Forms.DataGridView lstComentarios;
        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.Button button1;
    }
}
