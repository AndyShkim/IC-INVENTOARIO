namespace WindowsFormsApplication1
{
    partial class Fm_main
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
            this.btn_prestamo = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_datos = new System.Windows.Forms.Button();
            this.btn_devolucion = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.añadirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioAnadir = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaAnadir = new System.Windows.Forms.ToolStripMenuItem();
            this.personalAnadir = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaAnadir = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.deshabilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perosnalDeshabilitar = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioDeshabilitar = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaDeshabilitar = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaDeshabilitar = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_prestamo
            // 
            this.btn_prestamo.Font = new System.Drawing.Font("Intel Clear Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prestamo.Location = new System.Drawing.Point(369, 123);
            this.btn_prestamo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_prestamo.Name = "btn_prestamo";
            this.btn_prestamo.Size = new System.Drawing.Size(176, 50);
            this.btn_prestamo.TabIndex = 0;
            this.btn_prestamo.Text = "Prestamo";
            this.btn_prestamo.UseVisualStyleBackColor = true;
            this.btn_prestamo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.Font = new System.Drawing.Font("Intel Clear Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin.Location = new System.Drawing.Point(369, 218);
            this.btn_admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(176, 46);
            this.btn_admin.TabIndex = 3;
            this.btn_admin.Text = "Administrar";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_datos
            // 
            this.btn_datos.Font = new System.Drawing.Font("Intel Clear Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datos.Location = new System.Drawing.Point(127, 218);
            this.btn_datos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_datos.Name = "btn_datos";
            this.btn_datos.Size = new System.Drawing.Size(195, 46);
            this.btn_datos.TabIndex = 2;
            this.btn_datos.Text = "Visualizar datos";
            this.btn_datos.UseVisualStyleBackColor = true;
            this.btn_datos.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_devolucion
            // 
            this.btn_devolucion.Font = new System.Drawing.Font("Intel Clear Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_devolucion.Location = new System.Drawing.Point(127, 123);
            this.btn_devolucion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_devolucion.Name = "btn_devolucion";
            this.btn_devolucion.Size = new System.Drawing.Size(195, 50);
            this.btn_devolucion.TabIndex = 1;
            this.btn_devolucion.Text = "Devolución";
            this.btn_devolucion.UseVisualStyleBackColor = true;
            this.btn_devolucion.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(48, 322);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(84, 35);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Regresar";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirMenu,
            this.actualizarActualizar,
            this.deshabilitarToolStripMenuItem,
            this.verToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(659, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // añadirMenu
            // 
            this.añadirMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioAnadir,
            this.personalAnadir,
            this.categoriaAnadir,
            this.marcaAnadir});
            this.añadirMenu.Name = "añadirMenu";
            this.añadirMenu.Size = new System.Drawing.Size(65, 24);
            this.añadirMenu.Text = "Añadir";
            // 
            // inventarioAnadir
            // 
            this.inventarioAnadir.Name = "inventarioAnadir";
            this.inventarioAnadir.Size = new System.Drawing.Size(216, 26);
            this.inventarioAnadir.Text = "Inventario";
            this.inventarioAnadir.Click += new System.EventHandler(this.inventarioAnadir_Click);
            // 
            // marcaAnadir
            // 
            this.marcaAnadir.Name = "marcaAnadir";
            this.marcaAnadir.Size = new System.Drawing.Size(216, 26);
            this.marcaAnadir.Text = "Marca";
            // 
            // personalAnadir
            // 
            this.personalAnadir.Name = "personalAnadir";
            this.personalAnadir.Size = new System.Drawing.Size(216, 26);
            this.personalAnadir.Text = "Personal";
            // 
            // categoriaAnadir
            // 
            this.categoriaAnadir.Name = "categoriaAnadir";
            this.categoriaAnadir.Size = new System.Drawing.Size(216, 26);
            this.categoriaAnadir.Text = "Categoria";
            // 
            // actualizarActualizar
            // 
            this.actualizarActualizar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioActualizar,
            this.personalToolStripMenuItem1,
            this.categoriaActualizar,
            this.marcaActualizar});
            this.actualizarActualizar.Name = "actualizarActualizar";
            this.actualizarActualizar.Size = new System.Drawing.Size(87, 24);
            this.actualizarActualizar.Text = "Actualizar";
            // 
            // inventarioActualizar
            // 
            this.inventarioActualizar.Name = "inventarioActualizar";
            this.inventarioActualizar.Size = new System.Drawing.Size(216, 26);
            this.inventarioActualizar.Text = "Inventario";
            this.inventarioActualizar.Click += new System.EventHandler(this.inventarioActualizar_Click);
            // 
            // personalToolStripMenuItem1
            // 
            this.personalToolStripMenuItem1.Name = "personalToolStripMenuItem1";
            this.personalToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.personalToolStripMenuItem1.Text = "Personal";
            // 
            // categoriaActualizar
            // 
            this.categoriaActualizar.Name = "categoriaActualizar";
            this.categoriaActualizar.Size = new System.Drawing.Size(216, 26);
            this.categoriaActualizar.Text = "Categoria";
            // 
            // marcaActualizar
            // 
            this.marcaActualizar.Name = "marcaActualizar";
            this.marcaActualizar.Size = new System.Drawing.Size(216, 26);
            this.marcaActualizar.Text = "Marca";
            // 
            // deshabilitarToolStripMenuItem
            // 
            this.deshabilitarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioDeshabilitar,
            this.perosnalDeshabilitar,
            this.categoriaDeshabilitar,
            this.marcaDeshabilitar});
            this.deshabilitarToolStripMenuItem.Name = "deshabilitarToolStripMenuItem";
            this.deshabilitarToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.deshabilitarToolStripMenuItem.Text = "Deshabilitar";
            // 
            // perosnalDeshabilitar
            // 
            this.perosnalDeshabilitar.Name = "perosnalDeshabilitar";
            this.perosnalDeshabilitar.Size = new System.Drawing.Size(216, 26);
            this.perosnalDeshabilitar.Text = "Personal";
            // 
            // inventarioDeshabilitar
            // 
            this.inventarioDeshabilitar.Name = "inventarioDeshabilitar";
            this.inventarioDeshabilitar.Size = new System.Drawing.Size(216, 26);
            this.inventarioDeshabilitar.Text = "Inventario";
            // 
            // marcaDeshabilitar
            // 
            this.marcaDeshabilitar.Name = "marcaDeshabilitar";
            this.marcaDeshabilitar.Size = new System.Drawing.Size(216, 26);
            this.marcaDeshabilitar.Text = "Marca";
            // 
            // categoriaDeshabilitar
            // 
            this.categoriaDeshabilitar.Name = "categoriaDeshabilitar";
            this.categoriaDeshabilitar.Size = new System.Drawing.Size(216, 26);
            this.categoriaDeshabilitar.Text = "Categoria";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(42, 24);
            this.verToolStripMenuItem.Text = "Ver";
            this.verToolStripMenuItem.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // Fm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 391);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_datos);
            this.Controls.Add(this.btn_devolucion);
            this.Controls.Add(this.btn_prestamo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Fm_main";
            this.Text = "Administrar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_prestamo;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_datos;
        private System.Windows.Forms.Button btn_devolucion;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem añadirMenu;
        private System.Windows.Forms.ToolStripMenuItem inventarioAnadir;
        private System.Windows.Forms.ToolStripMenuItem marcaAnadir;
        private System.Windows.Forms.ToolStripMenuItem personalAnadir;
        private System.Windows.Forms.ToolStripMenuItem categoriaAnadir;
        private System.Windows.Forms.ToolStripMenuItem actualizarActualizar;
        private System.Windows.Forms.ToolStripMenuItem inventarioActualizar;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoriaActualizar;
        private System.Windows.Forms.ToolStripMenuItem marcaActualizar;
        private System.Windows.Forms.ToolStripMenuItem deshabilitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perosnalDeshabilitar;
        private System.Windows.Forms.ToolStripMenuItem inventarioDeshabilitar;
        private System.Windows.Forms.ToolStripMenuItem marcaDeshabilitar;
        private System.Windows.Forms.ToolStripMenuItem categoriaDeshabilitar;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    }
}

