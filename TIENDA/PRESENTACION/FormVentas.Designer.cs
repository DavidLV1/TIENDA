namespace TIENDA.PRESENTACION
{
    partial class FormVentas
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
            System.Windows.Forms.Label lblCodigo;
            System.Windows.Forms.Label lblNombreProducto;
            System.Windows.Forms.Label lblMarca;
            System.Windows.Forms.Label lblPrecio;
            System.Windows.Forms.Label lblCantidad;
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTOSDataSet = new TIENDA.PRODUCTOSDataSet();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.lblFactura = new System.Windows.Forms.Label();
            this.ventasTableAdapter = new TIENDA.PRODUCTOSDataSetTableAdapters.VentasTableAdapter();
            this.tableAdapterManager = new TIENDA.PRODUCTOSDataSetTableAdapters.TableAdapterManager();
            this.ventasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblCodigo = new System.Windows.Forms.Label();
            lblNombreProducto = new System.Windows.Forms.Label();
            lblMarca = new System.Windows.Forms.Label();
            lblPrecio = new System.Windows.Forms.Label();
            lblCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.ForeColor = System.Drawing.Color.White;
            lblCodigo.Location = new System.Drawing.Point(25, 174);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new System.Drawing.Size(138, 16);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Codigo de Producto: *";
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.ForeColor = System.Drawing.Color.White;
            lblNombreProducto.Location = new System.Drawing.Point(25, 202);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new System.Drawing.Size(146, 16);
            lblNombreProducto.TabIndex = 3;
            lblNombreProducto.Text = "Nombre del Producto: *";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.ForeColor = System.Drawing.Color.White;
            lblMarca.Location = new System.Drawing.Point(25, 230);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new System.Drawing.Size(56, 16);
            lblMarca.TabIndex = 5;
            lblMarca.Text = "Marca: *";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.ForeColor = System.Drawing.Color.White;
            lblPrecio.Location = new System.Drawing.Point(25, 258);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new System.Drawing.Size(57, 16);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio: *";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = System.Drawing.Color.White;
            lblCantidad.Location = new System.Drawing.Point(25, 286);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new System.Drawing.Size(72, 16);
            lblCantidad.TabIndex = 9;
            lblCantidad.Text = "Cantidad: *";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "Codigo de Producto", true));
            this.txtCodigoProducto.Location = new System.Drawing.Point(177, 171);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoProducto.TabIndex = 2;
            this.txtCodigoProducto.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoProducto_KeyPress);
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "Ventas";
            this.ventasBindingSource.DataSource = this.pRODUCTOSDataSet;
            // 
            // pRODUCTOSDataSet
            // 
            this.pRODUCTOSDataSet.DataSetName = "PRODUCTOSDataSet";
            this.pRODUCTOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "Nombre del Producto", true));
            this.txtNombreProducto.Location = new System.Drawing.Point(177, 199);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 22);
            this.txtNombreProducto.TabIndex = 4;
            // 
            // txtMarca
            // 
            this.txtMarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "Marca", true));
            this.txtMarca.Location = new System.Drawing.Point(177, 227);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 22);
            this.txtMarca.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(177, 255);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 8;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(177, 283);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 10;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(100)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Location = new System.Drawing.Point(117, 347);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 29);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(100)))));
            this.btnFactura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnFactura.FlatAppearance.BorderSize = 2;
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactura.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFactura.Location = new System.Drawing.Point(177, 429);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(80, 29);
            this.btnFactura.TabIndex = 14;
            this.btnFactura.Text = "Factura";
            this.btnFactura.UseVisualStyleBackColor = false;
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.ForeColor = System.Drawing.Color.White;
            this.lblFactura.Location = new System.Drawing.Point(67, 435);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(107, 16);
            this.lblFactura.TabIndex = 16;
            this.lblFactura.Text = "Generar Factura:";
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TIENDA.PRODUCTOSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = this.ventasTableAdapter;
            // 
            // ventasDataGridView
            // 
            this.ventasDataGridView.AutoGenerateColumns = false;
            this.ventasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ventasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ventasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.ventasDataGridView.DataSource = this.ventasBindingSource;
            this.ventasDataGridView.Location = new System.Drawing.Point(292, 70);
            this.ventasDataGridView.Name = "ventasDataGridView";
            this.ventasDataGridView.RowHeadersWidth = 51;
            this.ventasDataGridView.RowTemplate.Height = 24;
            this.ventasDataGridView.Size = new System.Drawing.Size(770, 427);
            this.ventasDataGridView.TabIndex = 17;
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
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1087, 581);
            this.Controls.Add(this.ventasDataGridView);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(lblCodigo);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(lblNombreProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(lblMarca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(lblPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Label lblFactura;
        private PRODUCTOSDataSet pRODUCTOSDataSet;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private PRODUCTOSDataSetTableAdapters.VentasTableAdapter ventasTableAdapter;
        private PRODUCTOSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView ventasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}