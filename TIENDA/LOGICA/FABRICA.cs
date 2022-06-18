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
        //SE CREA UNA LISTA PARA ALMACENAR CADA EMPLEADO
        List<EMPLEADO> Empleados = new List<EMPLEADO>();
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
        //---------------------------------------------------------------------------------------------------------------------------
        //SE CREA UN METODO SET PARA AGREGAR LOS DATOS DEL EMPLEADO A LA LISTA
        public void setEmpleado(EMPLEADO empleado)
        {
            Empleados.Add(empleado);
            MessageBox.Show("Sus datos se almacenaron correctamente");
        }

        //METODO PARA OBTENER EL NUMERO DE EMPLEADOS
        public int getEmpleados()
        {
            int numEmpleados = 0;

            foreach (EMPLEADO empleados in Empleados)
            {
                numEmpleados ++;
            }
            return numEmpleados;
        }
    }
}
