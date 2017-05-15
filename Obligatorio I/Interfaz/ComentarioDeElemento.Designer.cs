namespace Interfaz
{
    partial class ComentarioDeElemento
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
            this.lblMenuComentario = new System.Windows.Forms.Label();
            this.rtxtComentario = new System.Windows.Forms.RichTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnListaComentarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenuComentario
            // 
            this.lblMenuComentario.AutoSize = true;
            this.lblMenuComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuComentario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMenuComentario.Location = new System.Drawing.Point(3, 28);
            this.lblMenuComentario.Name = "lblMenuComentario";
            this.lblMenuComentario.Size = new System.Drawing.Size(313, 25);
            this.lblMenuComentario.TabIndex = 89;
            this.lblMenuComentario.Text = "Agregar comentario a elemento";
            this.lblMenuComentario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rtxtComentario
            // 
            this.rtxtComentario.Location = new System.Drawing.Point(47, 82);
            this.rtxtComentario.Name = "rtxtComentario";
            this.rtxtComentario.Size = new System.Drawing.Size(222, 82);
            this.rtxtComentario.TabIndex = 94;
            this.rtxtComentario.Text = "";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(47, 203);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 95;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(194, 203);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 96;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnListaComentarios
            // 
            this.btnListaComentarios.Location = new System.Drawing.Point(95, 235);
            this.btnListaComentarios.Name = "btnListaComentarios";
            this.btnListaComentarios.Size = new System.Drawing.Size(125, 23);
            this.btnListaComentarios.TabIndex = 97;
            this.btnListaComentarios.Text = "Lista de comentarios";
            this.btnListaComentarios.UseVisualStyleBackColor = true;
            this.btnListaComentarios.Click += new System.EventHandler(this.btnListaComentarios_Click);
            // 
            // ComentarioDeElemento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnListaComentarios);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.rtxtComentario);
            this.Controls.Add(this.lblMenuComentario);
            this.Name = "ComentarioDeElemento";
            this.Size = new System.Drawing.Size(326, 292);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuComentario;
        private System.Windows.Forms.RichTextBox rtxtComentario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnListaComentarios;
    }
}
