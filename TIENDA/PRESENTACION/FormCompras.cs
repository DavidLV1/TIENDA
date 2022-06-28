using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIENDA.DATOS;
using TIENDA.LOGICA;

namespace TIENDA.PRESENTACION
{
    public partial class FormCompras : Form
    {
        FABRICA F = new FABRICA();
        public FormCompras()
        {
            InitializeComponent();
        }
        SqlConnection Conect = new SqlConnection(ConfigurationManager.ConnectionStrings["TIENDA.Properties.Settings.conexion"].ConnectionString);
        private void comprasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.comprasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pRODUCTOSDataSet);

        }

        private void FormCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pRODUCTOSDataSet.Compras' Puede moverla o quitarla según sea necesario.
            this.comprasTableAdapter.Fill(this.pRODUCTOSDataSet.Compras);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Conect.Open();
            try
            {
                PRODUCTO p = new PRODUCTO(); //de la Interfaz a la Memoria

                p.Codigo = int.Parse(txtCodigo.Text);
                p.Nombre = txtNombreProducto.Text;
                p.Marca = txtMarca.Text;
                p.PrecioCompra = decimal.Parse(txtPrecioCompra.Text);
                p.Cantidad = int.Parse(txtCantidad.Text);

                comprasTableAdapter.InsertarCompras(p.Codigo, p.Nombre, p.Marca, p.PrecioCompra, p.Cantidad);
                SqlCommand SumarCantidad = new SqlCommand("UPDATE Productos SET Cantidad = Cantidad +" + p.Cantidad + "WHERE Codigo =" +p.Codigo, Conect);
                SumarCantidad.ExecuteNonQuery();
                // TODO: esta línea de código carga datos en la tabla 'pRODUCTOSDataSet.Compras' Puede moverla o quitarla según sea necesario.
                this.comprasTableAdapter.Fill(this.pRODUCTOSDataSet.Compras);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conect.Close();
        }

        private void comprasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.comprasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pRODUCTOSDataSet);

        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if(txtCodigo.Text != string.Empty)
            {
                Conect.Open();
                SqlCommand Buscar = new SqlCommand("SELECT [Nombre del Producto], Marca FROM Productos WHERE Codigo =" + int.Parse(txtCodigo.Text), Conect);
                SqlDataReader lector = Buscar.ExecuteReader();

                if (lector.Read())
                {
                    txtNombreProducto.Text = lector["Nombre del Producto"].ToString();
                    txtMarca.Text = lector["Marca"].ToString();
                    Conect.Close();
                }
                else
                {
                    MessageBox.Show("Codigo de producto no existe");
                    txtCodigo.Text = string.Empty;
                    Conect.Close();
                }
            }
            Conect.Close();
        }
    }
}

