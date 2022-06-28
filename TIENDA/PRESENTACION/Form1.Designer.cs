namespace TIENDA
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pBarraTitulo = new System.Windows.Forms.Panel();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbRestaurar = new System.Windows.Forms.PictureBox();
            this.pbMaximizar = new System.Windows.Forms.PictureBox();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pMenu = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new TIENDA.PRODUCTOSDataSetTableAdapters.TableAdapterManager();
            this.pBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pBarraTitulo
            // 
            this.pBarraTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(5)))), ((int)(((byte)(50)))));
            this.pBarraTitulo.Controls.Add(this.pbMinimizar);
            this.pBarraTitulo.Controls.Add(this.pbRestaurar);
            this.pBarraTitulo.Controls.Add(this.pbMaximizar);
            this.pBarraTitulo.Controls.Add(this.pbCerrar);
            this.pBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pBarraTitulo.Name = "pBarraTitulo";
            this.pBarraTitulo.Size = new System.Drawing.Size(1262, 35);
            this.pBarraTitulo.TabIndex = 0;
            this.pBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBarraTitulo_MouseDown);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimizar.Image = global::TIENDA.Properties.Resources.MinimizarBlanco1;
            this.pbMinimizar.Location = new System.Drawing.Point(1163, 2);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(32, 32);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizar.TabIndex = 2;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            this.pbMinimizar.MouseEnter += new System.EventHandler(this.pbMinimizar_MouseEnter);
            this.pbMinimizar.MouseLeave += new System.EventHandler(this.pbMinimizar_MouseLeave);
            // 
            // pbRestaurar
            // 
            this.pbRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRestaurar.Image = global::TIENDA.Properties.Resources.MaximizarRestaurarBlanco;
            this.pbRestaurar.Location = new System.Drawing.Point(1196, 2);
            this.pbRestaurar.Name = "pbRestaurar";
            this.pbRestaurar.Size = new System.Drawing.Size(32, 32);
            this.pbRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRestaurar.TabIndex = 2;
            this.pbRestaurar.TabStop = false;
            this.pbRestaurar.Click += new System.EventHandler(this.pbRestaurar_Click);
            this.pbRestaurar.MouseEnter += new System.EventHandler(this.pbRestaurar_MouseEnter);
            this.pbRestaurar.MouseLeave += new System.EventHandler(this.pbRestaurar_MouseLeave);
            // 
            // pbMaximizar
            // 
            this.pbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMaximizar.Image = global::TIENDA.Properties.Resources.MaximizarRestaurarBlancoTrasparente;
            this.pbMaximizar.Location = new System.Drawing.Point(1196, 2);
            this.pbMaximizar.Name = "pbMaximizar";
            this.pbMaximizar.Size = new System.Drawing.Size(32, 32);
            this.pbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMaximizar.TabIndex = 2;
            this.pbMaximizar.TabStop = false;
            this.pbMaximizar.Click += new System.EventHandler(this.pbMaximizar_Click);
            this.pbMaximizar.MouseEnter += new System.EventHandler(this.pbMaximizar_MouseEnter);
            this.pbMaximizar.MouseLeave += new System.EventHandler(this.pbMaximizar_MouseLeave);
            // 
            // pbCerrar
            // 
            this.pbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCerrar.Image = global::TIENDA.Properties.Resources.CerrarBlanco;
            this.pbCerrar.Location = new System.Drawing.Point(1229, 2);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(32, 32);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 2;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            this.pbCerrar.MouseEnter += new System.EventHandler(this.pbCerrar_MouseEnter);
            this.pbCerrar.MouseLeave += new System.EventHandler(this.pbCerrar_MouseLeave);
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pLogo.Controls.Add(this.pictureBox1);
            this.pLogo.Location = new System.Drawing.Point(0, 36);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(173, 141);
            this.pLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TIENDA.Properties.Resources.Mi_proyecto__9_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pMenu.Controls.Add(this.panel10);
            this.pMenu.Controls.Add(this.panel8);
            this.pMenu.Controls.Add(this.panel6);
            this.pMenu.Controls.Add(this.panel4);
            this.pMenu.Controls.Add(this.panel2);
            this.pMenu.Controls.Add(this.btnPagos);
            this.pMenu.Controls.Add(this.btnEstadisticas);
            this.pMenu.Controls.Add(this.btnComprar);
            this.pMenu.Controls.Add(this.btnVentas);
            this.pMenu.Controls.Add(this.btnProductos);
            this.pMenu.Location = new System.Drawing.Point(0, 180);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(173, 287);
            this.pMenu.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.panel10.Location = new System.Drawing.Point(3, 231);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(7, 50);
            this.panel10.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.panel8.Location = new System.Drawing.Point(3, 175);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(7, 50);
            this.panel8.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.panel6.Location = new System.Drawing.Point(3, 119);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(7, 50);
            this.panel6.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.panel4.Location = new System.Drawing.Point(3, 59);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(7, 54);
            this.panel4.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 50);
            this.panel2.TabIndex = 2;
            // 
            // btnPagos
            // 
            this.btnPagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPagos.Location = new System.Drawing.Point(3, 231);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(167, 50);
            this.btnPagos.TabIndex = 0;
            this.btnPagos.Text = "CARTERA DE CLIENTE";
            this.btnPagos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnCarteraCliente_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstadisticas.FlatAppearance.BorderSize = 0;
            this.btnEstadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEstadisticas.Location = new System.Drawing.Point(3, 175);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(167, 50);
            this.btnEstadisticas.TabIndex = 0;
            this.btnEstadisticas.Text = "ESTADISTICAS";
            this.btnEstadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprar.FlatAppearance.BorderSize = 0;
            this.btnComprar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnComprar.Location = new System.Drawing.Point(3, 119);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(167, 50);
            this.btnComprar.TabIndex = 0;
            this.btnComprar.Text = "COMPRAS";
            this.btnComprar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVentas.Location = new System.Drawing.Point(3, 59);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(167, 54);
            this.btnVentas.TabIndex = 0;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProductos.Location = new System.Drawing.Point(3, 3);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(167, 50);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // pPrincipal
            // 
            this.pPrincipal.Location = new System.Drawing.Point(176, 36);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(1085, 618);
            this.pPrincipal.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Image = global::TIENDA.Properties.Resources.imglogout1;
            this.btnLogout.Location = new System.Drawing.Point(43, 593);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 40);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TIENDA.PRODUCTOSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1262, 656);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pPrincipal);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.pLogo);
            this.Controls.Add(this.pBarraTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.pLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pBarraTitulo;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbMaximizar;
        private System.Windows.Forms.PictureBox pbRestaurar;
        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private PRODUCTOSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnLogout;
    }
}

