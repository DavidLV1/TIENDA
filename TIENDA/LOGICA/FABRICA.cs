using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIENDA.DATOS;

namespace TIENDA.LOGICA
{
    internal class FABRICA
    {
        //SE CREA UNA LISTA PARA ALMACENAR CADA PRODUCTO
        List<PRODUCTO> Productos = new List<PRODUCTO>();
        //---------------------------------------------------------------------------------------------------------------------------
        //SE CREA UN METODO SET PARA AGREGAR LOS DATOS DEL PRODUCTO A LA LISTA
        public void setProducto(PRODUCTO producto)
        {
            Productos.Add(producto);
        }

        private void ActualizarProductos(int cantidad, int codigo)
        {
            PRODUCTOSDataSetTableAdapters.ProductosTableAdapter productosTableAdapter = new PRODUCTOSDataSetTableAdapters.ProductosTableAdapter();
            
            productosTableAdapter.ActualizarCantidad(cantidad, codigo);
        }
    }
}
