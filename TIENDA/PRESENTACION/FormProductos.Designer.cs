namespace TIENDA
{
    partial class FormProductos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblCodigoProducto;
            System.Windows.Forms.Label lblNombreProducto;
            System.Windows.Forms.Label lblMarca;
            System.Windows.Forms.Label lblPrecio;
            System.Windows.Forms.Label lblCantidad;
            System.Windows.Forms.Label lblCategoria;
            System.Windows.Forms.Label lblCodigoProducto2;
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pRODUCTOSDataSet = new TIENDA.PRODUCTOSDataSet();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new TIENDA.PRODUCTOSDataSetTableAdapters.ProductosTableAdapter();
            this.tableAdapterManager = new TIENDA.PRODUCTOSDataSetTableAdapters.TableAdapterManager();
            this.productosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblCodigoProducto3 = new System.Windows.Forms.Label();
            lblCodigoProducto = new System.Windows.Forms.Label();
            lblNombreProducto = new System.Windows.Forms.Label();
            lblMarca = new System.Windows.Forms.Label();
            lblPrecio = new System.Windows.Forms.Label();
            lblCantidad = new System.Windows.Forms.Label();
            lblCategoria = new System.Windows.Forms.Label();
            lblCodigoProducto2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoProducto
            // 
            lblCodigoProducto.AutoSize = true;
            lblCodigoProducto.ForeColor = System.Drawing.Color.White;
            lblCodigoProducto.Location = new System.Drawing.Point(23, 174);
            lblCodigoProducto.Name = "lblCodigoProducto";
            lblCodigoProducto.Size = new System.Drawing.Size(138, 16);
            lblCodigoProducto.TabIndex = 34;
            lblCodigoProducto.Text = "Codigo de Producto: *";
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.ForeColor = System.Drawing.Color.White;
            lblNombreProducto.Location = new System.Drawing.Point(25, 202);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new System.Drawing.Size(146, 16);
            lblNombreProducto.TabIndex = 36;
            lblNombreProducto.Text = "Nombre del Producto: *";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.ForeColor = System.Drawing.Color.White;
            lblMarca.Location = new System.Drawing.Point(23, 230);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new System.Drawing.Size(56, 16);
            lblMarca.TabIndex = 38;
            lblMarca.Text = "Marca: *";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.ForeColor = System.Drawing.Color.White;
            lblPrecio.Location = new System.Drawing.Point(23, 258);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new System.Drawing.Size(57, 16);
            lblPrecio.TabIndex = 40;
            lblPrecio.Text = "Precio: *";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = System.Drawing.Color.White;
            lblCantidad.Location = new System.Drawing.Point(23, 286);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new System.Drawing.Size(72, 16);
            lblCantidad.TabIndex = 42;
            lblCantidad.Text = "Cantidad: *";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.ForeColor = System.Drawing.Color.White;
            lblCategoria.Location = new System.Drawing.Point(23, 314);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new System.Drawing.Size(77, 16);
            lblCategoria.TabIndex = 44;
            lblCategoria.Text = "Categoria: *";
            // 
            // lblCodigoProducto2
            // 
            lblCodigoProducto2.AutoSize = true;
            lblCodigoProducto2.ForeColor = System.Drawing.Color.White;
            lblCodigoProducto2.Location = new System.Drawing.Point(23, 463);
            lblCodigoProducto2.Name = "lblCodigoProducto2";
            lblCodigoProducto2.Size = new System.Drawing.Size(130, 16);
            lblCodigoProducto2.TabIndex = 45;
            lblCodigoProducto2.Text = "Codigo de Producto:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(100)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Location = new System.Drawing.Point(63, 355);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 29);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(100)))));
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnActualizar.FlatAppearance.BorderSize = 2;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.Location = new System.Drawing.Point(169, 355);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(80, 29);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(100)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEliminar.FlatAppearance.BorderSize = 2;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Location = new System.Drawing.Point(206, 457);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 29);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(100)))));
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNuevo.FlatAppearance.BorderSize = 2;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.Location = new System.Drawing.Point(54, 116);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(80, 29);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // pRODUCTOSDataSet
            // 
            this.pRODUCTOSDataSet.DataSetName = "PRODUCTOSDataSet";
            this.pRODUCTOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.pRODUCTOSDataSet;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.UpdateOrder = TIENDA.PRODUCTOSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // productosDataGridView
            // 
            this.productosDataGridView.AutoGenerateColumns = false;
            this.productosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.productosDataGridView.DataSource = this.productosBindingSource;
            this.productosDataGridView.Location = new System.Drawing.Point(292, 70);
            this.productosDataGridView.Name = "productosDataGridView";
            this.productosDataGridView.RowHeadersWidth = 51;
            this.productosDataGridView.RowTemplate.Height = 24;
            this.productosDataGridView.Size = new System.Drawing.Size(770, 427);
            this.productosDataGridView.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Codigo de Producto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Codigo de Producto";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nombre del Producto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre del Producto";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn5.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn6.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Categoria";
            this.dataGridViewTextBoxColumn8.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Codigo de Producto", true));
            this.txtCodigoProducto.Location = new System.Drawing.Point(177, 171);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoProducto.TabIndex = 35;
            this.txtCodigoProducto.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Nombre del Producto", true));
            this.txtNombreProducto.Location = new System.Drawing.Point(177, 199);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 22);
            this.txtNombreProducto.TabIndex = 37;
            // 
            // txtMarca
            // 
            this.txtMarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Marca", true));
            this.txtMarca.Location = new System.Drawing.Point(177, 227);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 22);
            this.txtMarca.TabIndex = 39;
            // 
            // txtPrecio
            // 
            this.txtPrecio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Precio", true));
            this.txtPrecio.Location = new System.Drawing.Point(177, 255);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 41;
            // 
            // txtCantidad
            // 
            this.txtCantidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Cantidad", true));
            this.txtCantidad.Location = new System.Drawing.Point(177, 283);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 43;
            // 
            // txtCategoria
            // 
            this.txtCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Categoria", true));
            this.txtCategoria.Location = new System.Drawing.Point(177, 311);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(100, 22);
            this.txtCategoria.TabIndex = 45;
            // 
            // lblCodigoProducto3
            // 
            this.lblCodigoProducto3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Codigo de Producto", true));
            this.lblCodigoProducto3.ForeColor = System.Drawing.Color.White;
            this.lblCodigoProducto3.Location = new System.Drawing.Point(159, 463);
            this.lblCodigoProducto3.Name = "lblCodigoProducto3";
            this.lblCodigoProducto3.Size = new System.Drawing.Size(47, 50);
            this.lblCodigoProducto3.TabIndex = 46;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1087, 581);
            this.Controls.Add(lblCodigoProducto2);
            this.Controls.Add(this.lblCodigoProducto3);
            this.Controls.Add(lblCodigoProducto);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(lblNombreProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(lblMarca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(lblPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(lblCategoria);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.productosDataGridView);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnAgregar);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private PRODUCTOSDataSet pRODUCTOSDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private PRODUCTOSDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private PRODUCTOSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView productosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblCodigoProducto3;
    }
}