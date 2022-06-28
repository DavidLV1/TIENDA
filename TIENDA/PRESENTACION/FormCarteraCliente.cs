using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIENDA.PRESENTACION
{
    public partial class FormCarteraCliente : Form
    {
        public FormCarteraCliente()
        {
            InitializeComponent();
        }

        private void FormCarteraCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pRODUCTOSDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.pRODUCTOSDataSet.Clientes);

        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pRODUCTOSDataSet);

        }
    }
}
