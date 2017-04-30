namespace Ejcutable
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.indexMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuOpcionIniciarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpcionSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuOpcionAcercaDePlanilla = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(26, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 366);
            this.panel1.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indexMenu,
            this.ayudaMenu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(696, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // indexMenu
            // 
            this.indexMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.indexMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpcionIniciarSesion,
            this.menuOpcionSalir});
            this.indexMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.indexMenu.Name = "indexMenu";
            this.indexMenu.Size = new System.Drawing.Size(51, 22);
            this.indexMenu.Text = "Menú";
            // 
            // menuOpcionIniciarSesion
            // 
            this.menuOpcionIniciarSesion.Name = "menuOpcionIniciarSesion";
            this.menuOpcionIniciarSesion.Size = new System.Drawing.Size(152, 22);
            this.menuOpcionIniciarSesion.Text = "Iniciar Sesión";
            // 
            // menuOpcionSalir
            // 
            this.menuOpcionSalir.Name = "menuOpcionSalir";
            this.menuOpcionSalir.Size = new System.Drawing.Size(152, 22);
            this.menuOpcionSalir.Text = "Salir";
            // 
            // ayudaMenu
            // 
            this.ayudaMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ayudaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpcionAcercaDePlanilla});
            this.ayudaMenu.Image = ((System.Drawing.Image)(resources.GetObject("ayudaMenu.Image")));
            this.ayudaMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ayudaMenu.Name = "ayudaMenu";
            this.ayudaMenu.Size = new System.Drawing.Size(54, 22);
            this.ayudaMenu.Text = "Ayuda";
            // 
            // menuOpcionAcercaDePlanilla
            // 
            this.menuOpcionAcercaDePlanilla.Name = "menuOpcionAcercaDePlanilla";
            this.menuOpcionAcercaDePlanilla.Size = new System.Drawing.Size(167, 22);
            this.menuOpcionAcercaDePlanilla.Text = "Acerca de Planilla";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton indexMenu;
        private System.Windows.Forms.ToolStripMenuItem menuOpcionIniciarSesion;
        private System.Windows.Forms.ToolStripMenuItem menuOpcionSalir;
        private System.Windows.Forms.ToolStripDropDownButton ayudaMenu;
        private System.Windows.Forms.ToolStripMenuItem menuOpcionAcercaDePlanilla;
    }
}