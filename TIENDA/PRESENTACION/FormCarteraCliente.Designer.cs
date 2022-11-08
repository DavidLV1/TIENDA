namespace TIENDA.PRESENTACION
{
    partial class FormCarteraCliente
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
            System.Windows.Forms.Label lblCodigoCliente;
            System.Windows.Forms.Label lblNombreCliente;
            this.pRODUCTOSDataSet = new TIENDA.PRODUCTOSDataSet();
            this.clientesTableAdapter = new TIENDA.PRODUCTOSDataSetTableAdapters.ClientesTableAdapter();
            this.clientesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new TIENDA.PRODUCTOSDataSetTableAdapters.TableAdapterManager();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            lblCodigoCliente = new System.Windows.Forms.Label();
            lblNombreCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoCliente
            // 
            lblCodigoCliente.AutoSize = true;
            lblCodigoCliente.ForeColor = System.Drawing.Color.White;
            lblCodigoCliente.Location = new System.Drawing.Point(35, 174);
            lblCodigoCliente.Name = "lblCodigoCliente";
            lblCodigoCliente.Size = new System.Drawing.Size(125, 16);
            lblCodigoCliente.TabIndex = 1;
            lblCodigoCliente.Text = "Codigo de Cliente: *";
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.ForeColor = System.Drawing.Color.White;
            lblNombreCliente.Location = new System.Drawing.Point(35, 202);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new System.Drawing.Size(130, 16);
            lblNombreCliente.TabIndex = 3;
            lblNombreCliente.Text = "Nombre de Cliente: *";
            // 
            // pRODUCTOSDataSet
            // 
            this.pRODUCTOSDataSet.DataSetName = "PRODUCTOSDataSet";
            this.pRODUCTOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // clientesDataGridView
            // 
            this.clientesDataGridView.AutoGenerateColumns = false;
            this.clientesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.clientesDataGridView.DataSource = this.clientesBindingSource;
            this.clientesDataGridView.Location = new System.Drawing.Point(292, 70);
            this.clientesDataGridView.Name = "clientesDataGridView";
            this.clientesDataGridView.RowHeadersWidth = 51;
            this.clientesDataGridView.RowTemplate.Height = 24;
            this.clientesDataGridView.Size = new System.Drawing.Size(770, 427);
            this.clientesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo de Cliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo de Cliente";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre de Cliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre de Cliente";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.pRODUCTOSDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TIENDA.PRODUCTOSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Codigo de Cliente", true));
            this.txtCodigoCliente.Location = new System.Drawing.Point(177, 171);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoCliente.TabIndex = 2;
            this.txtCodigoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoCliente_KeyPress);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Nombre de Cliente", true));
            this.txtNombreCliente.Location = new System.Drawing.Point(177, 199);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 22);
            this.txtNombreCliente.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(100)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Location = new System.Drawing.Point(123, 279);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 29);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FormCarteraCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(15)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1087, 581);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(lblCodigoCliente);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(lblNombreCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.clientesDataGridView);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCarteraCliente";
            this.Text = "FormEmpleados";
            this.Load += new System.EventHandler(this.FormCarteraCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PRODUCTOSDataSet pRODUCTOSDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private PRODUCTOSDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private PRODUCTOSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView clientesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Button btnAgregar;
    }
}