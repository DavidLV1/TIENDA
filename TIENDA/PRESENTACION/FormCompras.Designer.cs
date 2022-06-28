namespace TIENDA.PRESENTACION
{
    partial class FormCompras
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
            System.Windows.Forms.Label lblPrecioCompra;
            System.Windows.Forms.Label lblCantidad;
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTOSDataSet = new TIENDA.PRODUCTOSDataSet();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.comprasTableAdapter = new TIENDA.PRODUCTOSDataSetTableAdapters.ComprasTableAdapter();
            this.tableAdapterManager = new TIENDA.PRODUCTOSDataSetTableAdapters.TableAdapterManager();
            this.comprasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblCodigo = new System.Windows.Forms.Label();
            lblNombreProducto = new System.Windows.Forms.Label();
            lblMarca = new System.Windows.Forms.Label();
            lblPrecioCompra = new System.Windows.Forms.Label();
            lblCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.ForeColor = System.Drawing.Color.White;
            lblCodigo.Location = new System.Drawing.Point(25, 174);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new System.Drawing.Size(138, 16);
            lblCodigo.TabIndex = 15;
            lblCodigo.Text = "Codigo de Producto: *";
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.ForeColor = System.Drawing.Color.White;
            lblNombreProducto.Location = new System.Drawing.Point(25, 202);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new System.Drawing.Size(146, 16);
            lblNombreProducto.TabIndex = 17;
            lblNombreProducto.Text = "Nombre del Producto: *";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.ForeColor = System.Drawing.Color.White;
            lblMarca.Location = new System.Drawing.Point(25, 230);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new System.Drawing.Size(56, 16);
            lblMarca.TabIndex = 19;
            lblMarca.Text = "Marca: *";
            // 
            // lblPrecioCompra
            // 
            lblPrecioCompra.AutoSize = true;
            lblPrecioCompra.ForeColor = System.Drawing.Color.White;
            lblPrecioCompra.Location = new System.Drawing.Point(25, 258);
            lblPrecioCompra.Name = "lblPrecioCompra";
            lblPrecioCompra.Size = new System.Drawing.Size(127, 16);
            lblPrecioCompra.TabIndex = 21;
            lblPrecioCompra.Text = "Precio de Compra: *";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = System.Drawing.Color.White;
            lblCantidad.Location = new System.Drawing.Point(25, 286);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new System.Drawing.Size(72, 16);
            lblCantidad.TabIndex = 23;
            lblCantidad.Text = "Cantidad: *";
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
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "Codigo de Producto", true));
            this.txtCodigoProducto.Location = new System.Drawing.Point(177, 171);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoProducto.TabIndex = 16;
            this.txtCodigoProducto.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataMember = "Compras";
            this.comprasBindingSource.DataSource = this.pRODUCTOSDataSet;
            // 
            // pRODUCTOSDataSet
            // 
            this.pRODUCTOSDataSet.DataSetName = "PRODUCTOSDataSet";
            this.pRODUCTOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "Nombre del Producto", true));
            this.txtNombreProducto.Location = new System.Drawing.Point(177, 199);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 22);
            this.txtNombreProducto.TabIndex = 18;
            // 
            // txtMarca
            // 
            this.txtMarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "Marca", true));
            this.txtMarca.Location = new System.Drawing.Point(177, 227);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 22);
            this.txtMarca.TabIndex = 20;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(177, 255);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioCompra.TabIndex = 22;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(177, 283);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 24;
            // 
            // comprasTableAdapter
            // 
            this.comprasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = this.comprasTableAdapter;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TIENDA.PRODUCTOSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // comprasDataGridView
            // 
            this.comprasDataGridView.AutoGenerateColumns = false;
            this.comprasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.comprasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comprasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.comprasDataGridView.DataSource = this.comprasBindingSource;
            this.comprasDataGridView.Location = new System.Drawing.Point(292, 70);
            this.comprasDataGridView.Name = "comprasDataGridView";
            this.comprasDataGridView.RowHeadersWidth = 51;
            this.comprasDataGridView.RowTemplate.Height = 24;
            this.comprasDataGridView.Size = new System.Drawing.Size(770, 427);
            this.comprasDataGridView.TabIndex = 25;
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
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Precio de Compra";
            this.dataGridViewTextBoxColumn6.HeaderText = "Precio de Compra";
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
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1087, 581);
            this.Controls.Add(this.comprasDataGridView);
            this.Controls.Add(lblCodigo);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(lblNombreProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(lblMarca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(lblPrecioCompra);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCompras";
            this.Text = "FormCompras";
            this.Load += new System.EventHandler(this.FormCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtCantidad;
        private PRODUCTOSDataSet pRODUCTOSDataSet;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private PRODUCTOSDataSetTableAdapters.ComprasTableAdapter comprasTableAdapter;
        private PRODUCTOSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView comprasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}